namespace MyVideoPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(1112, 743);
            this.trackVolume.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.trackVolume.Maximum = 0;
            this.trackVolume.Minimum = -10000;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(180, 45);
            this.trackVolume.TabIndex = 2;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackVolume.Value = -2000;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // buttonPlay
            // 
            this.buttonPlay.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonPlay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(15, 747);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Padding = new System.Windows.Forms.Padding(0, 5, 0, 4);
            this.buttonPlay.Size = new System.Drawing.Size(32, 32);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // panelVideo
            // 
            this.panelVideo.Location = new System.Drawing.Point(12, 10);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(1280, 720);
            this.panelVideo.TabIndex = 1;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonSelectFile.Location = new System.Drawing.Point(125, 747);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(100, 32);
            this.buttonSelectFile.TabIndex = 5;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.Location = new System.Drawing.Point(70, 747);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(32, 32);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(1063, 747);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 32);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 737);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1280, 1);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 791);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oxi Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

