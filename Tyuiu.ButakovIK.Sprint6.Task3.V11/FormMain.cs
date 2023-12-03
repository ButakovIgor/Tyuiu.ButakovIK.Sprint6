using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ButakovIK.Sprint6.Task3.V11.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]
                    {{27,-15,14,2,27},
                    {-8,14,-10,33,0},
                    {1,7,-11,-11,23},
                    {-13,-20,15,-16,34},
                    { -3,1,-1,5,1}};



        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_BIK.ColumnCount = columns;
            dataGridViewMatrix_BIK.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_BIK.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_BIK.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonDone_BIK_Click(object sender, EventArgs e)
        {
            var sorted_matrix = ds.Calculate(mtrx);

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_BIK.ColumnCount = columns;
            dataGridViewResult_BIK.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_BIK.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_BIK.Rows[i].Cells[j].Value = Convert.ToString(sorted_matrix[i, j]);
                }
            }
        }

        private void groupBoxResult_BIK_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_BIK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, вариант 11 выполнил студент группы АСОиУб-23-1 Бутаков Игорь Константинович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
