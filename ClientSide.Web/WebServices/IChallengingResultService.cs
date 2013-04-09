using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extentions;

namespace ClientSide.Web.WebServices
{
    public interface IChallengingResultService
    {
        ChallengingResultEntity GetChallengingResult(
                                                                    string sessionkey,
                                                                    int baseSet = 0,
                                                                    int count = Int32.MaxValue);
    }
}
