using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using MoonSharp.Interpreter;
using Minecraft_But_Classes;
using ICSharpCode.SharpZipLib.Zip;



namespace Minecraft_But
{
    public partial class Tool : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        System.Drawing.Font McFont;
        Bitmap preview;
        List<Effect> process = new List<Effect>();
        List<Bitmap> previewProg = new List<Bitmap>();

        List<Effect> effectList;

        public Tool()
        {
            InitializeComponent();
            consoleWindow(showConsoleToolStripMenuItem.Checked);
            //Load Minecraft Font
            byte[] fontData = Properties.Resources.Minecraft;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Minecraft.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Minecraft.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            McFont = new System.Drawing.Font(fonts.Families[0], 16.0F);

            if (!Directory.Exists(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\template"))
            {
                DialogResult result;
                result = MessageBox.Show("Minecraft assets not found, do you want to automaticly extract them from the minecraft jar?", "Assets not found", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ExtractAssets();
                }
            }

            //Create Preview image
            preview = Properties.Resources.grassX16;

            previewProg.Add(Properties.Resources.grassX16);
            KeyPreview = true;
        }

        public void ExtractAssets()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "JAR file (*.jar)|*.jar|All files (*.*)|*.*";
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (Directory.Exists(appdata + @"\.minecraft\versions\"))
                OFD.InitialDirectory = appdata + @"\.minecraft\versions\";
            else OFD.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            OFD.Title = "Select minecraft version";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                consoleWindow(true);
                FastZip fz = new FastZip();
                Console.WriteLine("Extracting JAR");
                fz.ExtractZip(Path.GetFullPath(OFD.FileName), Path.GetTempPath() + @"Minecraft But\jar\", "");
                if (Directory.Exists(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\template"))
                {
                    Console.WriteLine("Deleting " + Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\template");
                    try
                    {
                        Export.DeleteDirectory(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\template");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Problem occured while deleting " + Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\template" + " the folder or an item in it may be opened in a process", "Minecraft but... its an error screen");
                        Console.WriteLine("Aborting asset extraction");
                        return;
                    }
                }
                Console.WriteLine("Creating " + Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\template");
                Directory.CreateDirectory(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\template");
                Console.WriteLine("Copying JAR assets to " + Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\template");
                DirectoryCopy(Path.GetTempPath() + @"Minecraft But\jar\assets\minecraft\", Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\template\assets\minecraft", true);
                if (Directory.Exists(Path.GetTempPath() + @"Minecraft But\jar\"))
                {
                    Console.WriteLine("Deleting " + (Path.GetTempPath() + @"Minecraft But\jar\"));
                    try
                    {
                        Export.DeleteDirectory(Path.GetDirectoryName((Path.GetTempPath() + @"Minecraft But\jar\")));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Problem occured while deleting " + Path.GetTempPath() + @"Minecraft But\jar\" + " the folder or an item in it may be opened in a process", "Minecraft but... its an error screen");
                        Console.WriteLine("Temp folder not removed");
                    }
                }
            }
            Console.WriteLine("Finished extracting");
            consoleWindow(showConsoleToolStripMenuItem.Checked);
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void Tool_Load(object sender, EventArgs e)
        {
            //Set Fonts
            ImageEffects.Font = McFont;
            HistoryTextBox.Font = McFont;
            EffectsLabel.Font = McFont;
            HistoryLabel.Font = McFont;
            PreviewLabel.Font = McFont;
            versionToolStripMenuItem.Font = McFont;


            foreach (ToolStripMenuItem item in ToolMainMenuStrip.Items)
            {
                item.Font = McFont;
            }


            //Effects
            ImageEffects.BeginUpdate();
            String path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory) + @"\plugins\";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            FileInfo[] effects = new DirectoryInfo(path).GetFiles("*.lua");
            effectList = new List<Effect>();
            foreach (FileInfo effect in effects)
            {
                Script lua = new Script();
                try
                {
                    lua.DoFile(effect.FullName);
                    ImageEffects.Items.Add(lua.Globals["name"]);
                    effectList.Add(new Effect(lua.Globals["name"].ToString(), effect));
                }
                catch (InterpreterException error)
                {
                    MessageBox.Show($@"Plugin {effect.Name} encountered an error:
{error.Message}", "Lua error");
                }
            }
            ImageEffects.EndUpdate();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About(McFont);
            about.ShowDialog();
        }

        private void ImageEffects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ImageEffects.SelectedItem != null)
            {
                process.Add(effectList[ImageEffects.SelectedIndex]);
                HistoryTextBox.Items.Add(ImageEffects.SelectedItem + "");


                preview = new Bitmap(Effects.ApplyEffect(preview, effectList[ImageEffects.SelectedIndex].fileInfo));
                previewProg.Add(preview);
                PreviewPanel.BackgroundImage = Effects.ResizeImage(preview, 100, 100);

                ImageEffects.ClearSelected();
            }
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void ToolKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Undo();
            }

        }

        private void Undo()
        {
            if (process.Count > 0)
            {
                process.RemoveAt(process.Count - 1);
                HistoryTextBox.Items.RemoveAt(HistoryTextBox.Items.Count - 1);

                previewProg.RemoveAt(previewProg.Count - 1);
                preview = previewProg[previewProg.Count - 1];
                PreviewPanel.BackgroundImage = new Bitmap(Effects.ResizeImage(preview, 100, 100));
                PreviewPanel.Refresh();
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export export = new Export(McFont, process.ToArray(), preview);
            export.ShowDialog();
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtractAssets();
        }

        private void showConsoleItem_Checked(object sender, EventArgs e)
        {

            consoleWindow(showConsoleToolStripMenuItem.Checked);
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        void consoleWindow(bool show)
        {
            var handle = GetConsoleWindow();
            if (show) ShowWindow(handle, 5);
            else ShowWindow(handle, 0);
        }
    }
}
