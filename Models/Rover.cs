using MarsRover.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Models
{
    public class Rover
    {
        public int x { get; set; }
        public int y { get; set; }
        public int direction { get; set; }

        public Rover() { }
        public Rover(int _x, int _y, int _dir) {
            x = _x;
            y = _y;
            direction = _dir;
        }

        public void Move(string movement)
        {
            foreach(char c in movement)
            {
                switch (Char.ToString(c))
                {
                    case "M":
                        Advance();
                        break;
                    case "L":
                        TurnLeft();
                        break;
                    case "R":
                        TurnRight();
                        break;
                    default:
                        throw new ArgumentNullException("Invalid format");
                }
            }
        }

        private void Advance()
        {
            switch (direction)
            {
                case (int)Helper.Direction.N:
                    y++;
                    break;
                case (int)Helper.Direction.E:
                    x++;
                    break;
                case (int)Helper.Direction.S:
                    y--;
                    break;
                case (int)Helper.Direction.W:
                    x--;
                    break;
            }
        }

        public string GetDirection()
        {
            switch (direction)
            {
                case (int)Helper.Direction.N:
                    return "N";
                case (int)Helper.Direction.E:
                    return "E";
                case (int)Helper.Direction.S:
                    return "S";
                case (int)Helper.Direction.W:
                    return "W";
                default:
                    return "";
            }
        }

        private void TurnLeft()
        {
            direction = (direction + 3) % 4;
        }

        private void TurnRight()
        {
            direction = (direction + 1) % 4;
        }
    }
}
