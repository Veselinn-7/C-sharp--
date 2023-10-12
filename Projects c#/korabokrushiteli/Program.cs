using System;
using System.Collections.Generic;

namespace korabokrushiteli

{

    class Program
    {
        static void Main(string[] args)
        {


            
            
            List<string> ages = new List<string>();
            for(int i = 0; i <= ages.Count; i++)
            {
                string number = Console.ReadLine();
                ages.Add(number);
                if(number == "done")
                {
                    ages.Sort();
                    ages.Remove("done");
                    foreach(string text in ages)
                    {
                        Console.WriteLine(text);
                    }
                }
            }
            




        }                        
    }
}


