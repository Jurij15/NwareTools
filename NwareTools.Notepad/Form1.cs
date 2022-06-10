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

namespace NwareTools.Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pasteeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTextBox.Paste();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTextBox.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            string result = openFileDialog.FileName;
            string text = File.ReadAllText(result);
            rTextBox.Text = text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt|Show All Files (*.*)|*.*";
            saveFileDialog.FileName = "Untitled";
            saveFileDialog.Title = "Save As";
            saveFileDialog.ShowDialog();
            TextWriter txt = new StreamWriter(saveFileDialog.FileName);
            txt.Write(rTextBox.Text);
            txt.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTextBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTextBox.Copy();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTextBox.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString();
            rTextBox.Text = datetime;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            rTextBox.Font = fontDialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            rTextBox.ForeColor = colorDialog.Color;
        }
    }
}
