
namespace Tyuiu.ButakovIK.Sprint6.Task5.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_BIK = new System.Windows.Forms.Panel();
            this.panelLeft_BIK = new System.Windows.Forms.Panel();
            this.splitterLeftFill_BIK = new System.Windows.Forms.Splitter();
            this.panelFill_BIK = new System.Windows.Forms.Panel();
            this.groupBoxUslovie_BIK = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_BIK = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_BIK = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_BIK = new System.Windows.Forms.DataGridView();
            this.chartOutput_BIK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_BIK = new System.Windows.Forms.Button();
            this.buttonOpen_BIK = new System.Windows.Forms.Button();
            this.buttonInfo_BIK = new System.Windows.Forms.Button();
            this.panelTop_BIK.SuspendLayout();
            this.panelLeft_BIK.SuspendLayout();
            this.panelFill_BIK.SuspendLayout();
            this.groupBoxUslovie_BIK.SuspendLayout();
            this.groupBoxOutput_BIK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_BIK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput_BIK)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_BIK
            // 
            this.panelTop_BIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop_BIK.Controls.Add(this.buttonInfo_BIK);
            this.panelTop_BIK.Controls.Add(this.buttonOpen_BIK);
            this.panelTop_BIK.Controls.Add(this.buttonDone_BIK);
            this.panelTop_BIK.Controls.Add(this.groupBoxUslovie_BIK);
            this.panelTop_BIK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_BIK.Location = new System.Drawing.Point(0, 0);
            this.panelTop_BIK.Name = "panelTop_BIK";
            this.panelTop_BIK.Size = new System.Drawing.Size(873, 100);
            this.panelTop_BIK.TabIndex = 0;
            // 
            // panelLeft_BIK
            // 
            this.panelLeft_BIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft_BIK.Controls.Add(this.groupBoxOutput_BIK);
            this.panelLeft_BIK.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_BIK.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_BIK.Name = "panelLeft_BIK";
            this.panelLeft_BIK.Size = new System.Drawing.Size(200, 361);
            this.panelLeft_BIK.TabIndex = 1;
            // 
            // splitterLeftFill_BIK
            // 
            this.splitterLeftFill_BIK.Location = new System.Drawing.Point(200, 100);
            this.splitterLeftFill_BIK.Name = "splitterLeftFill_BIK";
            this.splitterLeftFill_BIK.Size = new System.Drawing.Size(3, 361);
            this.splitterLeftFill_BIK.TabIndex = 2;
            this.splitterLeftFill_BIK.TabStop = false;
            // 
            // panelFill_BIK
            // 
            this.panelFill_BIK.Controls.Add(this.chartOutput_BIK);
            this.panelFill_BIK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_BIK.Location = new System.Drawing.Point(203, 100);
            this.panelFill_BIK.Name = "panelFill_BIK";
            this.panelFill_BIK.Size = new System.Drawing.Size(670, 361);
            this.panelFill_BIK.TabIndex = 3;
            // 
            // groupBoxUslovie_BIK
            // 
            this.groupBoxUslovie_BIK.Controls.Add(this.textBoxUslovie_BIK);
            this.groupBoxUslovie_BIK.Location = new System.Drawing.Point(4, 4);
            this.groupBoxUslovie_BIK.Name = "groupBoxUslovie_BIK";
            this.groupBoxUslovie_BIK.Size = new System.Drawing.Size(390, 89);
            this.groupBoxUslovie_BIK.TabIndex = 0;
            this.groupBoxUslovie_BIK.TabStop = false;
            this.groupBoxUslovie_BIK.Text = "Условие";
            // 
            // textBoxUslovie_BIK
            // 
            this.textBoxUslovie_BIK.Location = new System.Drawing.Point(8, 20);
            this.textBoxUslovie_BIK.Multiline = true;
            this.textBoxUslovie_BIK.Name = "textBoxUslovie_BIK";
            this.textBoxUslovie_BIK.ReadOnly = true;
            this.textBoxUslovie_BIK.Size = new System.Drawing.Size(376, 63);
            this.textBoxUslovie_BIK.TabIndex = 0;
            this.textBoxUslovie_BIK.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в dataGridView все числа" +
    ", не равные 0. Построить диаграмму по этим значениям. У вещественных значений ок" +
    "руглить до трёх знаков после запятой.";
            // 
            // groupBoxOutput_BIK
            // 
            this.groupBoxOutput_BIK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_BIK.Controls.Add(this.dataGridViewOutput_BIK);
            this.groupBoxOutput_BIK.Location = new System.Drawing.Point(4, 6);
            this.groupBoxOutput_BIK.Name = "groupBoxOutput_BIK";
            this.groupBoxOutput_BIK.Size = new System.Drawing.Size(189, 342);
            this.groupBoxOutput_BIK.TabIndex = 0;
            this.groupBoxOutput_BIK.TabStop = false;
            this.groupBoxOutput_BIK.Text = "Вывод данных:";
            // 
            // dataGridViewOutput_BIK
            // 
            this.dataGridViewOutput_BIK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutput_BIK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_BIK.Location = new System.Drawing.Point(8, 20);
            this.dataGridViewOutput_BIK.Name = "dataGridViewOutput_BIK";
            this.dataGridViewOutput_BIK.Size = new System.Drawing.Size(175, 316);
            this.dataGridViewOutput_BIK.TabIndex = 0;
            // 
            // chartOutput_BIK
            // 
            this.chartOutput_BIK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartOutput_BIK.ChartAreas.Add(chartArea1);
            this.chartOutput_BIK.Location = new System.Drawing.Point(7, 7);
            this.chartOutput_BIK.Name = "chartOutput_BIK";
            this.chartOutput_BIK.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartOutput_BIK.Series.Add(series1);
            this.chartOutput_BIK.Size = new System.Drawing.Size(651, 342);
            this.chartOutput_BIK.TabIndex = 0;
            this.chartOutput_BIK.Text = "chart1";
            // 
            // buttonDone_BIK
            // 
            this.buttonDone_BIK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_BIK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_BIK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone_BIK.Location = new System.Drawing.Point(400, 24);
            this.buttonDone_BIK.Name = "buttonDone_BIK";
            this.buttonDone_BIK.Size = new System.Drawing.Size(87, 53);
            this.buttonDone_BIK.TabIndex = 1;
            this.buttonDone_BIK.Text = "Выполнить";
            this.buttonDone_BIK.UseVisualStyleBackColor = false;
            this.buttonDone_BIK.Click += new System.EventHandler(this.buttonDone_BIK_Click);
            // 
            // buttonOpen_BIK
            // 
            this.buttonOpen_BIK.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOpen_BIK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_BIK.Location = new System.Drawing.Point(493, 24);
            this.buttonOpen_BIK.Name = "buttonOpen_BIK";
            this.buttonOpen_BIK.Size = new System.Drawing.Size(87, 53);
            this.buttonOpen_BIK.TabIndex = 2;
            this.buttonOpen_BIK.Text = "Открыть файл";
            this.buttonOpen_BIK.UseVisualStyleBackColor = false;
            this.buttonOpen_BIK.Click += new System.EventHandler(this.buttonOpen_BIK_Click);
            // 
            // buttonInfo_BIK
            // 
            this.buttonInfo_BIK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_BIK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_BIK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_BIK.Location = new System.Drawing.Point(773, 24);
            this.buttonInfo_BIK.Name = "buttonInfo_BIK";
            this.buttonInfo_BIK.Size = new System.Drawing.Size(87, 53);
            this.buttonInfo_BIK.TabIndex = 3;
            this.buttonInfo_BIK.Text = "Справка";
            this.buttonInfo_BIK.UseVisualStyleBackColor = false;
            this.buttonInfo_BIK.Click += new System.EventHandler(this.buttonInfo_BIK_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 461);
            this.Controls.Add(this.panelFill_BIK);
            this.Controls.Add(this.splitterLeftFill_BIK);
            this.Controls.Add(this.panelLeft_BIK);
            this.Controls.Add(this.panelTop_BIK);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 25 | Бутаков И.К.";
            this.panelTop_BIK.ResumeLayout(false);
            this.panelLeft_BIK.ResumeLayout(false);
            this.panelFill_BIK.ResumeLayout(false);
            this.groupBoxUslovie_BIK.ResumeLayout(false);
            this.groupBoxUslovie_BIK.PerformLayout();
            this.groupBoxOutput_BIK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_BIK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutput_BIK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_BIK;
        private System.Windows.Forms.Panel panelLeft_BIK;
        private System.Windows.Forms.Splitter splitterLeftFill_BIK;
        private System.Windows.Forms.Panel panelFill_BIK;
        private System.Windows.Forms.GroupBox groupBoxUslovie_BIK;
        private System.Windows.Forms.TextBox textBoxUslovie_BIK;
        private System.Windows.Forms.GroupBox groupBoxOutput_BIK;
        private System.Windows.Forms.DataGridView dataGridViewOutput_BIK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutput_BIK;
        private System.Windows.Forms.Button buttonInfo_BIK;
        private System.Windows.Forms.Button buttonOpen_BIK;
        private System.Windows.Forms.Button buttonDone_BIK;
    }
}

