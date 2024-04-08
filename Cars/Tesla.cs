using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery) 
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        void ICar.Start()
        {
            throw new NotImplementedException();
        }

        void ICar.Stop()
        {
            throw new NotImplementedException();
        }

        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Break!";
        }

        public override string ToString()
        {
            return $"{Color} Seat {Model}{Environment.NewLine}" +
                $"{Start()}{Environment.NewLine}" +
                $"{Stop()}";
        }

    }
}
