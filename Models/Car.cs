using System;
using System.Collections.Generic;
using System.Text;

namespace classes.Models
{
    public class Car
    {
        public string color;
        public ushort doorCount;
        public ushort seatCount;
        public ushort wheelCount;
        public double engineCapacity;
        public Car(string color)
        {
            this.color = color;
        }
        
        public Car(string color, ushort doorCount) : this(color)
        {
            this.doorCount = doorCount;
        }
        public Car(string color, ushort doorCount, ushort seatCount) : this(color, doorCount)
        {
            this.seatCount = seatCount;
        }
        public Car(string color, ushort doorCount, ushort seatCount, ushort wheelCount): this(color, doorCount, seatCount)
        {
            this.wheelCount = wheelCount;
        }
        public Car(string color, ushort doorCount, ushort seatCount, ushort wheelCount, double engineCapacity) : this(color, doorCount, seatCount, wheelCount)
        {
            this.engineCapacity = engineCapacity;
        } 
        public void GetCarInfo()
        {
            Console.Clear();
            Console.WriteLine("Color: " + this.color + "\n" + "The number of doors: " + this.doorCount + "\n" + "The number of seats: " + this.seatCount + "\n" + "The number of wheels: " + this.wheelCount + "\n" + "Engine capacity: " + this.engineCapacity);
        }
    }
}
