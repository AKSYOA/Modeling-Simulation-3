﻿using System;
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
            random=new Random();
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


        public void Simulate() {
            calculateCummProbability();
            createTableUsingCustomersNo();
            AveragePerformance();
        }



        public void calculateCummProbability() {

            for (int i = 0; i < DemandDistribution.Count; i++)
            {
                if (i == 0)
                {
                    DemandDistribution[i].CummProbability = DemandDistribution[i].Probability;
                    DemandDistribution[i].MinRange = 1;

                }
                else {
                    DemandDistribution[i].CummProbability = DemandDistribution[i-1].Probability+ DemandDistribution[i].Probability;
                    DemandDistribution[i].MinRange = DemandDistribution[i-1].MaxRange;


                }
                DemandDistribution[i].MaxRange = Decimal.ToInt32(DemandDistribution[i].CummProbability*100);

            }
            for (int i = 0; i < LeadDaysDistribution.Count; i++)
            {
                if (i == 0)
                {
                    LeadDaysDistribution[i].CummProbability = DemandDistribution[i].Probability;
                    LeadDaysDistribution[i].MinRange = 1;
                }
                else
                {
                    LeadDaysDistribution[i].CummProbability = LeadDaysDistribution[i - 1].Probability + LeadDaysDistribution[i].Probability;
                    LeadDaysDistribution[i].MinRange = LeadDaysDistribution[i - 1].MaxRange;
                }
                LeadDaysDistribution[i].MaxRange = Decimal.ToInt32(LeadDaysDistribution[i].CummProbability * 100);

            }
        }
        public void createTableUsingCustomersNo()
        {
            int Cycle = 0;
            int DayWithinCycle = 0;
            int index = 0;
            int LeadQuantity = 0;
            for (int Day = 1; Day <= NumberOfDays; Day++)
            {
                oneCase = new SimulationCase();
                DayWithinCycle++;
                if (Day == 1)
                {
                    oneCase.BeginningInventory = StartInventoryQuantity;
                }    
                else
                {
                    oneCase.BeginningInventory = SimulationTable[SimulationTable.Count - 1].EndingInventory;             
                }
                if (Day == index)
                {
                    oneCase.BeginningInventory += LeadQuantity;
                    LeadQuantity = 0;
                    index = new int();
                }
                if (StartLeadDays + 1 == Day) //add start order
                {
                    oneCase.BeginningInventory += StartOrderQuantity;
                }

                oneCase.RandomDemand = random.Next(1, 100);
                oneCase.Demand = demandDest(oneCase);

                if (oneCase.BeginningInventory >= oneCase.Demand)//get endingInventory and shortage Values
                {
                    oneCase.EndingInventory = oneCase.BeginningInventory - oneCase.Demand;
                    oneCase.ShortageQuantity = 0;
                }
                else
                {
                    oneCase.EndingInventory = 0;
                    oneCase.ShortageQuantity = oneCase.Demand - oneCase.BeginningInventory;
                }

                if (Day % ReviewPeriod == 0)//begining of cycle
                { 
                    oneCase.Day = Day;
                    oneCase.OrderQuantity = OrderUpTo - oneCase.EndingInventory + oneCase.ShortageQuantity;
                    oneCase.RandomLeadDays = random.Next(1, 100);
                    oneCase.LeadDays = LeadDest(oneCase);//need RandomLeadDays
                    index = Day + oneCase.LeadDays;
                    LeadQuantity = oneCase.OrderQuantity;
                }
                else if ((Day - 1) % ReviewPeriod == 0) //if it is the first step in the cycle
                {
                    Cycle++;

                    DayWithinCycle = 1;
                    oneCase.OrderQuantity = 0;
                    oneCase.RandomLeadDays = 0;
                    oneCase.LeadDays = 0;
                }
               
             
                oneCase.Day = Day;
                oneCase.Cycle = Cycle;
                oneCase.DayWithinCycle = DayWithinCycle;
             
                SimulationTable.Add(oneCase);
            }

        }
        public int demandDest(SimulationCase oneCase)
        {
                
            for (int i = 0; i < DemandDistribution.Count; i++)
            {
                if (oneCase.RandomDemand <= DemandDistribution[i].MaxRange &&
                    oneCase.RandomDemand > DemandDistribution[i].MinRange)
                    return DemandDistribution[i].Value;
            }
            return 0;
        }
        public int LeadDest(SimulationCase oneCase)
        {

            for (int i = 0; i < LeadDaysDistribution.Count; i++)
            {
                if (oneCase.RandomLeadDays <= LeadDaysDistribution[i].MaxRange &&
                    oneCase.RandomLeadDays > LeadDaysDistribution[i].MinRange)
                    return LeadDaysDistribution[i].Value;
            }
            return 0;
        }
        public void AveragePerformance() {
          int aveEnding = 0;
           int aveShort = 0;
        foreach(SimulationCase oneCase  in SimulationTable){
                aveEnding += oneCase.EndingInventory;
                aveShort += oneCase.ShortageQuantity;
            }
            aveEnding /= SimulationTable.Count;
            aveEnding /= SimulationTable.Count;
            this.PerformanceMeasures.EndingInventoryAverage = aveEnding;
            this.PerformanceMeasures.ShortageQuantityAverage = aveShort;
        }
    }
}