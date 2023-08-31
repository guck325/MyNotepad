using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            textBox1.Text = File.ReadAllText(openFileDialog1.FileName);

        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제작자: guck", "메모장 정보", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
