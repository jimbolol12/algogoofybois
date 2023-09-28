using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main()
        {
            string inputFileName = "input.txt";

            string input = File.ReadAllText(inputFileName);

            List<string> lines = input.Split('\n').ToList();

            List<int> elfCalories = new List<int>();
            int currentElfCalories = 0;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    elfCalories.Add(currentElfCalories);
                    currentElfCalories = 0;
                }
                else
                {
                    currentElfCalories += int.Parse(line);
                }
            }
            if (currentElfCalories > 0)
            {
                elfCalories.Add(currentElfCalories);
            }

            int maxCalories = elfCalories.Max();

            Console.WriteLine($"De Elf met de meeste calorieën draagt {maxCalories} calorieën.");
            Console.ReadLine();
        }
    }
}

