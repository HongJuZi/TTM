using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HongJuZi.Net;
using System.Net;

namespace TTM
{
    public partial class TTM : Form
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public TTM() 
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择需要处理的音频文件
        /// </summary>
        /// <param name="sender">事件发送器</param>
        /// <param name="e">事件</param>
        private void SelctFileBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.VoiceDialog.ShowDialog())
            {
                this.VoiceFile.Text = this.VoiceDialog.FileName;
            }
        }

        /// <summary>
        /// 分析音频
        /// </summary>
        /// <param name="sender">事件发送器</param>
        /// <param name="e">事件变量</param>
        private void ParseVoice_Click(object sender, EventArgs e)
        {
            this.LogBox.Text        = "正在识别：" + this.VoiceFile.Text + "....\r\n";
            this.LogBox.Text        += "识别结果：" + GoogleTTS(this.VoiceFile.Text) + "\r\n";
        }

        /// <summary>
        /// GoogleTTS语音识别
        /// </summary>
        /// <param name="filePath">需要处理的文件路径</param>
        /// <returns>识别结果</returns>
        private String GoogleTTS(String filePath)
        {
            String result = string.Empty;
            try {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                byte[] voice = new byte[fs.Length];
                fs.Read(voice, 0, voice.Length);
                fs.Close();
                HttpWebRequest request = null;
                string url = " http://www.google.com/speech-api/v1/recognize?xjerr=1&client=chromium&lang=zh-CN&maxresults=1";
                Uri uri = new Uri(url);
                request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "POST";
                request.ContentType = "audio/x-flac; rate=16000";
                request.ContentLength = voice.Length;
                using (Stream writeStream = request.GetRequestStream()) {
                    writeStream.Write(voice, 0, voice.Length);
                }

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                    using (Stream responseStream = response.GetResponseStream()) {
                        using (StreamReader readStream = new StreamReader(responseStream, Encoding.UTF8)) {
                            result = readStream.ReadToEnd();
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
            }

            return result;
        }
    }
}
