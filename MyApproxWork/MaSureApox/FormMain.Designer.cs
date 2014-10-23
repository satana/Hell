namespace MaSureApox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.buttonCalcX = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelInputX = new System.Windows.Forms.Label();
            this.labelInputTable = new System.Windows.Forms.Label();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.valueX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownBasis = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.labelInputBasis = new System.Windows.Forms.Label();
            this.labelInputCount = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.gpLinerSplain = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridTable1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudBasis = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.bCalc = new System.Windows.Forms.Button();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.lmin = new System.Windows.Forms.Label();
            this.lmax = new System.Windows.Forms.Label();
            this.lStep = new System.Windows.Forms.Label();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.tbFunc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bHelp = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBasis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.gpLinerSplain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput.Controls.Add(this.buttonCalcX);
            this.groupBoxInput.Controls.Add(this.buttonClear);
            this.groupBoxInput.Controls.Add(this.buttonCalc);
            this.groupBoxInput.Controls.Add(this.textBoxX);
            this.groupBoxInput.Controls.Add(this.labelInputX);
            this.groupBoxInput.Controls.Add(this.labelInputTable);
            this.groupBoxInput.Controls.Add(this.dataGridTable);
            this.groupBoxInput.Controls.Add(this.numericUpDownBasis);
            this.groupBoxInput.Controls.Add(this.numericUpDownCount);
            this.groupBoxInput.Controls.Add(this.labelInputBasis);
            this.groupBoxInput.Controls.Add(this.labelInputCount);
            this.groupBoxInput.Location = new System.Drawing.Point(2, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(272, 521);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Метод наименьших квадратов";
            // 
            // buttonCalcX
            // 
            this.buttonCalcX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCalcX.Location = new System.Drawing.Point(6, 492);
            this.buttonCalcX.Name = "buttonCalcX";
            this.buttonCalcX.Size = new System.Drawing.Size(260, 23);
            this.buttonCalcX.TabIndex = 7;
            this.buttonCalcX.Text = "Вычислить значение функции";
            this.buttonCalcX.UseVisualStyleBackColor = true;
            this.buttonCalcX.Click += new System.EventHandler(this.buttonCalcX_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(136, 427);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCalc.Location = new System.Drawing.Point(6, 427);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(130, 23);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Рассчитать";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxX.Location = new System.Drawing.Point(143, 463);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(123, 23);
            this.textBoxX.TabIndex = 6;
            this.textBoxX.Text = "0";
            // 
            // labelInputX
            // 
            this.labelInputX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInputX.AutoSize = true;
            this.labelInputX.Location = new System.Drawing.Point(3, 466);
            this.labelInputX.Name = "labelInputX";
            this.labelInputX.Size = new System.Drawing.Size(86, 16);
            this.labelInputX.TabIndex = 0;
            this.labelInputX.Text = "Значение X";
            // 
            // labelInputTable
            // 
            this.labelInputTable.AutoSize = true;
            this.labelInputTable.Location = new System.Drawing.Point(3, 71);
            this.labelInputTable.Name = "labelInputTable";
            this.labelInputTable.Size = new System.Drawing.Size(85, 16);
            this.labelInputTable.TabIndex = 0;
            this.labelInputTable.Text = "Узлы сетки";
            // 
            // dataGridTable
            // 
            this.dataGridTable.AllowUserToAddRows = false;
            this.dataGridTable.AllowUserToDeleteRows = false;
            this.dataGridTable.AllowUserToResizeColumns = false;
            this.dataGridTable.AllowUserToResizeRows = false;
            this.dataGridTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valueX,
            this.inputY});
            this.dataGridTable.Location = new System.Drawing.Point(6, 90);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.ShowEditingIcon = false;
            this.dataGridTable.Size = new System.Drawing.Size(260, 331);
            this.dataGridTable.TabIndex = 3;
            this.dataGridTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridTable_DataError);
            // 
            // valueX
            // 
            this.valueX.HeaderText = "X";
            this.valueX.Name = "valueX";
            // 
            // inputY
            // 
            this.inputY.HeaderText = "Y";
            this.inputY.Name = "inputY";
            // 
            // numericUpDownBasis
            // 
            this.numericUpDownBasis.Location = new System.Drawing.Point(140, 44);
            this.numericUpDownBasis.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBasis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBasis.Name = "numericUpDownBasis";
            this.numericUpDownBasis.Size = new System.Drawing.Size(126, 23);
            this.numericUpDownBasis.TabIndex = 2;
            this.numericUpDownBasis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(140, 17);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(126, 23);
            this.numericUpDownCount.TabIndex = 1;
            this.numericUpDownCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.numericUpDownCount_ValueChanged);
            // 
            // labelInputBasis
            // 
            this.labelInputBasis.AutoSize = true;
            this.labelInputBasis.Location = new System.Drawing.Point(3, 46);
            this.labelInputBasis.Name = "labelInputBasis";
            this.labelInputBasis.Size = new System.Drawing.Size(133, 16);
            this.labelInputBasis.TabIndex = 0;
            this.labelInputBasis.Text = "Степень полинома";
            // 
            // labelInputCount
            // 
            this.labelInputCount.AutoSize = true;
            this.labelInputCount.Location = new System.Drawing.Point(3, 19);
            this.labelInputCount.Name = "labelInputCount";
            this.labelInputCount.Size = new System.Drawing.Size(131, 16);
            this.labelInputCount.TabIndex = 0;
            this.labelInputCount.Text = "Количество узлов";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult.Controls.Add(this.richTextBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(280, 0);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(395, 395);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вычисления";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxResult.Location = new System.Drawing.Point(3, 19);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxResult.Size = new System.Drawing.Size(389, 373);
            this.richTextBoxResult.TabIndex = 6;
            this.richTextBoxResult.Text = "Данная программа позволяет выполнить среднеквадратичное приближение по степенному" +
    " базису для функции, заданной таблично, а также вычислить значение функции при н" +
    "екотором значении параметра x\n";
            // 
            // gpLinerSplain
            // 
            this.gpLinerSplain.Controls.Add(this.button1);
            this.gpLinerSplain.Controls.Add(this.dataGridTable1);
            this.gpLinerSplain.Controls.Add(this.button2);
            this.gpLinerSplain.Controls.Add(this.label4);
            this.gpLinerSplain.Controls.Add(this.button3);
            this.gpLinerSplain.Controls.Add(this.label3);
            this.gpLinerSplain.Controls.Add(this.tbVal);
            this.gpLinerSplain.Controls.Add(this.nudCount);
            this.gpLinerSplain.Controls.Add(this.label1);
            this.gpLinerSplain.Controls.Add(this.nudBasis);
            this.gpLinerSplain.Controls.Add(this.label2);
            this.gpLinerSplain.Location = new System.Drawing.Point(681, 0);
            this.gpLinerSplain.Name = "gpLinerSplain";
            this.gpLinerSplain.Size = new System.Drawing.Size(290, 521);
            this.gpLinerSplain.TabIndex = 3;
            this.gpLinerSplain.TabStop = false;
            this.gpLinerSplain.Text = "Линейный сплайн";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(19, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Вычислить значение функции";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridTable1
            // 
            this.dataGridTable1.AllowUserToAddRows = false;
            this.dataGridTable1.AllowUserToDeleteRows = false;
            this.dataGridTable1.AllowUserToResizeColumns = false;
            this.dataGridTable1.AllowUserToResizeRows = false;
            this.dataGridTable1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridTable1.Location = new System.Drawing.Point(19, 90);
            this.dataGridTable1.Name = "dataGridTable1";
            this.dataGridTable1.ShowEditingIcon = false;
            this.dataGridTable1.Size = new System.Drawing.Size(260, 331);
            this.dataGridTable1.TabIndex = 14;
            this.dataGridTable1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridTable1_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Y";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(156, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Количество узлов";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(19, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Рассчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Степень полинома";
            // 
            // tbVal
            // 
            this.tbVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbVal.Location = new System.Drawing.Point(156, 463);
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(123, 23);
            this.tbVal.TabIndex = 17;
            this.tbVal.Text = "0";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(153, 17);
            this.nudCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(126, 23);
            this.nudCount.TabIndex = 12;
            this.nudCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCount.ValueChanged += new System.EventHandler(this.nudCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Значение X";
            // 
            // nudBasis
            // 
            this.nudBasis.Location = new System.Drawing.Point(153, 44);
            this.nudBasis.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBasis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBasis.Name = "nudBasis";
            this.nudBasis.Size = new System.Drawing.Size(126, 23);
            this.nudBasis.TabIndex = 13;
            this.nudBasis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Узлы сетки";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 485);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Построить графики";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bCalc
            // 
            this.bCalc.Location = new System.Drawing.Point(485, 485);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(190, 30);
            this.bCalc.TabIndex = 5;
            this.bCalc.Text = "Расчет точек";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(444, 442);
            this.nudMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(44, 23);
            this.nudMin.TabIndex = 7;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(534, 442);
            this.nudMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(44, 23);
            this.nudMax.TabIndex = 8;
            // 
            // lmin
            // 
            this.lmin.AutoSize = true;
            this.lmin.Location = new System.Drawing.Point(410, 444);
            this.lmin.Name = "lmin";
            this.lmin.Size = new System.Drawing.Size(33, 16);
            this.lmin.TabIndex = 9;
            this.lmin.Text = "мин";
            // 
            // lmax
            // 
            this.lmax.AutoSize = true;
            this.lmax.Location = new System.Drawing.Point(493, 444);
            this.lmax.Name = "lmax";
            this.lmax.Size = new System.Drawing.Size(41, 16);
            this.lmax.TabIndex = 10;
            this.lmax.Text = "макс";
            // 
            // lStep
            // 
            this.lStep.AutoSize = true;
            this.lStep.Location = new System.Drawing.Point(584, 444);
            this.lStep.Name = "lStep";
            this.lStep.Size = new System.Drawing.Size(33, 16);
            this.lStep.TabIndex = 11;
            this.lStep.Text = "шаг";
            // 
            // tbStep
            // 
            this.tbStep.Location = new System.Drawing.Point(623, 441);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(49, 23);
            this.tbStep.TabIndex = 7;
            this.tbStep.Text = "0";
            this.tbStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFunc
            // 
            this.tbFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFunc.Location = new System.Drawing.Point(327, 402);
            this.tbFunc.Name = "tbFunc";
            this.tbFunc.Size = new System.Drawing.Size(345, 23);
            this.tbFunc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "f(x)=";
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(283, 442);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(121, 23);
            this.bHelp.TabIndex = 13;
            this.bHelp.Text = "Справка";
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 522);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.tbFunc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.lStep);
            this.Controls.Add(this.lmax);
            this.Controls.Add(this.lmin);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.bCalc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gpLinerSplain);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxInput);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Среднеквадратичное приближение функций";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBasis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.gpLinerSplain.ResumeLayout(false);
            this.gpLinerSplain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.NumericUpDown numericUpDownBasis;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelInputBasis;
        private System.Windows.Forms.Label labelInputCount;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.Label labelInputTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueX;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelInputX;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCalcX;
        private System.Windows.Forms.GroupBox gpLinerSplain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridTable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudBasis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label lmin;
        private System.Windows.Forms.Label lmax;
        private System.Windows.Forms.Label lStep;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFunc;
        private System.Windows.Forms.Button bHelp;
    }
}

