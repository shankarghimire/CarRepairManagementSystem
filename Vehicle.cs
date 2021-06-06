using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairManagementSystem
{
    class Vehicle
    {
        //Properties of Vehicle class
        private string id;
        private string make;
        private string model;
        private int year;
        private VehicleStatus vehicleStatus;

        public String Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public string Make
        {
            get { return make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return year; }
            set { this.year = value; }
        }

        public VehicleStatus VehicleStatus
        {
            get { return vehicleStatus; }
            set { this.vehicleStatus = value; }
        }

        //No-Argument constructor
        public Vehicle() { }

        //Parameterized constructor
        public Vehicle(string id, string make, string model, int year, VehicleStatus vehicleStatus)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            VehicleStatus = vehicleStatus;
        }

    }

    internal enum VehicleStatus
    {
        New,
        Used
    }
}
