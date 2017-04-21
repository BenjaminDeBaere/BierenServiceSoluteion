using ConsoleBierClient.BierenServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBierClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bierenServiceClient = new BierenServiceClient("httpBieren"))
            {
                Console.WriteLine("aantal bieren: {0}", bierenServiceClient.GetTotaalAantalBieren());
                Console.Write("van alcohol:");
                var van = Decimal.Parse(Console.ReadLine());
                Console.Write("Tot alcohol:");
                var tot = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Aantal bieren: {0}", bierenServiceClient.GetAantalBierenTussenAlcohol(van, tot));
                Console.Write("Woord:");
                var woord = Console.ReadLine();
                var bieren = bierenServiceClient.GetBierenMetWoord(woord);
                foreach (var bier in bieren)
                {
                    Console.WriteLine("{0} {1} {2}%", bier.BierNr, bier.Naam, bier.Alcohol);
                }
            }
        }
    }
}
