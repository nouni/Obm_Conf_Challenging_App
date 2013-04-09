using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Extentions;

namespace ClientSide.Web.WebServices
{
    /// <summary>
    /// Summary description for ChallengingResultWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ChallengingResultWebService : System.Web.Services.WebService, IChallengingResultService
    {
        [WebMethod]
        public ChallengingResultEntity GetChallengingResult(string sessionkey,
                                                                            int baseSet = 0,
                                                                            int count = Int32.MaxValue)
        {
            return new ChallengingResultEntity() {ErrorMessage = "Empty List", Result = null };
        }
    }
}
