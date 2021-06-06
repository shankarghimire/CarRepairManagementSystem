using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairManagementSystem
{
    class Inventory
    {
        private string id;
        private string vehicleId;
        private int numberOnHand;
        private decimal price;
        private decimal cost;

        public string Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public string VehicleId
        {
            get { return vehicleId; }
            set { this.vehicleId = value; }
        }

        public int NumberOnHand
        {
            get { return numberOnHand; }
            set { this.numberOnHand = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { this.price = value; }
        }

        public decimal Cost
        {
            get { return cost; }
            set { this.cost = value; }
        }

        //No-argument constructor
        public Inventory() { }

        //Parameterized constructor
        public Inventory(string id, string vehicleId, int numberOnHand, decimal price, decimal cost)
        {
            Id = id;
            VehicleId = vehicleId;
            NumberOnHand = numberOnHand;
            Price = price;
            Cost = cost;
        }

        


    }
}
