using MarsRover.Models;
using MarsRover.Service;
using MarsRover.Util;
using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverService roverService = new RoverService();
            List<Rover> rovers = new List<Rover>();

            int[] zone = roverService.readZone();

            Console.WriteLine("How many rovers in the zone?");
            try
            {
                int n = int.Parse(Console.ReadLine());
                
                for (int i=1; i < n+1; i++)
                {
                    Console.WriteLine("Enter position and direction of rover" + i + " (X Y Direction):");
                    Rover rover = new Rover();
                    string[] position = Console.ReadLine().Split(" ");
                    rover.x = int.Parse(position[0]);
                    rover.y = int.Parse(position[1]);
                    string dir = position[2];
                    switch (dir)
                    {
                        case "N":
                            rover.direction = (int)Helper.Direction.N;
                            break;
                        case "E":
                            rover.direction = (int)Helper.Direction.E;
                            break;
                        case "S":
                            rover.direction = (int)Helper.Direction.S;
                            break;
                        case "W":
                            rover.direction = (int)Helper.Direction.W;
                            break;
                    }

                    Console.WriteLine("Enter Movement:");
                    string movenemt = Console.ReadLine();
                    rover.Move(movenemt);
                    rovers.Add(rover);
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Movement invalid");
            }
            catch (Exception)
            {
                Console.WriteLine("Error in position format");
            }
            Console.WriteLine("The final position of rovers is:");
            foreach(Rover r in rovers)
            {
                Console.WriteLine(r.x + " " + r.y + " " + r.GetDirection());
            }
        }
    }
}
