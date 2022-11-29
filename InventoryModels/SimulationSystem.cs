using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }

        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
        SimulationCase oneCase;
        private Random random;

        public void calculateCummProbability() {

            for (int i = 0; i < DemandDistribution.Count; i++)
            {
                if (i == 0)
                {
                    DemandDistribution[i].CummProbability = DemandDistribution[i].Probability;
                    LeadDaysDistribution[i].CummProbability = DemandDistribution[i].Probability;
                }
                else {
                    DemandDistribution[i].CummProbability = DemandDistribution[i-1].Probability+ DemandDistribution[i].Probability;
                    LeadDaysDistribution[i].CummProbability = LeadDaysDistribution[i - 1].Probability + LeadDaysDistribution[i].Probability; 
                }
            }
        }
        public void createTableUsingCustomersNo()
        {
            int Cycle = 1;
            int DayWithinCycle = 0;

            for (int Day = 1; Day <= NumberOfDays; Day++)
            {
                DayWithinCycle++;
                if (Day % ReviewPeriod == 0)//begining of cycle
                {
                    Cycle++;
                    oneCase.OrderQuantity = OrderUpTo - oneCase.EndingInventory + oneCase.ShortageQuantity;
                    oneCase.RandomLeadDays = random.Next(1, 100);
                    oneCase.LeadDays = LeadDest(oneCase);//need RandomLeadDays
                }
                else if (Day - 1 % ReviewPeriod == 0) //if it is the first step in the cycle
                {
                    DayWithinCycle = 1;
                    oneCase.OrderQuantity = 0;
                }
                else {
                    oneCase.OrderQuantity = 0;
                }

                oneCase = new SimulationCase();
                if (Day == 1)
                {
                    oneCase.BeginningInventory = StartInventoryQuantity;
                }
                else {
                    oneCase.BeginningInventory = SimulationTable[SimulationTable.Count - 1].EndingInventory;
                }
                if (StartLeadDays+1 == Day) //add start order
                {
                    oneCase.BeginningInventory += StartOrderQuantity;
                }
                
                oneCase.Day = Day;
                oneCase.Cycle = Cycle;
                oneCase.DayWithinCycle = DayWithinCycle;
                oneCase.RandomDemand = random.Next(1, 100);
                oneCase.Demand = demandDest(oneCase);
                if (oneCase.BeginningInventory >= oneCase.Demand)//get endingInventory and shortage Values
                {
                    oneCase.EndingInventory = oneCase.BeginningInventory - oneCase.Demand;
                    oneCase.ShortageQuantity = 0;
                }
                else {
                    oneCase.EndingInventory = 0;
                    oneCase.ShortageQuantity = oneCase.Demand - oneCase.ShortageQuantity;
                }


            }
        }
        public int demandDest(SimulationCase oneCase)
        {
                
            for (int i = 0; i < DemandDistribution.Count; i++)
            {
                if (oneCase.RandomDemand <= DemandDistribution[i].MaxRange &&
                    oneCase.RandomDemand >= DemandDistribution[i].MinRange)
                    return DemandDistribution[i].Value;
            }
            return 0;
        }
        public int LeadDest(SimulationCase oneCase)
        {

            for (int i = 0; i < LeadDaysDistribution.Count; i++)
            {
                if (oneCase.RandomLeadDays <= LeadDaysDistribution[i].MaxRange &&
                    oneCase.RandomLeadDays >= LeadDaysDistribution[i].MinRange)
                    return LeadDaysDistribution[i].Value;
            }
            return 0;
        }





    }
}
