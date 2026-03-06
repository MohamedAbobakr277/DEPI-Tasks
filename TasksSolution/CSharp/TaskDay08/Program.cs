using System;
using System.Collections.Generic;

namespace TaskDay08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part01
            public interface IVehicle
            {
                void StartEngine();
                void StopEngine();
            }

       
            public class Car : IVehicle
            {
                public void StartEngine()
                {
                    Console.WriteLine("Car: Engine started smoothly with a push-button.");
                }

                public void StopEngine()
                {
                    Console.WriteLine("Car: Engine shut down.");
                }
            }

        
            public class Bike : IVehicle
            {
                public void StartEngine()
                {
                    Console.WriteLine("Bike: Engine kicked into life with a roar.");
                }

                public void StopEngine()
                {
                    Console.WriteLine("Bike: Engine stopped.");
                }
            }

        
            class Prog
            {
                static void Main(string[] args)
                {
                    
                    List<IVehicle> myVehicles = new List<IVehicle>();

                    myVehicles.Add(new Car());
                    myVehicles.Add(new Bike());

                    foreach (var vehicle in myVehicles)
                    {
                        vehicle.StartEngine();
                    }

                    foreach (var vehicle in myVehicles)
                    {
                        vehicle.StopEngine();
                    }
                }
            }
        }

            #endregion
        }
    }
}
