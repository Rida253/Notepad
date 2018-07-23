using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3(Form1 ff)
        {
            f1 = ff;
            InitializeComponent();
        }

       

       

      

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Notepad";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string st = f1.textBox1.Text.Replace(textBox1.Text, textBox2.Text);

            f1.textBox1.Text = st;
            this.textBox2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
