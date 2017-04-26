using ConsoleBierClient.BierenServiceReference;
using ConsoleBierClient.EtikettenService;
using ConsoleBierClient.RadenService;
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
            /*using (var bierenServiceClient = new BierenServiceClient("httpBieren"))
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
                Console.WriteLine();
                foreach (var bier in bierenServiceClient.GetStrafsteBieren())
                {
                    Console.WriteLine("{0} {1} {2}%", bier.BierNr, bier.Naam, bier.Alcohol);
                }
                Console.ReadLine();

            }

            using (var radenServiceClient = new RadenServiceClient())
            {
                Console.WriteLine("Raad het alcoholpercentage van Duvel");
                var alcohol = Decimal.Parse(Console.ReadLine());
                var antwoord = radenServiceClient.RaadDuvelAlcohol(alcohol);
                while (antwoord.Hint != Hint.Correct)
                {
                    Console.WriteLine("{0}, {1} beurten", antwoord.Hint, antwoord.Beurten);
                    alcohol = Decimal.Parse(Console.ReadLine());
                    antwoord = radenServiceClient.RaadDuvelAlcohol(alcohol);
                }
                Console.WriteLine("{0}, {1} beurten", antwoord.Hint, antwoord.Beurten);
            }*/

            using (var etikettenServiceClient = new EtikettenServiceClient())
            {
                Console.Write("Datum tijd:");
                var datum = DateTime.Parse(Console.ReadLine());
                etikettenServiceClient.VerwijderEtikettenOuderDan(datum);
            }
        }
    }
}
