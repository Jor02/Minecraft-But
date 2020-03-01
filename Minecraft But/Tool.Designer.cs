namespace Minecraft_But
{
    partial class Tool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            this.ToolMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.ImageEffects = new System.Windows.Forms.ListBox();
            this.HistoryTextBox = new System.Windows.Forms.ListBox();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.EffectsLabel = new System.Windows.Forms.Label();
            this.tabEffects = new System.Windows.Forms.TabControl();
            this.tabImageEffects = new System.Windows.Forms.TabPage();
            this.tabRandomize = new System.Windows.Forms.TabPage();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolMainMenuStrip.SuspendLayout();
            this.tabEffects.SuspendLayout();
            this.tabImageEffects.SuspendLayout();
            this.tabRandomize.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolMainMenuStrip
            // 
            this.ToolMainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.ToolMainMenuStrip.BackgroundImage = global::Minecraft_But.Properties.Resources.Dirt;
            this.ToolMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.ToolMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolMainMenuStrip.Name = "ToolMainMenuStrip";
            this.ToolMainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolMainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.ToolMainMenuStrip.TabIndex = 0;
            this.ToolMainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.BackgroundImage")));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.BackgroundImage")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.BackgroundImage")));
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.BackgroundImage")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolsToolStripMenuItem.BackgroundImage")));
            this.toolsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.toolsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolsToolStripMenuItem.Image")));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.versionToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("versionToolStripMenuItem.BackgroundImage")));
            this.versionToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.versionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.versionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("versionToolStripMenuItem.Image")));
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.versionToolStripMenuItem.Text = "Extract minecraft assets";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.BackgroundImage")));
            this.helpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.BackgroundImage")));
            this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPanel.BackColor = System.Drawing.Color.Black;
            this.PreviewPanel.BackgroundImage = global::Minecraft_But.Properties.Resources.grass;
            this.PreviewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PreviewPanel.Location = new System.Drawing.Point(613, 48);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Padding = new System.Windows.Forms.Padding(40);
            this.PreviewPanel.Size = new System.Drawing.Size(175, 175);
            this.PreviewPanel.TabIndex = 3;
            // 
            // ImageEffects
            // 
            this.ImageEffects.BackColor = System.Drawing.Color.White;
            this.ImageEffects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImageEffects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageEffects.ForeColor = System.Drawing.Color.Black;
            this.ImageEffects.FormattingEnabled = true;
            this.ImageEffects.Location = new System.Drawing.Point(3, 3);
            this.ImageEffects.Margin = new System.Windows.Forms.Padding(0);
            this.ImageEffects.Name = "ImageEffects";
            this.ImageEffects.Size = new System.Drawing.Size(219, 358);
            this.ImageEffects.TabIndex = 4;
            this.ImageEffects.SelectedIndexChanged += new System.EventHandler(this.ImageEffects_SelectedIndexChanged);
            // 
            // HistoryTextBox
            // 
            this.HistoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryTextBox.FormattingEnabled = true;
            this.HistoryTextBox.Location = new System.Drawing.Point(613, 252);
            this.HistoryTextBox.Name = "HistoryTextBox";
            this.HistoryTextBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.HistoryTextBox.Size = new System.Drawing.Size(175, 186);
            this.HistoryTextBox.TabIndex = 7;
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.BackColor = System.Drawing.Color.Transparent;
            this.PreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewLabel.ForeColor = System.Drawing.Color.White;
            this.PreviewLabel.Location = new System.Drawing.Point(610, 29);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(67, 16);
            this.PreviewLabel.TabIndex = 8;
            this.PreviewLabel.Text = "Preview:";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.HistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.ForeColor = System.Drawing.Color.White;
            this.HistoryLabel.Location = new System.Drawing.Point(610, 233);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(147, 16);
            this.HistoryLabel.TabIndex = 9;
            this.HistoryLabel.Text = "Image effect history:";
            // 
            // EffectsLabel
            // 
            this.EffectsLabel.AutoSize = true;
            this.EffectsLabel.BackColor = System.Drawing.Color.Transparent;
            this.EffectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectsLabel.ForeColor = System.Drawing.Color.White;
            this.EffectsLabel.Location = new System.Drawing.Point(12, 29);
            this.EffectsLabel.Name = "EffectsLabel";
            this.EffectsLabel.Size = new System.Drawing.Size(97, 16);
            this.EffectsLabel.TabIndex = 10;
            this.EffectsLabel.Text = "Pack effects:";
            // 
            // tabEffects
            // 
            this.tabEffects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabEffects.Controls.Add(this.tabImageEffects);
            this.tabEffects.Controls.Add(this.tabRandomize);
            this.tabEffects.HotTrack = true;
            this.tabEffects.Location = new System.Drawing.Point(15, 48);
            this.tabEffects.Name = "tabEffects";
            this.tabEffects.SelectedIndex = 0;
            this.tabEffects.Size = new System.Drawing.Size(233, 390);
            this.tabEffects.TabIndex = 11;
            // 
            // tabImageEffects
            // 
            this.tabImageEffects.BackgroundImage = global::Minecraft_But.Properties.Resources.darkstone;
            this.tabImageEffects.Controls.Add(this.ImageEffects);
            this.tabImageEffects.Location = new System.Drawing.Point(4, 22);
            this.tabImageEffects.Name = "tabImageEffects";
            this.tabImageEffects.Padding = new System.Windows.Forms.Padding(3);
            this.tabImageEffects.Size = new System.Drawing.Size(225, 364);
            this.tabImageEffects.TabIndex = 0;
            this.tabImageEffects.Text = "Image effects";
            this.tabImageEffects.UseVisualStyleBackColor = true;
            // 
            // tabRandomize
            // 
            this.tabRandomize.BackgroundImage = global::Minecraft_But.Properties.Resources.darkstone;
            this.tabRandomize.Controls.Add(this.label1);
            this.tabRandomize.Location = new System.Drawing.Point(4, 22);
            this.tabRandomize.Name = "tabRandomize";
            this.tabRandomize.Padding = new System.Windows.Forms.Padding(3);
            this.tabRandomize.Size = new System.Drawing.Size(225, 364);
            this.tabRandomize.TabIndex = 1;
            this.tabRandomize.Text = "Randomizers";
            this.tabRandomize.UseVisualStyleBackColor = true;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.BackgroundImage")));
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showConsoleToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // showConsoleToolStripMenuItem
            // 
            this.showConsoleToolStripMenuItem.BackgroundImage = global::Minecraft_But.Properties.Resources.stone;
            this.showConsoleToolStripMenuItem.CheckOnClick = true;
            this.showConsoleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showConsoleToolStripMenuItem.Name = "showConsoleToolStripMenuItem";
            this.showConsoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showConsoleToolStripMenuItem.Text = "Show console";
            this.showConsoleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showConsoleItem_Checked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "This feature is not implemented yet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minecraft_But.Properties.Resources.stone;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabEffects);
            this.Controls.Add(this.EffectsLabel);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.HistoryTextBox);
            this.Controls.Add(this.PreviewPanel);
            this.Controls.Add(this.ToolMainMenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Minecraft But...";
            this.Load += new System.EventHandler(this.Tool_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolKeyDown);
            this.ToolMainMenuStrip.ResumeLayout(false);
            this.ToolMainMenuStrip.PerformLayout();
            this.tabEffects.ResumeLayout(false);
            this.tabImageEffects.ResumeLayout(false);
            this.tabRandomize.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ToolMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel PreviewPanel;
        private System.Windows.Forms.ListBox ImageEffects;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ListBox HistoryTextBox;
        private System.Windows.Forms.Label PreviewLabel;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Label EffectsLabel;
        private System.Windows.Forms.TabControl tabEffects;
        private System.Windows.Forms.TabPage tabImageEffects;
        private System.Windows.Forms.TabPage tabRandomize;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showConsoleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

