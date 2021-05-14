using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace MyVideoPlayer
{
    public partial class Form1 : Form
    {
        //for your info, this only works on x86 projects
        //due to the library itself

        Video video;
        static string userName = Environment.UserName;
        string path = $@"C:\Users\{userName}\Videos\BadApple.wmv";
        string startingPath = $@"C:\Users\{userName}\Desktop\";
        Size formSize;
        Size pnlSize;
        bool isSet = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(panelVideo.Width, panelVideo.Height);
            video = new Video(path);
            video.Owner = panelVideo;
            panelVideo.Size = pnlSize;
            video.Audio.Volume = -2000;
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if(isSet == true)
            {
                video.Play();
            }
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            video.Audio.Volume = trackVolume.Value;
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = startingPath;
                openFileDialog.Filter = "wmv files (*.wmv)|*.wmv";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.DereferenceLinks = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                }
            }
            isSet = true;
            video.Open(path);
            video.Owner = panelVideo;
            panelVideo.Size = pnlSize;
            video.Audio.Volume = -2000;
            video.Play();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            video.Pause();
        }
    }
}
