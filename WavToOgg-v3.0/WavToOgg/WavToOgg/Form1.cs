using OggVorbisEncoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavToOggLibrary;

namespace WavToOggTest
{
    public partial class Form1 : Form
    {
        private string fileOgg = "a.ogg";
        private string fileWav = "a.wav";
        enum PCMSample : int
        {
            EightBit = 1,
            SixteenBit = 2
        }

        private static int WriteBufferSize = 512;
        private static readonly int[] SampleRates = { 8000, 11025, 16000, 22050, 32000, 44100 };
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < SampleRates.Length; i++) rateCb.Items.Add(SampleRates[i]);
            rateCb.SelectedIndex = 2;// SampleRates.Length - 1;
            channelTxt.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "WAV files|*.wav|MP3 Files|*.mp3";
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.fileWav = ofd.FileName;
                this.fileOgg = this.fileWav.Replace(".wav", ".ogg");
                this.ogglab.Text = "";
                this.wavlab.Text = this.fileWav;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WavToOgg.ConvertWavToOgg(this.fileWav).ToString());
            this.ogglab.Text = this.fileOgg;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ogglab.Text = "";
        }

        private void channelTxt_ModifiedChanged(object sender, EventArgs e)
        {
            this.ogglab.Text = "";
        }

        private void channelTxt_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyValue > 48 && e.KeyValue < 54)
            {
                this.ogglab.Text = "";
            }
            else
            {
                channelTxt.Text = "1";
            }
        }
    }

}
