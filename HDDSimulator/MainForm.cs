using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HDDSimulator;
using System.Windows.Forms.DataVisualization.Charting;

namespace HDDSimulator
{
    public partial class MainForm : Form
    {
        Simulator.simulationMode simulationMode = Simulator.simulationMode.FCFS;
        Simulator.RTRServiceModes RTRmode = Simulator.RTRServiceModes.EDF;
        Simulator simulator;
        List<Request> requests;

        public MainForm()
        {
            InitializeComponent();
           

            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            simulator = null;
            requests = new List<Request>();
            driveSizeInput.Value = 500;
            requestsNuberInput.Value = 25;
            chanceOfRTRInput.Value = 25;
           
            maxAppearTimeInput.Value = 10000;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private  void StartBtn_Click(object sender, EventArgs e)
        {

            
            Drive drive = new Drive((int)driveSizeInput.Value, (int)driveSizeInput.Value);
            
             
            simulator = new Simulator(drive, requests, simulationMode, RTRmode);
            

            simulator.Simulate();
             
            totalHeadMovementOutput.Text = drive.GetTotalMovement().ToString();

            bool RTR = false ;
            if (Simulator.GetRealTimeReuqestsCount(requests) > 0) RTR = true;

            chart1.Series["Series1"].Points.AddXY(simulator.GetModeName(RTR), drive.GetTotalMovement());
            
            misssedDeadlinesOutput.Text = simulator.GetMissedDeadlinesCount().ToString();
            
            ResetRequests();
        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            RequestGenerator generator = new RequestGenerator((int)requestsNuberInput.Value, (int)chanceOfRTRInput.Value, (int)driveSizeInput.Value, (int)maxAppearTimeInput.Value, (int)maxDeadlineInput.Value, (int)minDeadlineInput.Value);
            requests = generator.GetRequests();
            UpdateRequestData();
        }

        private void UpdateRequestData()
        {
            totalRequestCountoutput.Text = requests.Count.ToString();
            requestsCountOutput.Text = Simulator.GetNonRealtimeCount(requests).ToString();
            realtimeCountOutput.Text = Simulator.GetRealTimeReuqestsCount(requests).ToString();
        }
        private void ResetRequests()
        {
            foreach(Request req in requests)
            {
                req.SetRequestState(Request.requestState.INVISIBLE);
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            simulationMode = Simulator.simulationMode.FCFS;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            simulationMode = Simulator.simulationMode.SSTF;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            simulationMode = Simulator.simulationMode.SCAN;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            simulationMode = Simulator.simulationMode.CSCAN;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            RTRmode = Simulator.RTRServiceModes.EDF;
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            RTRmode = Simulator.RTRServiceModes.FDSCAN;
        }

        private void driveSizeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxAppearTimeInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chooseInputMethod_CheckedChanged(object sender, EventArgs e)
        {
            if (chooseInputMethod.Checked)
            {
                groupParameters.Enabled = false;
                filenameInput.Enabled = true;
                readFileBtn.Enabled = true;
            }
            else
            {
                groupParameters.Enabled = true;
                filenameInput.Enabled = false;
                readFileBtn.Enabled = false;
            }
        }
        private void writeDataToFileBtn_Click(object sender, EventArgs e)
        {
            if(outputFilenameInput.Text != null)
            {
                FileHandler fileHandler = new FileHandler();
                fileHandler.WriteFile(requests, outputFilenameInput.Text);
            }
            
        }

        private void totalHeadMovementOutput_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void maxDeadlineInput_ValueChanged(object sender, EventArgs e)
        {
            if (maxDeadlineInput.Value <= minDeadlineInput.Value)
            {
                maxDeadlineInput.Value = minDeadlineInput.Value;
                //maxDeadlineInput.Value++;
            }
        }

        private void minDeadlineInput_ValueChanged(object sender, EventArgs e)
        {
            if (minDeadlineInput.Value >= maxDeadlineInput.Value)
            {
                minDeadlineInput.Value = maxDeadlineInput.Value;
                //minDeadlineInput.Value--;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {
            requests = new FileHandler().ReadFile(filenameInput.Text);
            UpdateRequestData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String filename =  null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }
            requests = new FileHandler().ReadFile(filename);
            UpdateRequestData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Remove(chart1.Series["Series1"]);
            Series series1 = new Series();
            series1.Name = "Series1";
            chart1.Series.Add(series1);
        }
        
    }
}
