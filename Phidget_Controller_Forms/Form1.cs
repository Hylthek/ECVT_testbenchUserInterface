using System; //git testing comment here :)
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using System.Diagnostics;

namespace Phidget_Controller_Forms {
    public partial class Form1 : Form {
        //Phidgets
        VoltageRatioInput loadCell;
        DigitalOutput brakeMotorPWM;
        DigitalOutput brakeMotorDirection;
        VoltageInput throttlePot;
        DigitalOutput throttleMotorPWM;
        DigitalOutput throttleMotorDirection;
        //chart stuff
        Stopwatch graphTimeMillis;
        int chartLength = 5; //horz. length of chart in sec (for most series)
        //Phidget control stuff
        double loadCellOffset = -0.00002216; //NOTE: offset is added before scaling is multiplied
        double loadCellScale = -44353;
        double proportionalGain = 0.5;
        double potMin = -0.3669; //potOffset
        double potMax = 0.1966; //potScale
        double throttleProportionalGain = 5;
        //loadCell moving average stuff
        Queue<double> loadCellMovingAverageQueue;
        int loadCellMovingAverageQueueSize = 100; //points on the graph (moving average)
        public Form1() {
            InitializeComponent();
            //instantiate stopwatch
            graphTimeMillis = new Stopwatch();
            graphTimeMillis.Start();
            //instantiate moving average queue
            loadCellMovingAverageQueue = new Queue<double>();
            //instantiate phidgets
            loadCell = new VoltageRatioInput();
            brakeMotorPWM = new DigitalOutput();
            brakeMotorDirection = new DigitalOutput();
            throttlePot = new VoltageInput();
            throttleMotorPWM = new DigitalOutput();
            throttleMotorDirection = new DigitalOutput();
            //adress loadcell/brakemotor objects
            loadCell.DeviceSerialNumber = 686546;
            brakeMotorPWM.DeviceSerialNumber = 686546;
            brakeMotorDirection.DeviceSerialNumber = 686546;
            loadCell.HubPort = 0;
            brakeMotorPWM.HubPort = 1;
            brakeMotorDirection.HubPort = 2;
            loadCell.Channel = 0;
            brakeMotorPWM.IsHubPortDevice = true;
            brakeMotorDirection.IsHubPortDevice = true;
            //adress throttlepot/throttlemotor objects
            throttlePot.DeviceSerialNumber = 686546;
            throttleMotorPWM.DeviceSerialNumber = 686546;
            throttleMotorDirection.DeviceSerialNumber = 686546;
            throttlePot.HubPort = 3;
            throttleMotorPWM.HubPort = 4;
            throttleMotorDirection.HubPort = 5;
            throttlePot.IsHubPortDevice = true;
            throttleMotorPWM.IsHubPortDevice = true;
            throttleMotorDirection.IsHubPortDevice = true;
            //assign handlers
            loadCell.VoltageRatioChange += loadCell_VoltageRatioChange_Handler;
            throttlePot.VoltageChange += pot_VoltageChange_Handler;
            //open & extra setup
            string setupErrorMessage = "";
            try {
                loadCell.Open(Phidget.DefaultTimeout);
                loadCell.DataInterval = 20; //milliseconds
                loadCell.BridgeGain = Phidget22.BridgeGain.Gain_128x;
            }
            catch (Exception e) { setupErrorMessage += "   \"loadCell\" object:\n" + e.Message + "\n\n"; }
            try {
                brakeMotorPWM.Open(Phidget.DefaultTimeout);
                brakeMotorPWM.DutyCycle = 0;
            }
            catch (Exception e) { setupErrorMessage += "   \"brakeMotorPWM\" object:\n" + e.Message + "\n\n"; }
            try {
                brakeMotorDirection.Open(Phidget.DefaultTimeout);
                brakeMotorDirection.State = false;
            }
            catch (Exception e) { setupErrorMessage += "   \"brakeMotorDirection\" object:\n" + e.Message + "\n\n"; }
            try {
                throttlePot.Open(Phidget.DefaultTimeout);
            }
            catch (Exception e) { setupErrorMessage += "   \"throttlePot\" object:\n" + e.Message + "\n\n"; }
            try {
                throttleMotorPWM.Open(Phidget.DefaultTimeout);
                throttleMotorPWM.State = false;
            }
            catch (Exception e) { setupErrorMessage += "   \"throttleMotorPWM\" object:\n" + e.Message + "\n\n"; }
            try {
                throttleMotorDirection.Open(Phidget.DefaultTimeout);
                throttleMotorDirection.State = false;
            }
            catch (Exception e) { setupErrorMessage += "   \"throttleMotorDirection\" object:\n" + e.Message + "\n\n"; }
            if (setupErrorMessage == "")
                setupErrorMessage = "No errors.";
            MessageBox.Show(setupErrorMessage);
            //set dynamically-set labels
            loadCellTareLabel.Text = "" + loadCellOffset;
            loadCellSetScaleLabel.Text = "" + loadCellScale;
            proportionalGainNumSelector.Value = (decimal)proportionalGain;
            movingAverageSizeNumSelector.Value = loadCellMovingAverageQueueSize;
            potMinLabel.Text = "" + potMin;
            potMaxLabel.Text = "" + potMax;
            //end of setup, create window
        }

