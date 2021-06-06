using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairManagementSystem
{
    class Repair
    {
        //properties of Repair class
        private string id;
        private string inventoryId;
        private string whatToRepair;

        public string Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public string InventoryId
        {
            get { return inventoryId; }
            set { this.inventoryId = value; }
        }

        public string WhatToRepair
        {
            get { return whatToRepair; }
            set { this.whatToRepair = value; }
        }

        //No-argument constructor
        public Repair() { }

        //Parameterized constructor
        public Repair(string id, string inventoryId, string whatToRepair)
        {
            Id = id;
            InventoryId = inventoryId;
            WhatToRepair = whatToRepair;
        }


    }
}
