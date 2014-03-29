using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
