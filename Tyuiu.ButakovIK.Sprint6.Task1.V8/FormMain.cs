using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ButakovIK.Sprint6.Task1.V8.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task1.V8
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

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_BIK.Text = "";
                textBoxResult_BIK.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_BIK.AppendText("|     X    |    f(x)  |" + Environment.NewLine);
                textBoxResult_BIK.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f1}   | ", startValue, valueArray[i]);
                    textBoxResult_BIK.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_BIK.AppendText("+----------+----------+" + Environment.NewLine);   
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_BIK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1, вариант 8 выполнил студент группы АСОиУб-23-1 Бутаков Игорь Константинович","Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
