using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BierenServiceLibrary
{

    [ServiceContract(Namespace = "http://vdab.be/bierenservice")]
    public interface IBierenService
    {
        [OperationContract]
        int GetTotaalAantalBieren();

        [OperationContract]
        int GetAantalBierenTussenAlcohol(decimal van, decimal tot);
        [OperationContract]
        List<Bier> GetBierenMetWoord(string woord);
        [OperationContract]
        List<Bier> GetStrafsteBieren();
    }

}

