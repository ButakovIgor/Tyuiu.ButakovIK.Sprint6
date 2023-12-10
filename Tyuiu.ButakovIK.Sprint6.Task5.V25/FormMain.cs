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
using Tyuiu.ButakovIK.Sprint6.Task5.V25.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V25.txt";

        private void buttonDone_BIK_Click(object sender, EventArgs e)
        {
            dataGridViewOutput_BIK.ColumnCount = 2;
            dataGridViewOutput_BIK.Columns[0].Width = 20;
            dataGridViewOutput_BIK.Columns[1].Width = 50;

            this.chartOutput_BIK.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartOutput_BIK.ChartAreas[0].AxisY.Title = "Ось Y";

            chartOutput_BIK.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutput_BIK.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartOutput_BIK.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_BIK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_BIK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5, вариант 25 выполнил студент группы АСОиУб-23-1 Бутаков Игорь Константинович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
