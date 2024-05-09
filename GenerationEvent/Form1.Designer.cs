namespace GenerationEvent
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.probabilitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.runExperimentButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.probabilitiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // probabilitiesDataGridView
            // 
            this.probabilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probabilitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event,
            this.Probability});
            this.probabilitiesDataGridView.Location = new System.Drawing.Point(429, 32);
            this.probabilitiesDataGridView.Name = "probabilitiesDataGridView";
            this.probabilitiesDataGridView.Size = new System.Drawing.Size(344, 343);
            this.probabilitiesDataGridView.TabIndex = 0;
            // 
            // runExperimentButton
            // 
            this.runExperimentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runExperimentButton.Location = new System.Drawing.Point(25, 304);
            this.runExperimentButton.Name = "runExperimentButton";
            this.runExperimentButton.Size = new System.Drawing.Size(180, 71);
            this.runExperimentButton.TabIndex = 1;
            this.runExperimentButton.Text = "Сделать эксперимент";
            this.runExperimentButton.UseVisualStyleBackColor = true;
            this.runExperimentButton.Click += new System.EventHandler(this.runExperimentButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 395);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(748, 256);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(25, 33);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(375, 257);
            this.resultTextBox.TabIndex = 4;
            // 
            // Event
            // 
            this.Event.DataPropertyName = "Event";
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.Width = 200;
            // 
            // Probability
            // 
            this.Probability.DataPropertyName = "Probability";
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 663);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.runExperimentButton);
            this.Controls.Add(this.probabilitiesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.probabilitiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView probabilitiesDataGridView;
        private System.Windows.Forms.Button runExperimentButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
    }
}

