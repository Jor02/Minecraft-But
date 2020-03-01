namespace Minecraft_But
{
    partial class ProgressBarForm
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
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.ExportProgress = new System.Windows.Forms.ProgressBar();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CurrentLabel.Location = new System.Drawing.Point(13, 57);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(460, 33);
            this.CurrentLabel.TabIndex = 4;
            this.CurrentLabel.Text = "Loading";
            this.CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExportProgress
            // 
            this.ExportProgress.Location = new System.Drawing.Point(13, 12);
            this.ExportProgress.MarqueeAnimationSpeed = 1000;
            this.ExportProgress.Name = "ExportProgress";
            this.ExportProgress.Size = new System.Drawing.Size(460, 42);
            this.ExportProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ExportProgress.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(172, 93);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(142, 43);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minecraft_But.Properties.Resources.darkstone;
            this.ClientSize = new System.Drawing.Size(486, 148);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CurrentLabel);
            this.Controls.Add(this.ExportProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressBarForm";
            this.Text = "ProgressBarForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.ProgressBar ExportProgress;
        private System.Windows.Forms.Button CancelButton;
    }
}