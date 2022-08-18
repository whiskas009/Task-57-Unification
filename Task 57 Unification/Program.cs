using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_57_Unification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> firtstSoldiers = new List<string>(){"Антон", "Борис", "Макс", "Артём", "Богдан"};
            List<string> secondSoldiers = new List<string>() { "Марк", "Лиза", "Джексон"};

            var soldiers = secondSoldiers.Union(firtstSoldiers.Where(soldier => soldier.StartsWith("Б")));

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
