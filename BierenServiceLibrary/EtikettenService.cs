using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BierenServiceLibrary
{
    class EtikettenService : IEtikettenService
    {
        public void VerwijderEtikettenOuderDan(DateTime datum)
        {
            Thread.Sleep(30000);
            foreach (var bestandsNaam in Directory.GetFiles(@"c:\etiketten"))
            {
                if (File.GetLastWriteTime(bestandsNaam) < datum)
                    File.Delete(bestandsNaam);
            }
        }
    }
}
