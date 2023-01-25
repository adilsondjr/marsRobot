using System;

    enum Direction { North, East, South, West }

    class MarsRobot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the grid size (x y): ");
            string[] gridSize = Console.ReadLine().Split(' ');
            int gridX = int.Parse(gridSize[0]);
            int gridY = int.Parse(gridSize[1]);

            Console.WriteLine("Enter commands: ");
            string commands = Console.ReadLine();

            Robot robot = new Robot(gridX, gridY);
            for (int i = 0; i < commands.Length; i++)
            {
                robot.Move(commands[i]);
            }

            Console.WriteLine("Final position: " + robot);
        }
    }
