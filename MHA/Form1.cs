using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MHA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void SaveResult_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter MHA_write = new System.IO.StreamWriter("MHA_training", true))
            {
                List<TextBox> textBoxes = new List<TextBox> { Squats_textBox, PushUps_textBox, PullUps_textBox, HangingLeg_textBox, InnerBiceps_textBox, Press_textBox };
                string my_training = DateTime.Now.ToString();
                textBoxes.ForEach(delegate (TextBox textBox) { my_training += "$" + textBox.Text; });
                await MHA_write.WriteLineAsync(my_training);
            }
        }
    }
}
