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

        public SimulationSystem getSystem() {
            return system;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenTestCases = new OpenFileDialog();
            DialogResult fileResult = OpenTestCases.ShowDialog();
            if (fileResult == DialogResult.OK) {
                fileName = OpenTestCases.SafeFileName;
               system= fileHandler.ReadTestCase(fileName);
                Console.WriteLine(system.NumberOfDays);
                Console.WriteLine(system.LeadDaysDistribution[0]);



            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
