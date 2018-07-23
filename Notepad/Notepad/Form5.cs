using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form5 : Form
    {
        Form1 f1;
        public Form5(Form1 ff)
        {
            f1 = ff;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
           if(f1.textBox1.Text.Contains(this.textBox1.Text))
            {
                MessageBox.Show("Result find");
            }
           else
            {
                MessageBox.Show("Result not found");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
