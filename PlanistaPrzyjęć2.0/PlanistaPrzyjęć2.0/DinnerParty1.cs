using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty1
{
    public class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        public decimal CalculateCostOfDecorations()
        {
            decimal costOfDecarations;
            if(FancyDecorations)
            {
                costOfDecarations = (NumberOfPeople * 15.00M) + 50M;
            } else
            {
                costOfDecarations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecarations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if(HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            } else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;

        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
            if(HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }

        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations +
                ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
