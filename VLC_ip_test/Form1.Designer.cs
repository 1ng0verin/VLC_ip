namespace VLC_ip
{
	partial class MainForm
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxStrCnt = new System.Windows.Forms.TextBox();
			this.buttonPlay = new System.Windows.Forms.Button();
			this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
			this.SuspendLayout();
			// 
			// textBoxStrCnt
			// 
			this.textBoxStrCnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxStrCnt.Location = new System.Drawing.Point(6, 423);
			this.textBoxStrCnt.Name = "textBoxStrCnt";
			this.textBoxStrCnt.Size = new System.Drawing.Size(455, 20);
			this.textBoxStrCnt.TabIndex = 0;
			this.textBoxStrCnt.Text = "https://www.youtube.com/watch?v=jgO7bm-78tg";
			// 
			// buttonPlay
			// 
			this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPlay.Location = new System.Drawing.Point(467, 422);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(75, 23);
			this.buttonPlay.TabIndex = 1;
			this.buttonPlay.Text = "PLAY";
			this.buttonPlay.UseVisualStyleBackColor = true;
			this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
			// 
			// vlcControl1
			// 
			this.vlcControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.vlcControl1.BackColor = System.Drawing.Color.Black;
			this.vlcControl1.Location = new System.Drawing.Point(6, 13);
			this.vlcControl1.Name = "vlcControl1";
			this.vlcControl1.Rate = 0F;
			this.vlcControl1.Size = new System.Drawing.Size(536, 403);
			this.vlcControl1.TabIndex = 2;
			this.vlcControl1.Text = "vlcControl1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(554, 449);
			this.Controls.Add(this.vlcControl1);
			this.Controls.Add(this.buttonPlay);
			this.Controls.Add(this.textBoxStrCnt);
			this.Name = "MainForm";
			this.Text = "VLC ip";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxStrCnt;
		private System.Windows.Forms.Button buttonPlay;
		private Vlc.DotNet.Forms.VlcControl vlcControl1;
	}
}

