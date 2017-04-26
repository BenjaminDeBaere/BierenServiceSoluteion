using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BierenServiceLibrary
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.PerSession)]
    public class RadenService : IRadenService
    {
        private const decimal AlcoholDuvel = 8.5m;
        private int besteScore = int.MaxValue;
        private Dictionary<string, int> aantalBeurtenPerClient = new Dictionary<string, int>();
        public RaadResultaat RaadDuvelAlcohol(decimal alcohol)
        {
            var sessionID = OperationContext.Current.SessionId;
            if (!aantalBeurtenPerClient.ContainsKey(sessionID))
                aantalBeurtenPerClient[sessionID] = 1;
            else
                aantalBeurtenPerClient[sessionID]++;
            if (alcohol < AlcoholDuvel)
                return new RaadResultaat { Hint = Hint.Hoger, Beurten = aantalBeurtenPerClient[sessionID], BesteScore = besteScore };
            else
                if (alcohol > AlcoholDuvel)
                return new RaadResultaat { Hint = Hint.Lager, Beurten = aantalBeurtenPerClient[sessionID], BesteScore = besteScore };
            else
                if (aantalBeurtenPerClient[sessionID] < besteScore)
                    besteScore = aantalBeurtenPerClient[sessionID];
                return new RaadResultaat { Hint = Hint.Correct, Beurten = aantalBeurtenPerClient[sessionID], BesteScore = besteScore };
        }
    }
}
