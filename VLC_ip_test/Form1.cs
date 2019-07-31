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
			// Сразу включаем воспроизведение
			string path = textBoxStrCnt.Text;
			Vlc.DotNet.Core.Medias.LocationMedia media = new Vlc.DotNet.Core.Medias.LocationMedia(path);
			vlcControl1.Media = media;
			vlcControl1.Play();
		}
	}
}
