

using Concentus.Oggfile;
using Concentus.Structs;
using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleConverterOggToWAV
{
    public partial class Form1 : Form
    {
        private string fileOgg = "a.ogg";
        private string fileWav = "a.wav";
        private string filePath = "";//$@"C:\Users\blabla\foo\bar\";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string localFileName = "a.ogg";
            //string localFileName2 = localFileName.Replace(".ogg", ".wav");
            //var vorbisStream = new NAudio.Vorbis.VorbisWaveReader(localFileName);
            //NAudio.Wave.WaveFileWriter.CreateWaveFile(localFileName2, vorbisStream);
            try
            {
                using (FileStream fileIn = new FileStream($"{this.fileOgg}", FileMode.Open))
                using (MemoryStream pcmStream = new MemoryStream())
                {
                    OpusDecoder decoder = OpusDecoder.Create(48000, 1);
                    OpusOggReadStream oggIn = new OpusOggReadStream(decoder, fileIn);
                    while (oggIn.HasNextPacket)
                    {
                        short[] packet = oggIn.DecodeNextPacket();
                        if (packet != null)
                        {
                            for (int i = 0; i < packet.Length; i++)
                            {
                                var bytes = BitConverter.GetBytes(packet[i]);
                                pcmStream.Write(bytes, 0, bytes.Length);
                            }
                        }
                    }
                    pcmStream.Position = 0;
                    var wavStream = new RawSourceWaveStream(pcmStream, new WaveFormat(48000, 1));
                    var sampleProvider = wavStream.ToSampleProvider();
                    WaveFileWriter.CreateWaveFile16($"{this.fileWav}", sampleProvider);
                }
                MessageBox.Show("success!");
                this.wavlab.Text = this.fileWav;
            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "OGG Files|*.ogg";//|MP3 Files|*.mp3|WAV files|*.wav";
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.fileOgg = ofd.FileName;
                this.fileWav = this.fileOgg.Replace(".ogg", ".wav");
                this.ogglab.Text = this.fileOgg;
                this.wavlab.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                EncoderOGG o = new EncoderOGG(0);
                o.InputFile = "C:\\Users\\DatTT\\Desktop\\t.wav";
                o.OutputFile = "C:\\Users\\DatTT\\Desktop\\t.ogg";
                o.OGG_UseQualityMode = true;
                o.OGG_Quality = 4;
                System.Console.WriteLine(BaseEncoder.EncodeFile(o, null, true, false, true));

                int stream = Bass.BASS_StreamCreateFile("C:\\Users\\DatTT\\Desktop\\1.wav", 0, 0, BASSFlag.BASS_STREAM_DECODE);
                System.Console.WriteLine(stream);
                EncoderOGG o = new EncoderOGG(stream);
                o.InputFile = null;
                o.OutputFile = null;
                o.Start(new ENCODEPROC(getAudioBytes), IntPtr.Zero, false);
                System.Console.WriteLine(Bass.BASS_ErrorGetCode());
                Utils.DecodeAllData(stream, true);
                o.Stop();
                Bass.BASS_StreamFree(stream);
                */

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
