using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ButakovIK.Sprint6.Task6.V28.Lib;
using System.IO;

namespace Tyuiu.ButakovIK.Sprint6.Task6.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_BIK_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BIK.ShowDialog();
            openFilePath = openFileDialogTask_BIK.FileName;
            textBoxIn_BIK.Text = File.ReadAllText(openFilePath);
            groupBoxInput_BIK.Text = groupBoxInput_BIK.Text + " " + openFileDialogTask_BIK.FileName; ;
            buttonDone_BIK.Enabled = true;
        }

        private void buttonDone_BIK_Click(object sender, EventArgs e)
        {
           textBoxOut_BIK.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_BIK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
