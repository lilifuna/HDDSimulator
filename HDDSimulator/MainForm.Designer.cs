namespace HDDSimulator
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chooseFCFS = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.driveSizeInput = new System.Windows.Forms.NumericUpDown();
            this.requestsNuberInput = new System.Windows.Forms.NumericUpDown();
            this.requestNumberInput = new System.Windows.Forms.Label();
            this.chanceOfRTRInput = new System.Windows.Forms.NumericUpDown();
            this.ChanceOfRTRLabel = new System.Windows.Forms.Label();
            this.maxAppearTimeInput = new System.Windows.Forms.NumericUpDown();
            this.maxDeadlineInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minDeadlineInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.totalHeadMovementOutput = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.filenameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chooseInputMethod = new System.Windows.Forms.CheckBox();
            this.groupParameters = new System.Windows.Forms.GroupBox();
            this.outputFilenameInput = new System.Windows.Forms.TextBox();
            this.writeDataToFileBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.headStartPointInput = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.requestsCountOutput = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.realtimeCountOutput = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.misssedDeadlinesOutput = new System.Windows.Forms.Label();
            this.totalRequestCountoutput = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveSizeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsNuberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chanceOfRTRInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAppearTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDeadlineInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDeadlineInput)).BeginInit();
            this.groupParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headStartPointInput)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFCFS
            // 
            this.chooseFCFS.AutoSize = true;
            this.chooseFCFS.Checked = true;
            this.chooseFCFS.Location = new System.Drawing.Point(11, 25);
            this.chooseFCFS.Name = "chooseFCFS";
            this.chooseFCFS.Size = new System.Drawing.Size(76, 24);
            this.chooseFCFS.TabIndex = 0;
            this.chooseFCFS.TabStop = true;
            this.chooseFCFS.Text = "FCFS";
            this.chooseFCFS.UseVisualStyleBackColor = true;
            this.chooseFCFS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.chooseFCFS.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "SSTF";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "SCAN";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(11, 115);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(94, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "C-SCAN";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 25);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(67, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "EDF";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 55);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(105, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "FD-SCAN";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chooseFCFS);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(1093, 597);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(1291, 597);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realtime requests handling";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(705, 786);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(173, 38);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Start Simulation";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Drive size";
            // 
            // driveSizeInput
            // 
            this.driveSizeInput.Location = new System.Drawing.Point(37, 303);
            this.driveSizeInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.driveSizeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.driveSizeInput.Name = "driveSizeInput";
            this.driveSizeInput.Size = new System.Drawing.Size(120, 26);
            this.driveSizeInput.TabIndex = 10;
            this.driveSizeInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // requestsNuberInput
            // 
            this.requestsNuberInput.Location = new System.Drawing.Point(178, 70);
            this.requestsNuberInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.requestsNuberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.requestsNuberInput.Name = "requestsNuberInput";
            this.requestsNuberInput.Size = new System.Drawing.Size(120, 26);
            this.requestsNuberInput.TabIndex = 11;
            this.requestsNuberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // requestNumberInput
            // 
            this.requestNumberInput.AutoSize = true;
            this.requestNumberInput.Location = new System.Drawing.Point(171, 47);
            this.requestNumberInput.Name = "requestNumberInput";
            this.requestNumberInput.Size = new System.Drawing.Size(149, 20);
            this.requestNumberInput.TabIndex = 12;
            this.requestNumberInput.Text = "Number of requests";
            // 
            // chanceOfRTRInput
            // 
            this.chanceOfRTRInput.Location = new System.Drawing.Point(340, 70);
            this.chanceOfRTRInput.Name = "chanceOfRTRInput";
            this.chanceOfRTRInput.Size = new System.Drawing.Size(120, 26);
            this.chanceOfRTRInput.TabIndex = 13;
            // 
            // ChanceOfRTRLabel
            // 
            this.ChanceOfRTRLabel.AutoSize = true;
            this.ChanceOfRTRLabel.Location = new System.Drawing.Point(336, 47);
            this.ChanceOfRTRLabel.Name = "ChanceOfRTRLabel";
            this.ChanceOfRTRLabel.Size = new System.Drawing.Size(101, 20);
            this.ChanceOfRTRLabel.TabIndex = 14;
            this.ChanceOfRTRLabel.Text = "% of realtime";
            // 
            // maxAppearTimeInput
            // 
            this.maxAppearTimeInput.Location = new System.Drawing.Point(25, 153);
            this.maxAppearTimeInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxAppearTimeInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxAppearTimeInput.Name = "maxAppearTimeInput";
            this.maxAppearTimeInput.Size = new System.Drawing.Size(120, 26);
            this.maxAppearTimeInput.TabIndex = 15;
            this.maxAppearTimeInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxAppearTimeInput.ValueChanged += new System.EventHandler(this.maxAppearTimeInput_ValueChanged);
            // 
            // maxDeadlineInput
            // 
            this.maxDeadlineInput.Location = new System.Drawing.Point(175, 153);
            this.maxDeadlineInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxDeadlineInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxDeadlineInput.Name = "maxDeadlineInput";
            this.maxDeadlineInput.Size = new System.Drawing.Size(120, 26);
            this.maxDeadlineInput.TabIndex = 16;
            this.maxDeadlineInput.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxDeadlineInput.ValueChanged += new System.EventHandler(this.maxDeadlineInput_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Max appear time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Max deadline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Min deadline";
            // 
            // minDeadlineInput
            // 
            this.minDeadlineInput.Location = new System.Drawing.Point(336, 153);
            this.minDeadlineInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minDeadlineInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minDeadlineInput.Name = "minDeadlineInput";
            this.minDeadlineInput.Size = new System.Drawing.Size(120, 26);
            this.minDeadlineInput.TabIndex = 19;
            this.minDeadlineInput.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.minDeadlineInput.ValueChanged += new System.EventHandler(this.minDeadlineInput_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(17, 665);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total Head Movement";
            // 
            // totalHeadMovementOutput
            // 
            this.totalHeadMovementOutput.AutoSize = true;
            this.totalHeadMovementOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalHeadMovementOutput.Location = new System.Drawing.Point(316, 660);
            this.totalHeadMovementOutput.Name = "totalHeadMovementOutput";
            this.totalHeadMovementOutput.Size = new System.Drawing.Size(35, 37);
            this.totalHeadMovementOutput.TabIndex = 22;
            this.totalHeadMovementOutput.Text = "0";
            this.totalHeadMovementOutput.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.totalHeadMovementOutput_ControlRemoved);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(493, 834);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(624, 23);
            this.progressBar.TabIndex = 23;
            // 
            // filenameInput
            // 
            this.filenameInput.Location = new System.Drawing.Point(612, 86);
            this.filenameInput.Name = "filenameInput";
            this.filenameInput.Size = new System.Drawing.Size(219, 26);
            this.filenameInput.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "File name (without extension)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chooseInputMethod
            // 
            this.chooseInputMethod.AutoSize = true;
            this.chooseInputMethod.Checked = true;
            this.chooseInputMethod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chooseInputMethod.Location = new System.Drawing.Point(612, 36);
            this.chooseInputMethod.Name = "chooseInputMethod";
            this.chooseInputMethod.Size = new System.Drawing.Size(132, 24);
            this.chooseInputMethod.TabIndex = 26;
            this.chooseInputMethod.Text = "Input from file";
            this.chooseInputMethod.UseVisualStyleBackColor = true;
            this.chooseInputMethod.CheckedChanged += new System.EventHandler(this.chooseInputMethod_CheckedChanged);
            // 
            // groupParameters
            // 
            this.groupParameters.Controls.Add(this.generateBtn);
            this.groupParameters.Controls.Add(this.requestsNuberInput);
            this.groupParameters.Controls.Add(this.requestNumberInput);
            this.groupParameters.Controls.Add(this.chanceOfRTRInput);
            this.groupParameters.Controls.Add(this.ChanceOfRTRLabel);
            this.groupParameters.Controls.Add(this.maxAppearTimeInput);
            this.groupParameters.Controls.Add(this.label4);
            this.groupParameters.Controls.Add(this.maxDeadlineInput);
            this.groupParameters.Controls.Add(this.minDeadlineInput);
            this.groupParameters.Controls.Add(this.label2);
            this.groupParameters.Controls.Add(this.label3);
            this.groupParameters.Enabled = false;
            this.groupParameters.Location = new System.Drawing.Point(12, 24);
            this.groupParameters.Name = "groupParameters";
            this.groupParameters.Size = new System.Drawing.Size(477, 240);
            this.groupParameters.TabIndex = 27;
            this.groupParameters.TabStop = false;
            this.groupParameters.Text = "Request parameters";
            // 
            // outputFilenameInput
            // 
            this.outputFilenameInput.Location = new System.Drawing.Point(1080, 142);
            this.outputFilenameInput.Name = "outputFilenameInput";
            this.outputFilenameInput.Size = new System.Drawing.Size(100, 26);
            this.outputFilenameInput.TabIndex = 28;
            // 
            // writeDataToFileBtn
            // 
            this.writeDataToFileBtn.Location = new System.Drawing.Point(1186, 142);
            this.writeDataToFileBtn.Name = "writeDataToFileBtn";
            this.writeDataToFileBtn.Size = new System.Drawing.Size(164, 32);
            this.writeDataToFileBtn.TabIndex = 29;
            this.writeDataToFileBtn.Text = "Write data to file";
            this.writeDataToFileBtn.UseVisualStyleBackColor = true;
            this.writeDataToFileBtn.Click += new System.EventHandler(this.writeDataToFileBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1076, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "filename";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(250, 247);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(837, 399);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            title6.Name = "asd";
            this.chart1.Titles.Add(title6);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Drive head start point";
            // 
            // headStartPointInput
            // 
            this.headStartPointInput.Location = new System.Drawing.Point(37, 377);
            this.headStartPointInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.headStartPointInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.headStartPointInput.Name = "headStartPointInput";
            this.headStartPointInput.Size = new System.Drawing.Size(120, 26);
            this.headStartPointInput.TabIndex = 33;
            this.headStartPointInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1173, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Non-Realtime requests";
            // 
            // requestsCountOutput
            // 
            this.requestsCountOutput.AutoSize = true;
            this.requestsCountOutput.Location = new System.Drawing.Point(1360, 318);
            this.requestsCountOutput.Name = "requestsCountOutput";
            this.requestsCountOutput.Size = new System.Drawing.Size(18, 20);
            this.requestsCountOutput.TabIndex = 35;
            this.requestsCountOutput.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1173, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Realtime requests";
            // 
            // realtimeCountOutput
            // 
            this.realtimeCountOutput.AutoSize = true;
            this.realtimeCountOutput.Location = new System.Drawing.Point(1360, 354);
            this.realtimeCountOutput.Name = "realtimeCountOutput";
            this.realtimeCountOutput.Size = new System.Drawing.Size(18, 20);
            this.realtimeCountOutput.TabIndex = 37;
            this.realtimeCountOutput.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1173, 392);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Deadlines missed";
            // 
            // misssedDeadlinesOutput
            // 
            this.misssedDeadlinesOutput.AutoSize = true;
            this.misssedDeadlinesOutput.Location = new System.Drawing.Point(1360, 392);
            this.misssedDeadlinesOutput.Name = "misssedDeadlinesOutput";
            this.misssedDeadlinesOutput.Size = new System.Drawing.Size(18, 20);
            this.misssedDeadlinesOutput.TabIndex = 39;
            this.misssedDeadlinesOutput.Text = "0";
            // 
            // totalRequestCountoutput
            // 
            this.totalRequestCountoutput.AutoSize = true;
            this.totalRequestCountoutput.Location = new System.Drawing.Point(1360, 280);
            this.totalRequestCountoutput.Name = "totalRequestCountoutput";
            this.totalRequestCountoutput.Size = new System.Drawing.Size(18, 20);
            this.totalRequestCountoutput.TabIndex = 41;
            this.totalRequestCountoutput.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1173, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Total number of requests";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(35, 62);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(110, 31);
            this.generateBtn.TabIndex = 42;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(612, 116);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(219, 32);
            this.readFileBtn.TabIndex = 42;
            this.readFileBtn.Text = "Read from file";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 26);
            this.button1.TabIndex = 43;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 652);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 45);
            this.button2.TabIndex = 44;
            this.button2.Text = "Reset graph";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 869);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.totalRequestCountoutput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.misssedDeadlinesOutput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.realtimeCountOutput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.requestsCountOutput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.headStartPointInput);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.writeDataToFileBtn);
            this.Controls.Add(this.outputFilenameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driveSizeInput);
            this.Controls.Add(this.groupParameters);
            this.Controls.Add(this.chooseInputMethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filenameInput);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.totalHeadMovementOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driveSizeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsNuberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chanceOfRTRInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAppearTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDeadlineInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minDeadlineInput)).EndInit();
            this.groupParameters.ResumeLayout(false);
            this.groupParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headStartPointInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton chooseFCFS;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown driveSizeInput;
        private System.Windows.Forms.NumericUpDown requestsNuberInput;
        private System.Windows.Forms.Label requestNumberInput;
        private System.Windows.Forms.NumericUpDown chanceOfRTRInput;
        private System.Windows.Forms.Label ChanceOfRTRLabel;
        private System.Windows.Forms.NumericUpDown maxAppearTimeInput;
        private System.Windows.Forms.NumericUpDown maxDeadlineInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minDeadlineInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalHeadMovementOutput;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox filenameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chooseInputMethod;
        private System.Windows.Forms.GroupBox groupParameters;
        private System.Windows.Forms.TextBox outputFilenameInput;
        private System.Windows.Forms.Button writeDataToFileBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown headStartPointInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label requestsCountOutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label realtimeCountOutput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label misssedDeadlinesOutput;
        private System.Windows.Forms.Label totalRequestCountoutput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

