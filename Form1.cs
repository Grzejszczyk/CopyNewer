using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyNewer.WinForms
{
    public partial class Form1 : Form
    {
        FileCopier fc;
        public Form1()
        {
            InitializeComponent();
            fc = new FileCopier();
        }

        private void button_Click_SourceSelect(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            fc.SourcePath = fbd.SelectedPath;
            textBoxSource.Text = fbd.SelectedPath;
        }

        private void button_Click_DestinationSelect(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            fc.DestinationPath = fbd.SelectedPath;
            textBoxDestination.Text = fbd.SelectedPath;
        }

        private void button_Click_Copy(object sender, EventArgs e)
        {
            label2.Text = fc.CopyFiles().ToString();
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            fc.SourcePath = textBoxSource.Text;
        }

        private void textBoxDestination_TextChanged(object sender, EventArgs e)
        {
            fc.DestinationPath = textBoxDestination.Text;
        }
    }
}
