namespace Airport_TM.View.Class
{
    partial class MainWindow
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.Uniform = new System.Windows.Forms.RadioButton();
            this.Exp = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.WeightOne = new System.Windows.Forms.TextBox();
            this.WeightTwo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StopWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberBaggageOne = new System.Windows.Forms.TextBox();
            this.NumberBaggageTwo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.StopLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberConveyor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 50);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Время обработки";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(709, 474);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(760, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор распределения";
            // 
            // Uniform
            // 
            this.Uniform.AutoSize = true;
            this.Uniform.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Uniform.Location = new System.Drawing.Point(758, 84);
            this.Uniform.Name = "Uniform";
            this.Uniform.Size = new System.Drawing.Size(232, 22);
            this.Uniform.TabIndex = 2;
            this.Uniform.TabStop = true;
            this.Uniform.Text = "Равномерное распределение\r\n";
            this.Uniform.UseVisualStyleBackColor = true;
            // 
            // Exp
            // 
            this.Exp.AutoSize = true;
            this.Exp.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exp.Location = new System.Drawing.Point(758, 111);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(274, 22);
            this.Exp.TabIndex = 3;
            this.Exp.TabStop = true;
            this.Exp.Text = "Экспоненциальное распределение";
            this.Exp.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(761, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вес багажа";
            // 
            // WeightOne
            // 
            this.WeightOne.Location = new System.Drawing.Point(761, 158);
            this.WeightOne.Name = "WeightOne";
            this.WeightOne.Size = new System.Drawing.Size(100, 22);
            this.WeightOne.TabIndex = 5;
            // 
            // WeightTwo
            // 
            this.WeightTwo.Location = new System.Drawing.Point(916, 157);
            this.WeightTwo.Name = "WeightTwo";
            this.WeightTwo.Size = new System.Drawing.Size(100, 22);
            this.WeightTwo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(866, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "---------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(761, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ограничение по весу багажа";
            // 
            // StopWeight
            // 
            this.StopWeight.Location = new System.Drawing.Point(761, 207);
            this.StopWeight.Name = "StopWeight";
            this.StopWeight.Size = new System.Drawing.Size(130, 22);
            this.StopWeight.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(761, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество багажа";
            // 
            // NumberBaggageOne
            // 
            this.NumberBaggageOne.Location = new System.Drawing.Point(761, 256);
            this.NumberBaggageOne.Name = "NumberBaggageOne";
            this.NumberBaggageOne.Size = new System.Drawing.Size(100, 22);
            this.NumberBaggageOne.TabIndex = 11;
            // 
            // NumberBaggageTwo
            // 
            this.NumberBaggageTwo.Location = new System.Drawing.Point(916, 255);
            this.NumberBaggageTwo.Name = "NumberBaggageTwo";
            this.NumberBaggageTwo.Size = new System.Drawing.Size(100, 22);
            this.NumberBaggageTwo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(866, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "---------";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight.Location = new System.Drawing.Point(732, 342);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(254, 18);
            this.Weight.TabIndex = 14;
            this.Weight.Text = "Количество не прошедших по весу:";
            // 
            // StopLabel
            // 
            this.StopLabel.AutoSize = true;
            this.StopLabel.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopLabel.Location = new System.Drawing.Point(992, 342);
            this.StopLabel.Name = "StopLabel";
            this.StopLabel.Size = new System.Drawing.Size(16, 18);
            this.StopLabel.TabIndex = 15;
            this.StopLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(761, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Количество конвейеров";
            // 
            // NumberConveyor
            // 
            this.NumberConveyor.Location = new System.Drawing.Point(761, 304);
            this.NumberConveyor.Name = "NumberConveyor";
            this.NumberConveyor.Size = new System.Drawing.Size(100, 22);
            this.NumberConveyor.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(735, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(893, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 50);
            this.button2.TabIndex = 19;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 47);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(734, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Моделирование работы аэропорта (управление перевозкой грузов)";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(791, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 50);
            this.button3.TabIndex = 21;
            this.button3.Text = "Старт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumberConveyor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StopLabel);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumberBaggageTwo);
            this.Controls.Add(this.NumberBaggageOne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StopWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeightTwo);
            this.Controls.Add(this.WeightOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Uniform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевозка грузов";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Uniform;
        private System.Windows.Forms.RadioButton Exp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WeightOne;
        private System.Windows.Forms.TextBox WeightTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StopWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumberBaggageOne;
        private System.Windows.Forms.TextBox NumberBaggageTwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label StopLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumberConveyor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}

