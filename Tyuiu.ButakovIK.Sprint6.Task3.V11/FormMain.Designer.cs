
namespace Tyuiu.ButakovIK.Sprint6.Task3.V11
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxUslovie_BIK = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_BIK = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_BIK = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_BIK = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_BIK = new System.Windows.Forms.DataGridView();
            this.buttonHelp_BIK = new System.Windows.Forms.Button();
            this.buttonDone_BIK = new System.Windows.Forms.Button();
            this.groupBoxUslovie_BIK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BIK)).BeginInit();
            this.groupBoxResult_BIK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BIK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_BIK
            // 
            this.groupBoxUslovie_BIK.Controls.Add(this.textBoxUslovie_BIK);
            this.groupBoxUslovie_BIK.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_BIK.Name = "groupBoxUslovie_BIK";
            this.groupBoxUslovie_BIK.Size = new System.Drawing.Size(295, 176);
            this.groupBoxUslovie_BIK.TabIndex = 0;
            this.groupBoxUslovie_BIK.TabStop = false;
            this.groupBoxUslovie_BIK.Text = "Условие";
            // 
            // textBoxUslovie_BIK
            // 
            this.textBoxUslovie_BIK.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxUslovie_BIK.Location = new System.Drawing.Point(7, 20);
            this.textBoxUslovie_BIK.Multiline = true;
            this.textBoxUslovie_BIK.Name = "textBoxUslovie_BIK";
            this.textBoxUslovie_BIK.ReadOnly = true;
            this.textBoxUslovie_BIK.Size = new System.Drawing.Size(282, 149);
            this.textBoxUslovie_BIK.TabIndex = 0;
            this.textBoxUslovie_BIK.Text = "Дана матрица 5 на 5\r\n 27 -15  14   2  27\r\n -8  14 -10  33   0\r\n  1   7 -11 -11  2" +
    "3\r\n-13 -20  15 -16  34\r\n -3   1  -1   5   1\r\nВыполнить сортировку по возрастанию" +
    " в первом столбце.";
            // 
            // dataGridViewMatrix_BIK
            // 
            this.dataGridViewMatrix_BIK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_BIK.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_BIK.Location = new System.Drawing.Point(314, 33);
            this.dataGridViewMatrix_BIK.Name = "dataGridViewMatrix_BIK";
            this.dataGridViewMatrix_BIK.RowHeadersVisible = false;
            this.dataGridViewMatrix_BIK.Size = new System.Drawing.Size(150, 150);
            this.dataGridViewMatrix_BIK.TabIndex = 1;
            // 
            // groupBoxResult_BIK
            // 
            this.groupBoxResult_BIK.Controls.Add(this.dataGridViewResult_BIK);
            this.groupBoxResult_BIK.Location = new System.Drawing.Point(470, 13);
            this.groupBoxResult_BIK.Name = "groupBoxResult_BIK";
            this.groupBoxResult_BIK.Size = new System.Drawing.Size(162, 176);
            this.groupBoxResult_BIK.TabIndex = 2;
            this.groupBoxResult_BIK.TabStop = false;
            this.groupBoxResult_BIK.Text = "Вывод данных";
            this.groupBoxResult_BIK.Enter += new System.EventHandler(this.groupBoxResult_BIK_Enter);
            // 
            // dataGridViewResult_BIK
            // 
            this.dataGridViewResult_BIK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_BIK.ColumnHeadersVisible = false;
            this.dataGridViewResult_BIK.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult_BIK.Name = "dataGridViewResult_BIK";
            this.dataGridViewResult_BIK.RowHeadersVisible = false;
            this.dataGridViewResult_BIK.Size = new System.Drawing.Size(150, 150);
            this.dataGridViewResult_BIK.TabIndex = 0;
            // 
            // buttonHelp_BIK
            // 
            this.buttonHelp_BIK.Location = new System.Drawing.Point(638, 153);
            this.buttonHelp_BIK.Name = "buttonHelp_BIK";
            this.buttonHelp_BIK.Size = new System.Drawing.Size(31, 30);
            this.buttonHelp_BIK.TabIndex = 3;
            this.buttonHelp_BIK.Text = "?";
            this.buttonHelp_BIK.UseVisualStyleBackColor = true;
            this.buttonHelp_BIK.Click += new System.EventHandler(this.buttonHelp_BIK_Click);
            // 
            // buttonDone_BIK
            // 
            this.buttonDone_BIK.Location = new System.Drawing.Point(675, 154);
            this.buttonDone_BIK.Name = "buttonDone_BIK";
            this.buttonDone_BIK.Size = new System.Drawing.Size(71, 29);
            this.buttonDone_BIK.TabIndex = 4;
            this.buttonDone_BIK.Text = "Выполнить";
            this.buttonDone_BIK.UseVisualStyleBackColor = true;
            this.buttonDone_BIK.Click += new System.EventHandler(this.buttonDone_BIK_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 199);
            this.Controls.Add(this.buttonDone_BIK);
            this.Controls.Add(this.buttonHelp_BIK);
            this.Controls.Add(this.groupBoxResult_BIK);
            this.Controls.Add(this.dataGridViewMatrix_BIK);
            this.Controls.Add(this.groupBoxUslovie_BIK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 11 | Бутаков И. К.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_BIK.ResumeLayout(false);
            this.groupBoxUslovie_BIK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BIK)).EndInit();
            this.groupBoxResult_BIK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BIK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_BIK;
        private System.Windows.Forms.TextBox textBoxUslovie_BIK;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_BIK;
        private System.Windows.Forms.GroupBox groupBoxResult_BIK;
        private System.Windows.Forms.DataGridView dataGridViewResult_BIK;
        private System.Windows.Forms.Button buttonHelp_BIK;
        private System.Windows.Forms.Button buttonDone_BIK;
    }
}

