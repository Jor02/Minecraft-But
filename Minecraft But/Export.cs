using Minecraft_But_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

namespace Minecraft_But
{
    public partial class Export : Form
    {

        ExportSettings settings = new ExportSettings();

        Effect[] process;

        Bitmap preview;

        string cur = "";

        ProgressBarForm prog;

        Font mcfont;

        String FilePath;

        bool finished = false;

        public Export(Font McFont, Effect[] inProcess, Bitmap Preview)
        {
            InitializeComponent();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            KeyPreview = true;

            ExportButton.Font = McFont;
            ExportLabel.Font = McFont;
            mcfont = McFont;

            process = inProcess;
            preview = Preview;
        }

        private void Export_Load(object sender, EventArgs e)
        {

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "ZIP archive (*.zip)|*.zip|All files (*.*)|*.*";
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (Directory.Exists(appdata + @"\.minecraft\resourcepacks\"))
                SFD.InitialDirectory = appdata + @"\.minecraft\resourcepacks\";
            else SFD.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            SFD.Title = "Select export directory";
            FileStream Filestream;
            SyncExportSettings();

            if (SFD.ShowDialog() == DialogResult.OK)
            {
                /*if ((Filestream = (FileStream)SFD.OpenFile()) != null)
                {
                    Filestream.Close();
                }*/
            }
            else
            {
                this.Close();
                return;
            }

            FilePath = Path.GetFullPath(SFD.FileName);

            if (!backgroundWorker1.IsBusy)
            {
                finished = false;
                backgroundWorker1.RunWorkerAsync(argument: settings);
                prog = new ProgressBarForm(mcfont, "Exporting");
                prog.Show();
                prog.FormClosed += Prog_FormClosed;
            }
        }

        private void SyncExportSettings()
        {
            settings.unicode = UnicodeBox.Checked;
            settings.blocks = BlocksBox.Checked;
            settings.items = ItemsBox.Checked;
            settings.colormap = ColormapBox.Checked;
            settings.effect = EffectsBox.Checked;
            settings.entity = EntityBox.Checked;
            settings.environment = EnviormentBox.Checked;
            settings.gui = GUIBox.Checked;
            settings.map = MapBox.Checked;
            settings.misc = MiscBox.Checked;
            settings.potion = PotionBox.Checked;
            settings.armor = ArmorBox.Checked;
            settings.painting = PaintingBox.Checked;
            settings.particle = ParticleBox.Checked;
        }

        private void Prog_FormClosed(object sender, FormClosedEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            backgroundWorker1.Dispose();
        }

        private string[] LoadSubDirs(string dir)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            List<string> output = new List<string>(subdirectoryEntries);
            foreach (string subdirectory in subdirectoryEntries)
            {
                string[] subs = LoadSubDirs(subdirectory);
                foreach (string sub in subs)
                {
                    output.Add(sub);
                }
            }
            return output.ToArray();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ExportSettings Settings = (ExportSettings) e.Argument;
            BackgroundWorker worker = sender as BackgroundWorker;

            //Do the exporting
            String path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            String tempPath = Path.GetTempPath() + @"Minecraft But\";

            DirectoryInfo dirinfo = new DirectoryInfo(path + @"\template");
            List<FileInfo> files = new List<FileInfo>();
            foreach (string subpath in LoadSubDirs(path + @"\template"))
            {
                foreach (FileInfo fileinf in new DirectoryInfo(subpath).GetFiles("*.png"))
                {
                    files.Add(fileinf);
                }
            }

            if (Directory.Exists(tempPath + @"\export\"))
            {
                try
                {
                    DeleteDirectory(tempPath + @"\export\");
                }
                catch (Exception)
                {
                    MessageBox.Show("Problem occured while deleting " + tempPath + " the folder or an item in it may be opened in a process", "Minecraft but... its an error screen");
                    backgroundWorker1.CancelAsync();
                }
            }

            List<Bitmap> bmp = new List<Bitmap>();
            files.ForEach(fi =>
            {
                String curpath = fi.FullName.Replace(path + @"\template", "");
                //Export settings:
                //Skip if canceling export
                if (backgroundWorker1.CancellationPending) return;

                if (curpath.StartsWith(@"\assets\minecraft\textures\block") && !settings.blocks) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\item") && !settings.items) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\font") && !settings.unicode) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\colormap") && !settings.colormap) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\effect") && !settings.effect) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\entity") && !settings.entity) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\environment") && !settings.environment) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\gui") && !settings.gui) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\map") && !settings.map) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\misc") && !settings.misc) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\mob_effect") && !settings.potion) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\models") && !settings.armor) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\painting") && !settings.painting) return;
                if (curpath.StartsWith(@"\assets\minecraft\textures\particle") && !settings.particle) return;

                ///////////////////
                //Start exporting//
                ///////////////////

                cur = curpath;

                //Report current progress
                worker.ReportProgress((int)(((float)files.IndexOf(fi) / (float)files.Count) * 100));
                Bitmap bmpIn = new Bitmap(Image.FromFile(fi.FullName));

                //Apply all effects
                foreach (Effect x in process)
                {
                    bmpIn = Effects.ApplyEffect(bmpIn, x.fileInfo);
                    if (backgroundWorker1.CancellationPending) return;
                }
                bmp.Add(bmpIn);
                Bitmap bmpOut = new Bitmap(bmpIn);

                Directory.CreateDirectory(tempPath + @"\export\" + Path.GetDirectoryName(curpath));

                //Copy mcmeta
                string path2 = curpath + ".mcmeta";

                if (File.Exists(path + @"\template" + path2))
                {
                    Console.WriteLine("mcmeta file found");
                    File.Copy(path + @"\template" + path2, tempPath + @"\export" + path2);
                }

                //Save PNG file
                bmpOut.Save(tempPath + @"\export\" + curpath, ImageFormat.Png);
                bmpOut.Dispose();
            });

            if (backgroundWorker1.CancellationPending) return;

            cur = "Adding pack.mcmeta";
            worker.ReportProgress(99);
            File.WriteAllText(tempPath + @"\export\pack.mcmeta", System.Text.Encoding.UTF8.GetString(Properties.Resources.pack));
            cur = "Adding pack.png";
            worker.ReportProgress(99);
            preview.Save(tempPath + @"\export\pack.png", ImageFormat.Png);

            cur = "Zipping file";
            worker.ReportProgress(99);
            if (File.Exists(FilePath)) File.Delete(FilePath);
            ZipFile.CreateFromDirectory(tempPath + @"\export", FilePath);
            cur = "Finished!";
            finished = true;
            worker.ReportProgress(100);
            MessageBox.Show("Export Finished");
            return;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prog.ChangeProgress(cur, e.ProgressPercentage);
            if (finished)
            {
                prog.ButtonText("Done");
            }
        }

        public static void DeleteDirectory(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }
    }
}
