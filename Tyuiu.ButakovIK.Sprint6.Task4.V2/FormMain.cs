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
using Tyuiu.ButakovIK.Sprint6.Task4.V2.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task4.V2
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

                

                this.chartFunction_BIK.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BIK.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput_BIK.Text = "";

                chartFunction_BIK.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_BIK.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxOutput_BIK.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_BIK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4, вариант 2 выполнил студент группы АСОиУб-23-1 Бутаков Игорь Константинович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_BIK_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V2.txt";
                File.WriteAllText(path, textBoxOutput_BIK.Text);

                DialogResult dialogResult = MessageBox.Show("Файл: " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
