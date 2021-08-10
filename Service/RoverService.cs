using MarsRover.Models;
using System;

namespace MarsRover.Service
{
    public class RoverService
    {
        int[] zone = new int[2];
        public int[] readZone()
        {            
            bool inputRight = false;

            while (!inputRight)
            {
                Console.WriteLine("Insert position or : (number number)");
                try
                {
                    string[] read = Console.ReadLine().Split(" ");
                    zone[0] = int.Parse(read[0]);
                    zone[1] = int.Parse(read[1]);
                    inputRight = true;
                }
                catch (Exception) { }

            }

            return zone;
        }

        public int[] readRover()
        {
            bool inputRight = false;
            
            while (!inputRight)
            {
                Console.WriteLine("Insert position of Rover : (number number direction)");
                try
                {
                    string[] read = Console.ReadLine().Split(" ");
                    zone[0] = int.Parse(read[0]);
                    zone[1] = int.Parse(read[1]);
                    inputRight = true;
                }
                catch (Exception) { }

            }

            return zone;
        }
    }
}
