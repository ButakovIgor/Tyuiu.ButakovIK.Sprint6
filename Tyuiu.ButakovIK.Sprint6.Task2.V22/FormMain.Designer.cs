
namespace Tyuiu.ButakovIK.Sprint6.Task2.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_BIK = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_BIK = new System.Windows.Forms.GroupBox();
            this.groupBoxValues_BIK = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_BIK = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_BIK = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_BIK = new System.Windows.Forms.TextBox();
            this.labelStartValue_BIK = new System.Windows.Forms.Label();
            this.labelStopValue_BIK = new System.Windows.Forms.Label();
            this.buttonHelp_BIK = new System.Windows.Forms.Button();
            this.buttonDone_BIK = new System.Windows.Forms.Button();
            this.dataGridViewResult_BIK = new System.Windows.Forms.DataGridView();
            this.chartResult_BIK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ColumnX_BIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFX_BIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxUslovie_BIK.SuspendLayout();
            this.groupBoxResult_BIK.SuspendLayout();
            this.groupBoxValues_BIK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BIK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BIK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_BIK
            // 
            this.groupBoxUslovie_BIK.Controls.Add(this.textBoxUslovie_BIK);
            this.groupBoxUslovie_BIK.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_BIK.Name = "groupBoxUslovie_BIK";
            this.groupBoxUslovie_BIK.Size = new System.Drawing.Size(411, 236);
            this.groupBoxUslovie_BIK.TabIndex = 0;
            this.groupBoxUslovie_BIK.TabStop = false;
            this.groupBoxUslovie_BIK.Text = "Условие";
            // 
            // groupBoxResult_BIK
            // 
            this.groupBoxResult_BIK.Controls.Add(this.chartResult_BIK);
            this.groupBoxResult_BIK.Controls.Add(this.dataGridViewResult_BIK);
            this.groupBoxResult_BIK.Location = new System.Drawing.Point(431, 13);
            this.groupBoxResult_BIK.Name = "groupBoxResult_BIK";
            this.groupBoxResult_BIK.Size = new System.Drawing.Size(504, 316);
            this.groupBoxResult_BIK.TabIndex = 1;
            this.groupBoxResult_BIK.TabStop = false;
            this.groupBoxResult_BIK.Text = "Вывод данных";
            // 
            // groupBoxValues_BIK
            // 
            this.groupBoxValues_BIK.Controls.Add(this.labelStopValue_BIK);
            this.groupBoxValues_BIK.Controls.Add(this.labelStartValue_BIK);
            this.groupBoxValues_BIK.Controls.Add(this.textBoxStopValue_BIK);
            this.groupBoxValues_BIK.Controls.Add(this.textBoxStartValue_BIK);
            this.groupBoxValues_BIK.Location = new System.Drawing.Point(13, 255);
            this.groupBoxValues_BIK.Name = "groupBoxValues_BIK";
            this.groupBoxValues_BIK.Size = new System.Drawing.Size(223, 74);
            this.groupBoxValues_BIK.TabIndex = 2;
            this.groupBoxValues_BIK.TabStop = false;
            this.groupBoxValues_BIK.Text = "Ввод данных";
            // 
            // textBoxUslovie_BIK
            // 
            this.textBoxUslovie_BIK.Location = new System.Drawing.Point(7, 19);
            this.textBoxUslovie_BIK.Multiline = true;
            this.textBoxUslovie_BIK.Name = "textBoxUslovie_BIK";
            this.textBoxUslovie_BIK.ReadOnly = true;
            this.textBoxUslovie_BIK.Size = new System.Drawing.Size(398, 210);
            this.textBoxUslovie_BIK.TabIndex = 0;
            this.textBoxUslovie_BIK.Text = "Протабулировать функцию (2x-3)/(cos(x)+x)+5 на заданном диапазоне.\r\nРезультат выв" +
    "ести в DataGridView и построить график функции.";
            // 
            // textBoxStartValue_BIK
            // 
            this.textBoxStartValue_BIK.Location = new System.Drawing.Point(6, 48);
            this.textBoxStartValue_BIK.Name = "textBoxStartValue_BIK";
            this.textBoxStartValue_BIK.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartValue_BIK.TabIndex = 0;
            // 
            // textBoxStopValue_BIK
            // 
            this.textBoxStopValue_BIK.Location = new System.Drawing.Point(117, 48);
            this.textBoxStopValue_BIK.Name = "textBoxStopValue_BIK";
            this.textBoxStopValue_BIK.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue_BIK.TabIndex = 1;
            // 
            // labelStartValue_BIK
            // 
            this.labelStartValue_BIK.AutoSize = true;
            this.labelStartValue_BIK.Location = new System.Drawing.Point(6, 32);
            this.labelStartValue_BIK.Name = "labelStartValue_BIK";
            this.labelStartValue_BIK.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_BIK.TabIndex = 2;
            this.labelStartValue_BIK.Text = "Старт шага:";
            // 
            // labelStopValue_BIK
            // 
            this.labelStopValue_BIK.AutoSize = true;
            this.labelStopValue_BIK.Location = new System.Drawing.Point(114, 32);
            this.labelStopValue_BIK.Name = "labelStopValue_BIK";
            this.labelStopValue_BIK.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_BIK.TabIndex = 3;
            this.labelStopValue_BIK.Text = "Конец шага:";
            // 
            // buttonHelp_BIK
            // 
            this.buttonHelp_BIK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_BIK.Location = new System.Drawing.Point(243, 256);
            this.buttonHelp_BIK.Name = "buttonHelp_BIK";
            this.buttonHelp_BIK.Size = new System.Drawing.Size(75, 73);
            this.buttonHelp_BIK.TabIndex = 3;
            this.buttonHelp_BIK.Text = "Справка";
            this.buttonHelp_BIK.UseVisualStyleBackColor = false;
            this.buttonHelp_BIK.Click += new System.EventHandler(this.buttonHelp_BIK_Click);
            // 
            // buttonDone_BIK
            // 
            this.buttonDone_BIK.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDone_BIK.Location = new System.Drawing.Point(325, 256);
            this.buttonDone_BIK.Name = "buttonDone_BIK";
            this.buttonDone_BIK.Size = new System.Drawing.Size(99, 73);
            this.buttonDone_BIK.TabIndex = 4;
            this.buttonDone_BIK.Text = "Выполнить";
            this.buttonDone_BIK.UseVisualStyleBackColor = false;
            this.buttonDone_BIK.Click += new System.EventHandler(this.buttonDone_BIK_Click);
            this.buttonDone_BIK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_BIK_MouseDown);
            this.buttonDone_BIK.MouseEnter += new System.EventHandler(this.buttonDone_BIK_MouseEnter);
            this.buttonDone_BIK.MouseLeave += new System.EventHandler(this.buttonDone_BIK_MouseLeave);
            // 
            // dataGridViewResult_BIK
            // 
            this.dataGridViewResult_BIK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_BIK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_BIK,
            this.ColumnFX_BIK});
            this.dataGridViewResult_BIK.Location = new System.Drawing.Point(8, 19);
            this.dataGridViewResult_BIK.Name = "dataGridViewResult_BIK";
            this.dataGridViewResult_BIK.RowHeadersVisible = false;
            this.dataGridViewResult_BIK.Size = new System.Drawing.Size(121, 291);
            this.dataGridViewResult_BIK.TabIndex = 0;
            // 
            // chartResult_BIK
            // 
            chartArea7.Name = "ChartArea1";
            this.chartResult_BIK.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartResult_BIK.Legends.Add(legend7);
            this.chartResult_BIK.Location = new System.Drawing.Point(135, 20);
            this.chartResult_BIK.Name = "chartResult_BIK";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartResult_BIK.Series.Add(series7);
            this.chartResult_BIK.Size = new System.Drawing.Size(363, 290);
            this.chartResult_BIK.TabIndex = 1;
            this.chartResult_BIK.Text = "chart1";
            // 
            // ColumnX_BIK
            // 
            this.ColumnX_BIK.HeaderText = "X";
            this.ColumnX_BIK.Name = "ColumnX_BIK";
            this.ColumnX_BIK.Width = 50;
            // 
            // ColumnFX_BIK
            // 
            this.ColumnFX_BIK.HeaderText = "F(X)";
            this.ColumnFX_BIK.Name = "ColumnFX_BIK";
            this.ColumnFX_BIK.ReadOnly = true;
            this.ColumnFX_BIK.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 341);
            this.Controls.Add(this.buttonDone_BIK);
            this.Controls.Add(this.buttonHelp_BIK);
            this.Controls.Add(this.groupBoxValues_BIK);
            this.Controls.Add(this.groupBoxResult_BIK);
            this.Controls.Add(this.groupBoxUslovie_BIK);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 22 | Бутаков И.К.";
            this.groupBoxUslovie_BIK.ResumeLayout(false);
            this.groupBoxUslovie_BIK.PerformLayout();
            this.groupBoxResult_BIK.ResumeLayout(false);
            this.groupBoxValues_BIK.ResumeLayout(false);
            this.groupBoxValues_BIK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BIK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BIK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_BIK;
        private System.Windows.Forms.TextBox textBoxUslovie_BIK;
        private System.Windows.Forms.GroupBox groupBoxResult_BIK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_BIK;
        private System.Windows.Forms.DataGridView dataGridViewResult_BIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_BIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFX_BIK;
        private System.Windows.Forms.GroupBox groupBoxValues_BIK;
        private System.Windows.Forms.Label labelStopValue_BIK;
        private System.Windows.Forms.Label labelStartValue_BIK;
        private System.Windows.Forms.TextBox textBoxStopValue_BIK;
        private System.Windows.Forms.TextBox textBoxStartValue_BIK;
        private System.Windows.Forms.Button buttonHelp_BIK;
        private System.Windows.Forms.Button buttonDone_BIK;
    }
}

