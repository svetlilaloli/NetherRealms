using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            string regexHealth = @"[^0-9\+\-\*\/\.]";
            string regexDamage = @"[\+?\-?0-9]+\.?[0-9]{0,}";
            string regexOperations = @"[\*\/]";
            
            string[] input = Console.ReadLine().Split(',');
            List<Tuple<string, int, double>> demons = new List<Tuple<string, int, double>>();

            foreach (var demonName in input)
            {
                var demon = demonName.Trim();
                int totalHealth = 0;
                double totalDamage = 0;

                var healthMatch = Regex.Matches(demon, regexHealth)
                                        .Cast<Match>()
                                        .Select(m => m.Value)
                                        .ToArray();
                
                foreach (var character in healthMatch)
                {
                    char currentChar;
                    if (Char.TryParse(character, out currentChar))
                    {
                        totalHealth += currentChar;
                    }
                }
                var damageMatch = Regex.Matches(demon, regexDamage)
                                        .Cast<Match>()
                                        .Select(m => m.Value)
                                        .ToArray();
                
                foreach (var number in damageMatch)
                {
                    double currentNum;
                    if (Double.TryParse(number, out currentNum))
                    {
                        totalDamage += currentNum; 
                    }
                }
                var operationsMatch = Regex.Matches(demon, regexOperations)
                                        .Cast<Match>()
                                        .Select(m => m.Value)
                                        .ToArray();
               
                foreach (var operation in operationsMatch)
                {
                    if (operation == "*")
                    {
                        totalDamage *= 2;
                    }
                    else
                    {
                        totalDamage /= 2;
                    }
                }
                Tuple<string, int, double> currentDemon = Tuple.Create(demon, totalHealth, totalDamage);
                demons.Add(currentDemon);
            }

            demons = demons.OrderBy(x => x.Item1).ToList();

            foreach (var demon in demons)
            {
                Console.WriteLine("{0} - {1} health, {2:f2} damage", demon.Item1, demon.Item2, demon.Item3);
            }
        }
    }
}