        public void loadCell_VoltageRatioChange_Handler(object sender, Phidget22.Events.VoltageRatioInputVoltageRatioChangeEventArgs e) {
            //initialize var(s)
            double processedLoadCellVoltageRatio = loadCellScale * (loadCell.VoltageRatio + loadCellOffset);
            //update rawVoltageLabel
            RawVoltageRatioLabel.Text = loadCell.VoltageRatio.ToString();
            //plot raw voltage and processed voltage
            dataGraph.Series[0].Points.AddXY(graphTimeMillis.ElapsedMilliseconds / 1000.0, loadCell.VoltageRatio);
            dataGraph.Series[1].Points.AddXY(graphTimeMillis.ElapsedMilliseconds / 1000.0, processedLoadCellVoltageRatio);
            //Enqueue and Dequeue loadCellMovingAverageQueue
            loadCellMovingAverageQueue.Enqueue(processedLoadCellVoltageRatio);
            if (loadCellMovingAverageQueue.Count > loadCellMovingAverageQueueSize)
                for (int i = 0; i < loadCellMovingAverageQueue.Count - loadCellMovingAverageQueueSize; i++)
                    loadCellMovingAverageQueue.Dequeue();
            //calculate moving average
            double movingAverageValue = 0;
            foreach (double element in loadCellMovingAverageQueue)
                movingAverageValue += element;
            movingAverageValue /= loadCellMovingAverageQueueSize;
            //plot moving average value and indicator
            dataGraph.Series[3].Points.AddXY
                (graphTimeMillis.ElapsedMilliseconds / 1000.0, movingAverageValue); //(x,y)
            dataGraph.Series[4].Points.AddXY
                (graphTimeMillis.ElapsedMilliseconds / 1000.0, processedLoadCellVoltageRatio, 50); //(x,y,percentSize)
            //limit data points to size (some are sized to chartLength, one is sized to loadCellMovingAverageQueueSize)
            try {
                while (graphTimeMillis.ElapsedMilliseconds / 1000.0 - dataGraph.Series[0].Points.ElementAt(0).XValue > chartLength)
                dataGraph.Series[0].Points.RemoveAt(0);
            }
            catch { }
            try {
                while (graphTimeMillis.ElapsedMilliseconds / 1000.0 - dataGraph.Series[1].Points.ElementAt(0).XValue > chartLength)
                    dataGraph.Series[1].Points.RemoveAt(0);
            }
            catch { }
            try {
                while (graphTimeMillis.ElapsedMilliseconds / 1000.0 - dataGraph.Series[2].Points.ElementAt(0).XValue > chartLength)
                    dataGraph.Series[2].Points.RemoveAt(0);
            }
            catch { }
            try {
                while (graphTimeMillis.ElapsedMilliseconds / 1000.0 - dataGraph.Series[3].Points.ElementAt(0).XValue > chartLength)
                    dataGraph.Series[3].Points.RemoveAt(0);
            }
            catch { }
            try {
                while (dataGraph.Series[4].Points.Count > loadCellMovingAverageQueueSize)
                    for(int i = 0; i < dataGraph.Series[4].Points.Count - loadCellMovingAverageQueueSize; i++)
                        dataGraph.Series[4].Points.RemoveAt(0);
            }
            catch { }
            dataGraph.ResetAutoValues();
            //check if motor is activated
            if (ActivateMotorCheckbox.Checked == true) {
                try {
                    //calculate control error and control signal
                    double brakeLoadError = double.Parse(targetLoadLabel.Text)        //formated so that a positive-
                        - movingAverageValue; //error means more braking
                    double sumOfPID = brakeLoadError * proportionalGain;
                    if (sumOfPID > 1)
                        sumOfPID = 1;
                    if (sumOfPID < -1)
                        sumOfPID = -1;
                    //actuate motor
                    if (sumOfPID > 0)
                        brakeMotorDirection.State = true;
                    else
                        brakeMotorDirection.State = false;
                    brakeMotorPWM.DutyCycle = Math.Abs(sumOfPID);
                    //update display data
                    sumOfPIDLabel.Text = "" + sumOfPID;
                    dataGraph.Series[2].Points.AddXY(graphTimeMillis.ElapsedMilliseconds / 1000.0, sumOfPID);
                }
                catch (Exception e2) {
                    MessageBox.Show(e2.Message);
                    ActivateMotorCheckbox.Checked = false;
                }
            }
            //end of loadCell_VoltageRatioChange_Handler
        }
        private void pot_VoltageChange_Handler(object sender, Phidget22.Events.VoltageInputVoltageChangeEventArgs e) {
            //initialize var(s)
            double processedPotVoltage = potMax * (throttlePot.Voltage + potMin);
            //plot point
            dataGraph.Series[5].Points.AddXY(graphTimeMillis.ElapsedMilliseconds / 1000.0, processedPotVoltage);
            //remove point(s)
            while (graphTimeMillis.ElapsedMilliseconds / 1000.0 - dataGraph.Series["ThrottlePosition"].Points.ElementAt(0).XValue > chartLength - 1) //chart length subtracted by one to avoid jittering
                dataGraph.Series[5].Points.RemoveAt(0);
            dataGraph.ResetAutoValues();
            //check if throttle motor is activated
            if ((ActivateThrottleMotorCheckbox.Checked) == true) {
                try {
                    //calculate control error and control signal
                    double motorPosError = double.Parse(throttlePosLabel.Text) / 100        //formated so that a positive-
                        - processedPotVoltage; //error means more
                    double sumOfPID = motorPosError * throttleProportionalGain;
                    if (sumOfPID > 1)
                        sumOfPID = 1;
                    if (sumOfPID < -1)
                        sumOfPID = -1;
                    //actuate motor
                    if (sumOfPID > 0)
                        throttleMotorDirection.State = true;
                    else
                        throttleMotorDirection.State = false;
                    throttleMotorPWM.DutyCycle = Math.Abs(sumOfPID);
                }
                catch (Exception e2) {
                    MessageBox.Show(e2.Message);
                    ActivateThrottleMotorCheckbox.Checked = false;
                }
            }
        } //end of Pot_VoltageChange_Handler
        private void maxPointsSlider_Scroll(object sender, EventArgs e) {
            chartLength = maxPointsSlider.Value;
            timespanLabel.Text = "" + chartLength + " sec";
        }
        private void setTargetLoadButton_Click(object sender, EventArgs e) {
            targetLoadLabel.Text = "" + targetLoadNumSelector.Value;
        }
        private void loadCellTareButton_Click(object sender, EventArgs e) {
            try {
                loadCellOffset = -1 * loadCell.VoltageRatio;
                loadCellTareLabel.Text = "" + loadCellOffset + " v/v";
            }
            catch {
                loadCellTareLabel.Text = "ERROR";
            }
        }
        private void loadCellSetScaleButton_Click(object sender, EventArgs e) {
            try {
                loadCellScale = 1 / (loadCell.VoltageRatio + loadCellOffset);
                loadCellSetScaleLabel.Text = "" + loadCellScale + " mult.";
            }
            catch {
                loadCellSetScaleLabel.Text = "ERROR";
            }

        }
        private void ActivateMotorCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (ActivateMotorCheckbox.Checked == false)
                try { brakeMotorPWM.DutyCycle = 0; } catch { }
        }
        private void ActivateThrottleMotorCheckbox_CheckedChanged_1(object sender, EventArgs e) {
            if (ActivateThrottleMotorCheckbox.Checked == false)
                try { throttleMotorPWM.DutyCycle = 0; } catch { }
        }
        private void proportionalGainNumSelector_ValueChanged(object sender, EventArgs e) {
            proportionalGain = (double)proportionalGainNumSelector.Value;
        }
        private void movingAverageSizeNumSelector_ValueChanged(object sender, EventArgs e) {
            loadCellMovingAverageQueueSize = (int)movingAverageSizeNumSelector.Value;
        }
        private void setPotMinButton_Click(object sender, EventArgs e) {
            try {
                potMin = -1 * throttlePot.Voltage;
                potMinLabel.Text = "" + potMin + " v";
            }
            catch {
                potMinLabel.Text = "ERROR";
            }
        }
        private void setPotMax_Click(object sender, EventArgs e) {
            try {
                potMax = 1 / throttlePot.Voltage;
                potMaxLabel.Text = "" + potMax + " v";
            }
            catch {
                potMaxLabel.Text = "ERROR";
            }
        }
        private void throttlePosSlider_Scroll(object sender, EventArgs e) {
            throttlePosLabel.Text = "" + throttlePosSlider.Value;
        }

    }
}