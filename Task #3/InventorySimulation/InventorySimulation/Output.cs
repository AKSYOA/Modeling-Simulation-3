using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryModels;
namespace InventorySimulation
{
    public partial class Output : Form
    {
        SimulationSystem system;
        public Output(SimulationSystem system)
        {
            InitializeComponent();
            this.system = system;
        }

        private void outputDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Output_Load(object sender, EventArgs e)
        {
            outputDataGridView.Rows.Clear();
            foreach (SimulationCase oneCase in system.SimulationTable) {

                int Day = oneCase.Day;
                int Cycle = oneCase.Cycle;
                int DayWithin = oneCase.DayWithinCycle;
                int Begining = oneCase.BeginningInventory;
                int RandomDemand = oneCase.RandomDemand;
                int Demand = oneCase.Demand;
                int End = oneCase.EndingInventory;
                int Shortage = oneCase.ShortageQuantity;
                int OrderQuantity = oneCase.OrderQuantity;
                int RandomLead = oneCase.RandomLeadDays;
                int LeadTime = oneCase.LeadDays;
                outputDataGridView.Rows.Add(Day,Cycle,DayWithin,Begining,RandomDemand,Demand,End,Shortage,
                    OrderQuantity,RandomLead,LeadTime);
            }
            AvergaeEnding.Text = system.PerformanceMeasures.EndingInventoryAverage.ToString();
            AvergaeShortage.Text = system.PerformanceMeasures.ShortageQuantityAverage.ToString();


        }
    }
}
