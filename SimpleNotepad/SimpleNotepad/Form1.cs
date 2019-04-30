using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt file |*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rtbNote.LoadFile(ofd.FileName);
            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK )
            {
                rtbNote.SelectionColor = cd.Color;
            }
        }

        private void BackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                rtbNote.SelectionBackColor = cd.Color;
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                rtbNote.SelectionFont = fd.Font;
            }
        }

        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt file |*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rtbNote.SaveFile(sfd.FileName);
            }

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNote.ResetText();
        }
    }
}
