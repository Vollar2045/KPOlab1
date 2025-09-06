namespace KPOlab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGenerate = new Button();
            labelArray = new Label();
            labelResult = new Label();
            buttonCalculate = new Button();
            tabControl1 = new TabControl();
            tab1 = new TabPage();
            tab2 = new TabPage();
            labelHint = new Label();
            dataGridView2 = new DataGridView();
            textBoxInput = new TextBox();
            labelResultArray = new Label();
            labelOriginalArray = new Label();
            buttonCalculate2 = new Button();
            buttonInputArray = new Button();
            tab3 = new TabPage();
            dataGridView3 = new DataGridView();
            labelInfo3 = new Label();
            buttonConvert3 = new Button();
            buttonGenerate3 = new Button();
            tab4 = new TabPage();
            labelInfo4 = new Label();
            dataGridView4 = new DataGridView();
            dataGridViewResults4 = new DataGridView();
            buttonCalculate4 = new Button();
            buttonGenerate4 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            tab1.SuspendLayout();
            tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tab4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults4).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(363, 188);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(142, 23);
            buttonGenerate.TabIndex = 0;
            buttonGenerate.Text = "Сгенерировать массив";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // labelArray
            // 
            labelArray.AutoSize = true;
            labelArray.Location = new Point(363, 231);
            labelArray.Name = "labelArray";
            labelArray.Size = new Size(55, 15);
            labelArray.TabIndex = 1;
            labelArray.Text = "Массив: ";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(363, 265);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(66, 15);
            labelResult.TabIndex = 2;
            labelResult.Text = "Результат: ";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(511, 188);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(142, 23);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Вычислить среднее";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tab2);
            tabControl1.Controls.Add(tab3);
            tabControl1.Controls.Add(tab4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1018, 556);
            tabControl1.TabIndex = 4;
            // 
            // tab1
            // 
            tab1.Controls.Add(buttonGenerate);
            tab1.Controls.Add(buttonCalculate);
            tab1.Controls.Add(labelResult);
            tab1.Controls.Add(labelArray);
            tab1.Location = new Point(4, 24);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(1010, 528);
            tab1.TabIndex = 0;
            tab1.Text = "Задание 1";
            tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            tab2.Controls.Add(labelHint);
            tab2.Controls.Add(dataGridView2);
            tab2.Controls.Add(textBoxInput);
            tab2.Controls.Add(labelResultArray);
            tab2.Controls.Add(labelOriginalArray);
            tab2.Controls.Add(buttonCalculate2);
            tab2.Controls.Add(buttonInputArray);
            tab2.Location = new Point(4, 24);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(1010, 528);
            tab2.TabIndex = 1;
            tab2.Text = "Задание 2";
            tab2.UseVisualStyleBackColor = true;
            // 
            // labelHint
            // 
            labelHint.AutoSize = true;
            labelHint.Location = new Point(345, 26);
            labelHint.Name = "labelHint";
            labelHint.Size = new Size(404, 15);
            labelHint.TabIndex = 6;
            labelHint.Text = "Вводите числа через пробел или точку с запятой (Например: 1,5 2,3;3,7)";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(345, 186);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(345, 352);
            dataGridView2.TabIndex = 5;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(345, 53);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(283, 23);
            textBoxInput.TabIndex = 4;
            // 
            // labelResultArray
            // 
            labelResultArray.AutoSize = true;
            labelResultArray.Location = new Point(345, 159);
            labelResultArray.Name = "labelResultArray";
            labelResultArray.Size = new Size(66, 15);
            labelResultArray.TabIndex = 3;
            labelResultArray.Text = "Результат: ";
            // 
            // labelOriginalArray
            // 
            labelOriginalArray.AutoSize = true;
            labelOriginalArray.Location = new Point(345, 133);
            labelOriginalArray.Name = "labelOriginalArray";
            labelOriginalArray.Size = new Size(112, 15);
            labelOriginalArray.TabIndex = 2;
            labelOriginalArray.Text = "Исходный массив: ";
            // 
            // buttonCalculate2
            // 
            buttonCalculate2.Location = new Point(345, 93);
            buttonCalculate2.Name = "buttonCalculate2";
            buttonCalculate2.Size = new Size(186, 23);
            buttonCalculate2.TabIndex = 1;
            buttonCalculate2.Text = "Вычислить значения функции";
            buttonCalculate2.UseVisualStyleBackColor = true;
            buttonCalculate2.Click += buttonCalculate2_Click;
            // 
            // buttonInputArray
            // 
            buttonInputArray.Location = new Point(634, 53);
            buttonInputArray.Name = "buttonInputArray";
            buttonInputArray.Size = new Size(184, 23);
            buttonInputArray.TabIndex = 0;
            buttonInputArray.Text = "Подтверждение ввода массива";
            buttonInputArray.UseVisualStyleBackColor = true;
            buttonInputArray.Click += buttonInputArray_Click;
            // 
            // tab3
            // 
            tab3.Controls.Add(dataGridView3);
            tab3.Controls.Add(labelInfo3);
            tab3.Controls.Add(buttonConvert3);
            tab3.Controls.Add(buttonGenerate3);
            tab3.Location = new Point(4, 24);
            tab3.Name = "tab3";
            tab3.Size = new Size(1010, 528);
            tab3.TabIndex = 2;
            tab3.Text = "Задание 3";
            tab3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(13, 209);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(1000, 279);
            dataGridView3.TabIndex = 3;
            // 
            // labelInfo3
            // 
            labelInfo3.AutoSize = true;
            labelInfo3.Location = new Point(465, 182);
            labelInfo3.Name = "labelInfo3";
            labelInfo3.Size = new Size(49, 15);
            labelInfo3.TabIndex = 2;
            labelInfo3.Text = "Массив";
            // 
            // buttonConvert3
            // 
            buttonConvert3.Location = new Point(502, 108);
            buttonConvert3.Name = "buttonConvert3";
            buttonConvert3.Size = new Size(116, 23);
            buttonConvert3.TabIndex = 1;
            buttonConvert3.Text = "Преобразовать";
            buttonConvert3.UseVisualStyleBackColor = true;
            buttonConvert3.Click += buttonConvert3_Click;
            // 
            // buttonGenerate3
            // 
            buttonGenerate3.Location = new Point(322, 108);
            buttonGenerate3.Name = "buttonGenerate3";
            buttonGenerate3.Size = new Size(146, 23);
            buttonGenerate3.TabIndex = 0;
            buttonGenerate3.Text = "Сгенерировать массив";
            buttonGenerate3.UseVisualStyleBackColor = true;
            buttonGenerate3.Click += buttonGenerate3_Click;
            // 
            // tab4
            // 
            tab4.Controls.Add(labelInfo4);
            tab4.Controls.Add(dataGridView4);
            tab4.Controls.Add(dataGridViewResults4);
            tab4.Controls.Add(buttonCalculate4);
            tab4.Controls.Add(buttonGenerate4);
            tab4.Location = new Point(4, 24);
            tab4.Name = "tab4";
            tab4.Size = new Size(1010, 528);
            tab4.TabIndex = 3;
            tab4.Text = "Задание 4";
            tab4.UseVisualStyleBackColor = true;
            // 
            // labelInfo4
            // 
            labelInfo4.AutoSize = true;
            labelInfo4.Location = new Point(473, 154);
            labelInfo4.Name = "labelInfo4";
            labelInfo4.Size = new Size(38, 15);
            labelInfo4.TabIndex = 4;
            labelInfo4.Text = "label1";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.Control;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(13, 214);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(408, 155);
            dataGridView4.TabIndex = 3;
            // 
            // dataGridViewResults4
            // 
            dataGridViewResults4.BackgroundColor = SystemColors.Control;
            dataGridViewResults4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults4.Location = new Point(533, 214);
            dataGridViewResults4.Name = "dataGridViewResults4";
            dataGridViewResults4.Size = new Size(280, 216);
            dataGridViewResults4.TabIndex = 2;
            // 
            // buttonCalculate4
            // 
            buttonCalculate4.Location = new Point(421, 111);
            buttonCalculate4.Name = "buttonCalculate4";
            buttonCalculate4.Size = new Size(135, 23);
            buttonCalculate4.TabIndex = 1;
            buttonCalculate4.Text = "Найти среднее";
            buttonCalculate4.UseVisualStyleBackColor = true;
            buttonCalculate4.Click += buttonCalculate4_Click;
            // 
            // buttonGenerate4
            // 
            buttonGenerate4.Location = new Point(412, 82);
            buttonGenerate4.Name = "buttonGenerate4";
            buttonGenerate4.Size = new Size(157, 23);
            buttonGenerate4.TabIndex = 0;
            buttonGenerate4.Text = "Сгенерировать массив";
            buttonGenerate4.UseVisualStyleBackColor = true;
            buttonGenerate4.Click += buttonGenerate4_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1024, 562);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 562);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tab1.PerformLayout();
            tab2.ResumeLayout(false);
            tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tab3.ResumeLayout(false);
            tab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tab4.ResumeLayout(false);
            tab4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults4).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGenerate;
        private Label labelArray;
        private Label labelResult;
        private Button buttonCalculate;
        private TabControl tabControl1;
        private TabPage tab1;
        private TabPage tab2;
        private TabPage tab3;
        private TabPage tab4;
        private Label labelResultArray;
        private Label labelOriginalArray;
        private Button buttonCalculate2;
        private Button buttonInputArray;
        private TextBox textBoxInput;
        private DataGridView dataGridView2;
        private Label labelHint;
        private DataGridView dataGridView3;
        private Label labelInfo3;
        private Button buttonConvert3;
        private Button buttonGenerate3;
        private Label labelInfo4;
        private DataGridView dataGridView4;
        private DataGridView dataGridViewResults4;
        private Button buttonCalculate4;
        private Button buttonGenerate4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
