
namespace Phidget_Controller_Forms
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.RawVoltageRatioLabel = new System.Windows.Forms.Label();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.dataGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.maxPointsSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timespanLabel = new System.Windows.Forms.Label();
            this.setTargetLoadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.targetLoadLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loadCellTareButton = new System.Windows.Forms.Button();
            this.loadCellTareLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loadCellSetScaleButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.loadCellSetScaleLabel = new System.Windows.Forms.Label();
            this.ActivateMotorCheckbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sumOfPIDLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.targetLoadNumSelector = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.movingAverageSizeNumSelector = new System.Windows.Forms.NumericUpDown();
            this.setPotMinButton = new System.Windows.Forms.Button();
            this.setPotMax = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.potMinLabel = new System.Windows.Forms.Label();
            this.potMaxLabel = new System.Windows.Forms.Label();
            this.proportionalGainNumSelector = new System.Windows.Forms.NumericUpDown();
            this.ActivateThrottleMotorCheckbox = new System.Windows.Forms.CheckBox();
            this.throttlePosSlider = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.throttlePosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPointsSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetLoadNumSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingAverageSizeNumSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proportionalGainNumSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttlePosSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw Voltage Ratio:";
            // 
            // RawVoltageRatioLabel
            // 
            this.RawVoltageRatioLabel.AutoSize = true;
            this.RawVoltageRatioLabel.Location = new System.Drawing.Point(291, 21);
            this.RawVoltageRatioLabel.Name = "RawVoltageRatioLabel";
            this.RawVoltageRatioLabel.Size = new System.Drawing.Size(102, 32);
            this.RawVoltageRatioLabel.TabIndex = 1;
            this.RawVoltageRatioLabel.Text = "NotSet";
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(27, 79);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DebugLabel.Size = new System.Drawing.Size(219, 32);
            this.DebugLabel.TabIndex = 2;
            this.DebugLabel.Text = "DEBUG_LABEL";
            this.DebugLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGraph
            // 
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.dataGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dataGraph.Legends.Add(legend1);
            this.dataGraph.Location = new System.Drawing.Point(19, 112);
            this.dataGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGraph.Name = "dataGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Enabled = false;
            series1.Legend = "Legend1";
            series1.LegendText = "Raw Voltage";
            series1.Name = "RawVoltage";
            dataPoint1.MarkerSize = 100;
            series1.Points.Add(dataPoint1);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "CalibratedWeight";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "SumOfPID";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "movingAverage";
            series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series5.CustomProperties = "BubbleMinSize=2, BubbleScaleMax=100, BubbleMaxSize=20";
            series5.Legend = "Legend1";
            series5.MarkerSize = 20;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "ActiveMovingAverageRegion";
            series5.YValuesPerPoint = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "ThrottlePosition";
            this.dataGraph.Series.Add(series1);
            this.dataGraph.Series.Add(series2);
            this.dataGraph.Series.Add(series3);
            this.dataGraph.Series.Add(series4);
            this.dataGraph.Series.Add(series5);
            this.dataGraph.Series.Add(series6);
            this.dataGraph.Size = new System.Drawing.Size(2461, 687);
            this.dataGraph.TabIndex = 3;
            this.dataGraph.Text = "Data";
            // 
            // maxPointsSlider
            // 
            this.maxPointsSlider.Location = new System.Drawing.Point(1984, 2);
            this.maxPointsSlider.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.maxPointsSlider.Maximum = 60;
            this.maxPointsSlider.Name = "maxPointsSlider";
            this.maxPointsSlider.Size = new System.Drawing.Size(496, 114);
            this.maxPointsSlider.TabIndex = 5;
            this.maxPointsSlider.TickFrequency = 200;
            this.maxPointsSlider.Value = 5;
            this.maxPointsSlider.Scroll += new System.EventHandler(this.maxPointsSlider_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1704, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Timespan";
            // 
            // timespanLabel
            // 
            this.timespanLabel.AutoSize = true;
            this.timespanLabel.Location = new System.Drawing.Point(1861, 21);
            this.timespanLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.timespanLabel.Name = "timespanLabel";
            this.timespanLabel.Size = new System.Drawing.Size(82, 32);
            this.timespanLabel.TabIndex = 7;
            this.timespanLabel.Text = "5 sec";
            // 
            // setTargetLoadButton
            // 
            this.setTargetLoadButton.Location = new System.Drawing.Point(33, 804);
            this.setTargetLoadButton.Name = "setTargetLoadButton";
            this.setTargetLoadButton.Size = new System.Drawing.Size(263, 58);
            this.setTargetLoadButton.TabIndex = 8;
            this.setTargetLoadButton.Text = "SetTargetLoad";
            this.setTargetLoadButton.UseVisualStyleBackColor = true;
            this.setTargetLoadButton.Click += new System.EventHandler(this.setTargetLoadButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 804);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Target Load (units)";
            // 
            // targetLoadLabel
            // 
            this.targetLoadLabel.AutoSize = true;
            this.targetLoadLabel.Location = new System.Drawing.Point(751, 804);
            this.targetLoadLabel.Name = "targetLoadLabel";
            this.targetLoadLabel.Size = new System.Drawing.Size(31, 32);
            this.targetLoadLabel.TabIndex = 11;
            this.targetLoadLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 804);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "->";
            // 
            // loadCellTareButton
            // 
            this.loadCellTareButton.Location = new System.Drawing.Point(33, 870);
            this.loadCellTareButton.Name = "loadCellTareButton";
            this.loadCellTareButton.Size = new System.Drawing.Size(263, 49);
            this.loadCellTareButton.TabIndex = 14;
            this.loadCellTareButton.Text = "loadCellTare";
            this.loadCellTareButton.UseVisualStyleBackColor = true;
            this.loadCellTareButton.Click += new System.EventHandler(this.loadCellTareButton_Click);
            // 
            // loadCellTareLabel
            // 
            this.loadCellTareLabel.AutoSize = true;
            this.loadCellTareLabel.Location = new System.Drawing.Point(408, 879);
            this.loadCellTareLabel.Name = "loadCellTareLabel";
            this.loadCellTareLabel.Size = new System.Drawing.Size(31, 32);
            this.loadCellTareLabel.TabIndex = 15;
            this.loadCellTareLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 879);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Offset:";
            // 
            // loadCellSetScaleButton
            // 
            this.loadCellSetScaleButton.Location = new System.Drawing.Point(33, 926);
            this.loadCellSetScaleButton.Name = "loadCellSetScaleButton";
            this.loadCellSetScaleButton.Size = new System.Drawing.Size(263, 46);
            this.loadCellSetScaleButton.TabIndex = 17;
            this.loadCellSetScaleButton.Text = "loadCellSetScale";
            this.loadCellSetScaleButton.UseVisualStyleBackColor = true;
            this.loadCellSetScaleButton.Click += new System.EventHandler(this.loadCellSetScaleButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 934);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Scale:";
            // 
            // loadCellSetScaleLabel
            // 
            this.loadCellSetScaleLabel.AutoSize = true;
            this.loadCellSetScaleLabel.Location = new System.Drawing.Point(408, 934);
            this.loadCellSetScaleLabel.Name = "loadCellSetScaleLabel";
            this.loadCellSetScaleLabel.Size = new System.Drawing.Size(31, 32);
            this.loadCellSetScaleLabel.TabIndex = 19;
            this.loadCellSetScaleLabel.Text = "1";
            // 
            // ActivateMotorCheckbox
            // 
            this.ActivateMotorCheckbox.AutoSize = true;
            this.ActivateMotorCheckbox.Location = new System.Drawing.Point(1034, 803);
            this.ActivateMotorCheckbox.Name = "ActivateMotorCheckbox";
            this.ActivateMotorCheckbox.Size = new System.Drawing.Size(301, 36);
            this.ActivateMotorCheckbox.TabIndex = 20;
            this.ActivateMotorCheckbox.Text = "ActivateBrakeMotor";
            this.ActivateMotorCheckbox.UseVisualStyleBackColor = true;
            this.ActivateMotorCheckbox.CheckedChanged += new System.EventHandler(this.ActivateMotorCheckbox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1070, 842);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "sumOfPID value:";
            // 
            // sumOfPIDLabel
            // 
            this.sumOfPIDLabel.AutoSize = true;
            this.sumOfPIDLabel.Location = new System.Drawing.Point(1304, 842);
            this.sumOfPIDLabel.Name = "sumOfPIDLabel";
            this.sumOfPIDLabel.Size = new System.Drawing.Size(102, 32);
            this.sumOfPIDLabel.TabIndex = 22;
            this.sumOfPIDLabel.Text = "NotSet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(975, 883);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "PGain";
            // 
            // targetLoadNumSelector
            // 
            this.targetLoadNumSelector.DecimalPlaces = 1;
            this.targetLoadNumSelector.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.targetLoadNumSelector.Location = new System.Drawing.Point(563, 802);
            this.targetLoadNumSelector.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.targetLoadNumSelector.Name = "targetLoadNumSelector";
            this.targetLoadNumSelector.Size = new System.Drawing.Size(136, 38);
            this.targetLoadNumSelector.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1704, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 32);
            this.label9.TabIndex = 26;
            this.label9.Text = "movingAverageSize";
            // 
            // movingAverageSizeNumSelector
            // 
            this.movingAverageSizeNumSelector.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.movingAverageSizeNumSelector.Location = new System.Drawing.Point(1979, 65);
            this.movingAverageSizeNumSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.movingAverageSizeNumSelector.Name = "movingAverageSizeNumSelector";
            this.movingAverageSizeNumSelector.Size = new System.Drawing.Size(120, 38);
            this.movingAverageSizeNumSelector.TabIndex = 27;
            this.movingAverageSizeNumSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.movingAverageSizeNumSelector.ValueChanged += new System.EventHandler(this.movingAverageSizeNumSelector_ValueChanged);
            // 
            // setPotMinButton
            // 
            this.setPotMinButton.Location = new System.Drawing.Point(33, 1020);
            this.setPotMinButton.Name = "setPotMinButton";
            this.setPotMinButton.Size = new System.Drawing.Size(263, 58);
            this.setPotMinButton.TabIndex = 28;
            this.setPotMinButton.Text = "SetPotMin";
            this.setPotMinButton.UseVisualStyleBackColor = true;
            this.setPotMinButton.Click += new System.EventHandler(this.setPotMinButton_Click);
            // 
            // setPotMax
            // 
            this.setPotMax.Location = new System.Drawing.Point(33, 1084);
            this.setPotMax.Name = "setPotMax";
            this.setPotMax.Size = new System.Drawing.Size(263, 58);
            this.setPotMax.TabIndex = 29;
            this.setPotMax.Text = "SetPotMax";
            this.setPotMax.UseVisualStyleBackColor = true;
            this.setPotMax.Click += new System.EventHandler(this.setPotMax_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 1034);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 32);
            this.label10.TabIndex = 30;
            this.label10.Text = "PotMin:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(303, 1098);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 32);
            this.label11.TabIndex = 31;
            this.label11.Text = "PotMax:";
            // 
            // potMinLabel
            // 
            this.potMinLabel.AutoSize = true;
            this.potMinLabel.Location = new System.Drawing.Point(421, 1034);
            this.potMinLabel.Name = "potMinLabel";
            this.potMinLabel.Size = new System.Drawing.Size(31, 32);
            this.potMinLabel.TabIndex = 32;
            this.potMinLabel.Text = "0";
            // 
            // potMaxLabel
            // 
            this.potMaxLabel.AutoSize = true;
            this.potMaxLabel.Location = new System.Drawing.Point(428, 1098);
            this.potMaxLabel.Name = "potMaxLabel";
            this.potMaxLabel.Size = new System.Drawing.Size(63, 32);
            this.potMaxLabel.TabIndex = 33;
            this.potMaxLabel.Text = "100";
            // 
            // proportionalGainNumSelector
            // 
            this.proportionalGainNumSelector.DecimalPlaces = 2;
            this.proportionalGainNumSelector.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.proportionalGainNumSelector.Location = new System.Drawing.Point(1076, 881);
            this.proportionalGainNumSelector.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.proportionalGainNumSelector.Name = "proportionalGainNumSelector";
            this.proportionalGainNumSelector.Size = new System.Drawing.Size(120, 38);
            this.proportionalGainNumSelector.TabIndex = 23;
            this.proportionalGainNumSelector.ValueChanged += new System.EventHandler(this.proportionalGainNumSelector_ValueChanged);
            // 
            // ActivateThrottleMotorCheckbox
            // 
            this.ActivateThrottleMotorCheckbox.AutoSize = true;
            this.ActivateThrottleMotorCheckbox.Location = new System.Drawing.Point(1025, 936);
            this.ActivateThrottleMotorCheckbox.Name = "ActivateThrottleMotorCheckbox";
            this.ActivateThrottleMotorCheckbox.Size = new System.Drawing.Size(324, 36);
            this.ActivateThrottleMotorCheckbox.TabIndex = 34;
            this.ActivateThrottleMotorCheckbox.Text = "ActivateThrottleMotor";
            this.ActivateThrottleMotorCheckbox.UseVisualStyleBackColor = true;
            this.ActivateThrottleMotorCheckbox.CheckedChanged += new System.EventHandler(this.ActivateThrottleMotorCheckbox_CheckedChanged_1);
            // 
            // throttlePosSlider
            // 
            this.throttlePosSlider.Location = new System.Drawing.Point(33, 1148);
            this.throttlePosSlider.Maximum = 100;
            this.throttlePosSlider.Name = "throttlePosSlider";
            this.throttlePosSlider.Size = new System.Drawing.Size(413, 114);
            this.throttlePosSlider.TabIndex = 35;
            this.throttlePosSlider.TickFrequency = 10;
            this.throttlePosSlider.Scroll += new System.EventHandler(this.throttlePosSlider_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 1206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 32);
            this.label12.TabIndex = 36;
            this.label12.Text = "ThrottlePosition:";
            // 
            // throttlePosLabel
            // 
            this.throttlePosLabel.AutoSize = true;
            this.throttlePosLabel.Location = new System.Drawing.Point(297, 1206);
            this.throttlePosLabel.Name = "throttlePosLabel";
            this.throttlePosLabel.Size = new System.Drawing.Size(31, 32);
            this.throttlePosLabel.TabIndex = 37;
            this.throttlePosLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2507, 1354);
            this.Controls.Add(this.throttlePosLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.throttlePosSlider);
            this.Controls.Add(this.ActivateThrottleMotorCheckbox);
            this.Controls.Add(this.potMaxLabel);
            this.Controls.Add(this.potMinLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.setPotMax);
            this.Controls.Add(this.setPotMinButton);
            this.Controls.Add(this.movingAverageSizeNumSelector);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.targetLoadNumSelector);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.proportionalGainNumSelector);
            this.Controls.Add(this.sumOfPIDLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ActivateMotorCheckbox);
            this.Controls.Add(this.loadCellSetScaleLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loadCellSetScaleButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadCellTareLabel);
            this.Controls.Add(this.loadCellTareButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.targetLoadLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setTargetLoadButton);
            this.Controls.Add(this.timespanLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxPointsSlider);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.RawVoltageRatioLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPointsSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetLoadNumSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingAverageSizeNumSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proportionalGainNumSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttlePosSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RawVoltageRatioLabel;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataGraph;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar maxPointsSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timespanLabel;
        private System.Windows.Forms.Button setTargetLoadButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label targetLoadLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadCellTareButton;
        private System.Windows.Forms.Label loadCellTareLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadCellSetScaleButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label loadCellSetScaleLabel;
        private System.Windows.Forms.CheckBox ActivateMotorCheckbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sumOfPIDLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown targetLoadNumSelector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown movingAverageSizeNumSelector;
        private System.Windows.Forms.Button setPotMinButton;
        private System.Windows.Forms.Button setPotMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label potMinLabel;
        private System.Windows.Forms.Label potMaxLabel;
        private System.Windows.Forms.NumericUpDown proportionalGainNumSelector;
        private System.Windows.Forms.CheckBox ActivateThrottleMotorCheckbox;
        private System.Windows.Forms.TrackBar throttlePosSlider;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label throttlePosLabel;
    }
}

