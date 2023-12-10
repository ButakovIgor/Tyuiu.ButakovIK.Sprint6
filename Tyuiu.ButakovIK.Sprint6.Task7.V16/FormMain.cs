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
using Tyuiu.ButakovIK.Sprint6.Task7.V16.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_BIK.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_BIK.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public int[,] LoadFromFileData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }


        private void buttonOpen_BIK_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BIK.ShowDialog();
            openFilePath = openFileDialogTask_BIK.FileName;

            int[,] arrayValue = new int[rows, columns];

            arrayValue = LoadFromFileData(openFilePath);

            dataGridViewInput_BIK.ColumnCount = columns;
            dataGridViewInput_BIK.RowCount = rows;
            dataGridViewOutput_BIK.ColumnCount = columns;
            dataGridViewOutput_BIK.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_BIK.Columns[i].Width = 25;
                dataGridViewOutput_BIK.Columns[i].Width = 25;
            }



            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_BIK.Rows[r].Cells[c].Value = arrayValue[r, c];
                }
            }
            arrayValue = ds.GetMatrix(openFilePath);
            buttonDone_BIK.Enabled = true;
        }

        private void buttonDone_BIK_Click(object sender, EventArgs e)
        {
            int[,] arrayValue = new int[rows, columns];
            arrayValue = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_BIK.Rows[r].Cells[c].Value = arrayValue[r, c];
                }
            }
            buttonSave_BIK.Enabled = true;
        }

        private void buttonSave_BIK_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_BIK.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_BIK.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_BIK.ShowDialog();

            string path = saveFileDialogTask_BIK.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_BIK.RowCount;
            int columns = dataGridViewOutput_BIK.ColumnCount;
            string str = "";

           for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutput_BIK.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput_BIK.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_BIK.RowCount = 50;
            dataGridViewOutput_BIK.RowCount = 50;

            dataGridViewInput_BIK.ColumnCount = 50;
            dataGridViewOutput_BIK.ColumnCount = 50;



            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_BIK.Columns[i].Width = 25;
                dataGridViewOutput_BIK.Columns[i].Width = 25;
            }
        }

        private void buttonOpen_BIK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BIK.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_BIK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BIK.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_BIK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BIK.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_BIK_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_BIK.ToolTipTitle = "Справка";
        }

        private void buttonInfo_BIK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
