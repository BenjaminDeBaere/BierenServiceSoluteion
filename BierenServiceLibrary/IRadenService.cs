using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BierenServiceLibrary
{
    [ServiceContract(Namespace = "http://vdab.be/alcoholradenservice")]
    public interface IRadenService
    {
        [OperationContract]
        RaadResultaat RaadDuvelAlcohol(decimal Alcohol);
    }
}
