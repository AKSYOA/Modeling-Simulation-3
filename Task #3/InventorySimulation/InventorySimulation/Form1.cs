using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTesting;
using InventoryModels;
namespace InventorySimulation
{
    public partial class Form1 : Form
    {
        string fileName;
        fileHandler fileHandler = new fileHandler();
        SimulationSystem system;
        public Form1()
        {
            InitializeComponent();
        }

        public SimulationSystem getSystem()
        {
            return system;
        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

        private void Simulate_Click(object sender, EventArgs e)
        {
        }
      

        private void TestCases_Click_1(object sender, EventArgs e)
        {

            OpenTestCases = new OpenFileDialog();
            DialogResult fileResult = OpenTestCases.ShowDialog();
            if (fileResult == DialogResult.OK)
            {
                fileName = OpenTestCases.SafeFileName;
                system = fileHandler.ReadTestCase(OpenTestCases.FileName);


                OrderUpTo.Text = system.OrderUpTo.ToString();
                ReviewPeriod.Text = system.ReviewPeriod.ToString();
                StartInventoryQuantity.Text = system.StartInventoryQuantity.ToString();
                StartLeadDays.Text = system.StartLeadDays.ToString();
                StartOrderQuantity.Text = system.StartOrderQuantity.ToString();
                NumberOfDays.Text = system.NumberOfDays.ToString();

                DemandData.Rows.Clear();
                LeadData.Rows.Clear();
                for (int i = 0; i < system.DemandDistribution.Count; i++)
                {
                    int Value = system.DemandDistribution[i].Value;
                    decimal Probability = system.DemandDistribution[i].Probability;
                    DemandData.Rows.Add(Value, Probability);
                }
                for (int i = 0; i < system.LeadDaysDistribution.Count; i++)
                {
                    int Value = system.LeadDaysDistribution[i].Value;
                    decimal Probability = system.LeadDaysDistribution[i].Probability;
                    LeadData.Rows.Add(Value, Probability);
                }
            }
            }

        private void Simulate_Click_1(object sender, EventArgs e)
        {

            if (system != null)
            {
                system.Simulate();
                Output output = new Output(system);
                output.Show();
                string result = TestingManager.Test(system, fileName);
                MessageBox.Show(result);
            }
            else
                MessageBox.Show("Please Choose Test Case");



        }
    }
}
    
