using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> primeMinisters = new Dictionary<int, string>();
            primeMinisters.Add(1998, "Atal Bihari Vajpayee");
            primeMinisters.Add(2014, "Narendra Modi");
            primeMinisters.Add(2004, "Manmohan Singh");

            



                if (primeMinisters.ContainsKey(2004))
                {
                    Console.WriteLine("The Prime Minister of 2004 is:" + primeMinisters[2004]);
                }

            primeMinisters.Add(2019, "Narendra Modi");

            var list = primeMinisters.Keys.ToList();
            list.Sort();
            foreach (var keys in list)
            {
                Console.WriteLine("{0}:{1}",keys,primeMinisters[keys]);
            }   


        }
    }
}
