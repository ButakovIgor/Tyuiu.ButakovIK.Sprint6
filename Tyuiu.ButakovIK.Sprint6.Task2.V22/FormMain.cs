using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ButakovIK.Sprint6.Task2.V22.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task2.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_BIK_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_BIK.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_BIK.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartResult_BIK.Titles.Add("График функции");

                this.chartResult_BIK.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult_BIK.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_BIK.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartResult_BIK.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BIK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2, вариант 22 выполнил студент группы АСОиУб-23-1 Бутаков Игорь Константинович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_BIK_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BIK.BackColor = Color.Red;
        }

        private void buttonDone_BIK_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BIK.BackColor = Color.Chartreuse;
        }

        private void buttonDone_BIK_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BIK.BackColor = Color.Blue;
        }
    }
}
