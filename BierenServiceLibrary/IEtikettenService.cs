﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BierenServiceLibrary
{
    [ServiceContract(Namespace ="http://vdab.be/etikettenservice")]
    interface IEtikettenService
    {
        [OperationContract(IsOneWay = true)]
        void VerwijderEtikettenOuderDan(DateTime datum);
    }
}
