using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsToProblemss
{
    class Program
    {
        static void Main(string[] args)
        {
            


                List<int> backpacks = new List<int>();
                int sum = 0;
                bool isRunning = true;
                while (isRunning == true)
               {
           
                    string input = Console.ReadLine();
                
                if (int.TryParse(input, out int count))
                {
                    backpacks.Add(count);
                    sum = sum + count;
                }
                else if (input == "done")
                {
                    int result = 0;
                    result = sum / backpacks.Count;
                    Console.WriteLine(result);
                    break;
                        
                }    

            }

          }      

        }
    }

