using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_to_img
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_GO_Click(object sender, EventArgs e)
        {
            TextToImg t = new(txt_TextToImg.Text,1000);


            SaveFileDialog ofd = new SaveFileDialog() { Filter = "BMP (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg" };
            DialogResult res = ofd.ShowDialog();
            t.CreateImg(colorDialog1.Color);

            if (res == DialogResult.OK)
                t.SaveFile(ofd.FileName);
        }

        private void brn_ChooseColor_Click(object sender, EventArgs e)
        {
            TextToImg t = new(txt_TextToImg.Text, pctr_Result.Height);
            var cres = colorDialog1.ShowDialog();
            
            if (cres == DialogResult.OK)
                t.CreateImg(colorDialog1.Color);
            txt_OnesColor.BackColor = colorDialog1.Color;
            pctr_Result.Image = t.bmp;
        }

        private void txt_TextToImg_TextChanged(object sender, EventArgs e)
        {
            TextToImg t = new(txt_TextToImg.Text, pctr_Result.Height);
            t.CreateImg(colorDialog1.Color);
            pctr_Result.Image = t.bmp;
        }

        private void btn_Decode_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "BMP (*.bmp)|*.bmp" };
            DialogResult res = open.ShowDialog();
            if (res == DialogResult.OK)
            {
                txt_TextToImg.Text = TextToImg.Decode(open.FileName);
                txt_TextToImg_TextChanged(sender, e);
            }
        }
    }
}
