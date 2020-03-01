namespace Minecraft_But
{
    partial class Export
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
            this.ExportButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UnicodeBox = new System.Windows.Forms.CheckBox();
            this.ExportLabel = new System.Windows.Forms.Label();
            this.BlocksBox = new System.Windows.Forms.CheckBox();
            this.ItemsBox = new System.Windows.Forms.CheckBox();
            this.GUIBox = new System.Windows.Forms.CheckBox();
            this.ColormapBox = new System.Windows.Forms.CheckBox();
            this.EffectsBox = new System.Windows.Forms.CheckBox();
            this.EntityBox = new System.Windows.Forms.CheckBox();
            this.EnviormentBox = new System.Windows.Forms.CheckBox();
            this.MapBox = new System.Windows.Forms.CheckBox();
            this.ArmorBox = new System.Windows.Forms.CheckBox();
            this.PotionBox = new System.Windows.Forms.CheckBox();
            this.PaintingBox = new System.Windows.Forms.CheckBox();
            this.ParticleBox = new System.Windows.Forms.CheckBox();
            this.MiscBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExportButton.BackColor = System.Drawing.Color.Silver;
            this.ExportButton.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.ExportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExportButton.FlatAppearance.BorderSize = 2;
            this.ExportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Location = new System.Drawing.Point(146, 207);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(137, 42);
            this.ExportButton.TabIndex = 0;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            // 
            // UnicodeBox
            // 
            this.UnicodeBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UnicodeBox.BackColor = System.Drawing.Color.White;
            this.UnicodeBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.UnicodeBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UnicodeBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.UnicodeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnicodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnicodeBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UnicodeBox.Location = new System.Drawing.Point(15, 115);
            this.UnicodeBox.Name = "UnicodeBox";
            this.UnicodeBox.Size = new System.Drawing.Size(95, 36);
            this.UnicodeBox.TabIndex = 1;
            this.UnicodeBox.Text = "Fonts";
            this.UnicodeBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UnicodeBox.UseVisualStyleBackColor = false;
            // 
            // ExportLabel
            // 
            this.ExportLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportLabel.Location = new System.Drawing.Point(12, 9);
            this.ExportLabel.Name = "ExportLabel";
            this.ExportLabel.Size = new System.Drawing.Size(382, 19);
            this.ExportLabel.TabIndex = 2;
            this.ExportLabel.Text = "Export Settings:";
            // 
            // BlocksBox
            // 
            this.BlocksBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.BlocksBox.BackColor = System.Drawing.Color.White;
            this.BlocksBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.BlocksBox.Checked = true;
            this.BlocksBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlocksBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BlocksBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.BlocksBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlocksBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlocksBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BlocksBox.Location = new System.Drawing.Point(15, 73);
            this.BlocksBox.Name = "BlocksBox";
            this.BlocksBox.Size = new System.Drawing.Size(95, 36);
            this.BlocksBox.TabIndex = 1;
            this.BlocksBox.Text = "Blocks";
            this.BlocksBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BlocksBox.UseVisualStyleBackColor = false;
            // 
            // ItemsBox
            // 
            this.ItemsBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ItemsBox.BackColor = System.Drawing.Color.White;
            this.ItemsBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.ItemsBox.Checked = true;
            this.ItemsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ItemsBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ItemsBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.ItemsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsBox.Location = new System.Drawing.Point(15, 31);
            this.ItemsBox.Name = "ItemsBox";
            this.ItemsBox.Size = new System.Drawing.Size(95, 36);
            this.ItemsBox.TabIndex = 3;
            this.ItemsBox.Text = "Items";
            this.ItemsBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemsBox.UseVisualStyleBackColor = false;
            // 
            // GUIBox
            // 
            this.GUIBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.GUIBox.BackColor = System.Drawing.Color.White;
            this.GUIBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.GUIBox.Checked = true;
            this.GUIBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GUIBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GUIBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.GUIBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GUIBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUIBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUIBox.Location = new System.Drawing.Point(15, 157);
            this.GUIBox.Name = "GUIBox";
            this.GUIBox.Size = new System.Drawing.Size(95, 36);
            this.GUIBox.TabIndex = 4;
            this.GUIBox.Text = "GUI";
            this.GUIBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GUIBox.UseVisualStyleBackColor = false;
            // 
            // ColormapBox
            // 
            this.ColormapBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColormapBox.BackColor = System.Drawing.Color.White;
            this.ColormapBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.ColormapBox.Checked = true;
            this.ColormapBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ColormapBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ColormapBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.ColormapBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColormapBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColormapBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ColormapBox.Location = new System.Drawing.Point(116, 31);
            this.ColormapBox.Name = "ColormapBox";
            this.ColormapBox.Size = new System.Drawing.Size(95, 36);
            this.ColormapBox.TabIndex = 5;
            this.ColormapBox.Text = "Colormap";
            this.ColormapBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColormapBox.UseVisualStyleBackColor = false;
            // 
            // EffectsBox
            // 
            this.EffectsBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.EffectsBox.BackColor = System.Drawing.Color.White;
            this.EffectsBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.EffectsBox.Checked = true;
            this.EffectsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EffectsBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EffectsBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.EffectsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EffectsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectsBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EffectsBox.Location = new System.Drawing.Point(116, 73);
            this.EffectsBox.Name = "EffectsBox";
            this.EffectsBox.Size = new System.Drawing.Size(95, 36);
            this.EffectsBox.TabIndex = 6;
            this.EffectsBox.Text = "Effects";
            this.EffectsBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EffectsBox.UseVisualStyleBackColor = false;
            // 
            // EntityBox
            // 
            this.EntityBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.EntityBox.BackColor = System.Drawing.Color.White;
            this.EntityBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.EntityBox.Checked = true;
            this.EntityBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EntityBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EntityBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.EntityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntityBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EntityBox.Location = new System.Drawing.Point(116, 115);
            this.EntityBox.Name = "EntityBox";
            this.EntityBox.Size = new System.Drawing.Size(95, 36);
            this.EntityBox.TabIndex = 9;
            this.EntityBox.Text = "Entities";
            this.EntityBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EntityBox.UseVisualStyleBackColor = false;
            // 
            // EnviormentBox
            // 
            this.EnviormentBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.EnviormentBox.BackColor = System.Drawing.Color.White;
            this.EnviormentBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.EnviormentBox.Checked = true;
            this.EnviormentBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnviormentBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EnviormentBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.EnviormentBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnviormentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviormentBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnviormentBox.Location = new System.Drawing.Point(116, 157);
            this.EnviormentBox.Name = "EnviormentBox";
            this.EnviormentBox.Size = new System.Drawing.Size(95, 36);
            this.EnviormentBox.TabIndex = 8;
            this.EnviormentBox.Text = "Environment";
            this.EnviormentBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnviormentBox.UseVisualStyleBackColor = false;
            // 
            // MapBox
            // 
            this.MapBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.MapBox.BackColor = System.Drawing.Color.White;
            this.MapBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.MapBox.Checked = true;
            this.MapBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MapBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MapBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.MapBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MapBox.Location = new System.Drawing.Point(217, 31);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(95, 36);
            this.MapBox.TabIndex = 7;
            this.MapBox.Text = "Maps";
            this.MapBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MapBox.UseVisualStyleBackColor = false;
            // 
            // ArmorBox
            // 
            this.ArmorBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ArmorBox.BackColor = System.Drawing.Color.White;
            this.ArmorBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.ArmorBox.Checked = true;
            this.ArmorBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ArmorBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ArmorBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.ArmorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArmorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ArmorBox.Location = new System.Drawing.Point(217, 115);
            this.ArmorBox.Name = "ArmorBox";
            this.ArmorBox.Size = new System.Drawing.Size(95, 36);
            this.ArmorBox.TabIndex = 12;
            this.ArmorBox.Text = "Armor";
            this.ArmorBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ArmorBox.UseVisualStyleBackColor = false;
            // 
            // PotionBox
            // 
            this.PotionBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PotionBox.BackColor = System.Drawing.Color.White;
            this.PotionBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.PotionBox.Checked = true;
            this.PotionBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PotionBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PotionBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.PotionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PotionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotionBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PotionBox.Location = new System.Drawing.Point(217, 73);
            this.PotionBox.Name = "PotionBox";
            this.PotionBox.Size = new System.Drawing.Size(95, 36);
            this.PotionBox.TabIndex = 11;
            this.PotionBox.Text = "Potion\r\nicons";
            this.PotionBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PotionBox.UseVisualStyleBackColor = false;
            // 
            // PaintingBox
            // 
            this.PaintingBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PaintingBox.BackColor = System.Drawing.Color.White;
            this.PaintingBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.PaintingBox.Checked = true;
            this.PaintingBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PaintingBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PaintingBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.PaintingBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaintingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaintingBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PaintingBox.Location = new System.Drawing.Point(217, 157);
            this.PaintingBox.Name = "PaintingBox";
            this.PaintingBox.Size = new System.Drawing.Size(95, 36);
            this.PaintingBox.TabIndex = 10;
            this.PaintingBox.Text = "Paintings";
            this.PaintingBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PaintingBox.UseVisualStyleBackColor = false;
            // 
            // ParticleBox
            // 
            this.ParticleBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ParticleBox.BackColor = System.Drawing.Color.White;
            this.ParticleBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.ParticleBox.Checked = true;
            this.ParticleBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ParticleBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ParticleBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.ParticleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParticleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticleBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParticleBox.Location = new System.Drawing.Point(318, 31);
            this.ParticleBox.Name = "ParticleBox";
            this.ParticleBox.Size = new System.Drawing.Size(95, 36);
            this.ParticleBox.TabIndex = 14;
            this.ParticleBox.Text = "Particles";
            this.ParticleBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ParticleBox.UseVisualStyleBackColor = false;
            // 
            // MiscBox
            // 
            this.MiscBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.MiscBox.BackColor = System.Drawing.Color.White;
            this.MiscBox.BackgroundImage = global::Minecraft_But.Properties.Resources.stoneAlpha;
            this.MiscBox.Checked = true;
            this.MiscBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MiscBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MiscBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.MiscBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiscBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiscBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MiscBox.Location = new System.Drawing.Point(318, 73);
            this.MiscBox.Name = "MiscBox";
            this.MiscBox.Size = new System.Drawing.Size(95, 36);
            this.MiscBox.TabIndex = 13;
            this.MiscBox.Text = "Misc";
            this.MiscBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MiscBox.UseVisualStyleBackColor = false;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minecraft_But.Properties.Resources.bedrock;
            this.ClientSize = new System.Drawing.Size(429, 264);
            this.Controls.Add(this.ParticleBox);
            this.Controls.Add(this.MiscBox);
            this.Controls.Add(this.ArmorBox);
            this.Controls.Add(this.PotionBox);
            this.Controls.Add(this.PaintingBox);
            this.Controls.Add(this.EntityBox);
            this.Controls.Add(this.EnviormentBox);
            this.Controls.Add(this.MapBox);
            this.Controls.Add(this.EffectsBox);
            this.Controls.Add(this.ColormapBox);
            this.Controls.Add(this.GUIBox);
            this.Controls.Add(this.ItemsBox);
            this.Controls.Add(this.ExportLabel);
            this.Controls.Add(this.BlocksBox);
            this.Controls.Add(this.UnicodeBox);
            this.Controls.Add(this.ExportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Minecraft but... its the export screen";
            this.Load += new System.EventHandler(this.Export_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox UnicodeBox;
        private System.Windows.Forms.Label ExportLabel;
        private System.Windows.Forms.CheckBox BlocksBox;
        private System.Windows.Forms.CheckBox ItemsBox;
        private System.Windows.Forms.CheckBox GUIBox;
        private System.Windows.Forms.CheckBox ColormapBox;
        private System.Windows.Forms.CheckBox EffectsBox;
        private System.Windows.Forms.CheckBox EntityBox;
        private System.Windows.Forms.CheckBox EnviormentBox;
        private System.Windows.Forms.CheckBox MapBox;
        private System.Windows.Forms.CheckBox ArmorBox;
        private System.Windows.Forms.CheckBox PotionBox;
        private System.Windows.Forms.CheckBox PaintingBox;
        private System.Windows.Forms.CheckBox ParticleBox;
        private System.Windows.Forms.CheckBox MiscBox;
    }
}