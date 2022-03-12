using classes.Models;
using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the color of the car if you dont know type '0' : ");
            string color = Console.ReadLine();
            ushort doorCount;
        DoorTry:
            Console.Write("Write the number of doors if you dont know type '0' : ");
            try
            {
                doorCount = Convert.ToUInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("It's not possible please try again");
                goto DoorTry;
            }
            ushort seatCount;
        SeatTry:
            Console.Write("Write the number of seats if you dont know type '0' : ");
            try
            {
                seatCount = Convert.ToUInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("It's not possible please try again");
                goto SeatTry;
            }
            ushort wheelCount;
        WheelTry:
            Console.Write("Write the number of wheels if you dont know type '0' : ");
            try
            {
                wheelCount = Convert.ToUInt16(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("It's not possible please try again");
                goto WheelTry;
            }
            double engineCapacity;
        EngineCapacityTry:
            Console.Write("Write engine capacity if you dont know type '0' : ");
            try
            {
            engineCapacity = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("It's not possible please try again");
                goto EngineCapacityTry;
            }
            switch (color)
            {
                case "0":
                    Console.WriteLine("You don't have enough information");
                    break;
                default:
                    switch (doorCount)
                    {
                        case 0:
                            Car car1 = new Car(color);
                            car1.GetCarInfo();
                            break;
                        default:
                            switch (seatCount)
                            {
                                case 0:
                                    Car car2 = new Car(color, doorCount);
                                    car2.GetCarInfo();
                                    break;
                                default:
                                    switch (wheelCount)
                                    {
                                        case 0:
                                            Car car3 = new Car(color, doorCount, seatCount);
                                            car3.GetCarInfo();
                                            break;
                                        default:
                                            switch (engineCapacity)
                                            {
                                                case 0:
                                                    Car car4 = new Car(color, doorCount, seatCount, wheelCount);
                                                    car4.GetCarInfo();
                                                    break;
                                                default:
                                                    Car car5 = new Car(color, doorCount, seatCount, wheelCount, engineCapacity);
                                                    car5.GetCarInfo();
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
