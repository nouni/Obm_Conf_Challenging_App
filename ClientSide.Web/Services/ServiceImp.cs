using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientSide.Web.VOEntities;

namespace ClientSide.Web.Services
{
    public class ServiceImp : AbstractService
    {
        public override List<ChallengingResultVOEntity> LoadChallengingResult(int baseSet = 0, int count = Int32.MaxValue)
        {
            throw new NotImplementedException();
        }
    }
}