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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "RIDA";
            this.textBox1.ScrollBars = ScrollBars.Both;
            // this.undoToolStripMenuItem.ShortcutKeys= Keys(sho)
            // this.wordWrapeToolStripMenuItem.Checked = true;
            this.textBox1.WordWrap = true;
            openFileDialog1.Filter = "all text(*.txt|*.txt";


            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            //this.printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            this.deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            this.findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            this.replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.timeDateToolStripMenuItem.ShortcutKeys = Keys.F5;
            this.withColorToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            this.regularToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.R;
        }

        private void wordWrapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapeToolStripMenuItem.Checked == true)
            {
                wordWrapeToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = false;
            }
            else
            {
                wordWrapeToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

                this.textBox1.Font = this.fontDialog1.Font;
                this.textBox1.ForeColor = this.fontDialog1.Color;
            }
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = false;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

                this.textBox1.Font = this.fontDialog1.Font;
                this.textBox1.ForeColor = Color.Black;
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string od = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(od);

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
            DialogResult dr = this.saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string sd = saveFileDialog1.FileName;
                sd += ".txt";
                File.WriteAllText(sd, this.textBox1.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                Application.Exit();
            }
            else
            { 
                Form2 f2 = new Form2(this);
                 f2.ShowDialog();
            }
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textBox1.Text=="")
            {
                textBox1.Text = " ";
            }
            else
            {
                
                saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
                DialogResult dr = this.saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string sd = saveFileDialog1.FileName;
                    sd += ".txt";
                    File.WriteAllText(sd, this.textBox1.Text);
                    textBox1.Text = "";
                }
                }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this);
            f5.ShowDialog();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }
    }
}
