using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLC_ip
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
           
            
            string path = textBoxStrCnt.Text;
            var mediaOptions = new[]
                {
                    ":sout=#rtp{sdp=rtsp://127.0.0.1:554/}",
                    ":sout-keep"
                };
            vlcControl1.SetMedia(new Uri("http://hls1.addictradio.net/addictrock_aac_hls/playlist.m3u8"),
                    mediaOptions);
            vlcControl1.Play();
            

        }

        private void buttonPlay2_Click(object sender, EventArgs e)
        {
            //string path = textBoxStrCnt2.Text;
            //Vlc.DotNet.Core.Medias.LocationMedia media = new Vlc.DotNet.Core.Medias.LocationMedia(path);
            //vlcControl2.Media = media;
            //vlcControl2.Play();
        }

        private void buttonPlay3_Click(object sender, EventArgs e)
        {
            //string path = textBoxStrCnt3.Text;
            //Vlc.DotNet.Core.Medias.LocationMedia media = new Vlc.DotNet.Core.Medias.LocationMedia(path);
            //vlcControl3.Media = media;
            //vlcControl3.Play();
        }

        private void buttonPlay4_Click(object sender, EventArgs e)
        {
            //string path = textBoxStrCnt4.Text;
            //Vlc.DotNet.Core.Medias.LocationMedia media = new Vlc.DotNet.Core.Medias.LocationMedia(path);
            //vlcControl4.Media = media;
            //vlcControl4.Play();
        }

        private void buttonPlay5_Click(object sender, EventArgs e)
        {
            //string path = textBoxStrCnt5.Text;
            //Vlc.DotNet.Core.Medias.LocationMedia media = new Vlc.DotNet.Core.Medias.LocationMedia(path);
            //vlcControl5.Media = media;
            //vlcControl5.Play();
        }

        private void buttonPlay6_Click(object sender, EventArgs e)
        {
            //string path = textBoxStrCnt6.Text;
            //Vlc.DotNet.Core.Medias.LocationMedia media = new Vlc.DotNet.Core.Medias.LocationMedia(path);
            //vlcControl6.Media = media;
            //vlcControl6.Play();
        }
    }
}
