using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ButakovIK.Sprint6.Task0.V26.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task0.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_BIK_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_BIK.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_BIK.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_BIK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonInfo_BIK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, вариант 26 выполнил студент группы АСОиУб-23-1 Бутаков Игорь Константинович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
