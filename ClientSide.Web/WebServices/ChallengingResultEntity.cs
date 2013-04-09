
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientSide.Web.WebServices
{
    public class ChallengingResultEntity
    {
        bool thereiserros = false;
        public bool TherIsErrors
        {
            set
            {
               thereiserros = value;
            }
            get
            {
                return thereiserros;
            } 
        }
        string error = "";
        public string ErrorMessage
        {
            set
            {
                error = value;
                TherIsErrors =  string.IsNullOrEmpty(ErrorMessage); 
            }
            get { return error; } 
        }
        public List<VOEntities.ChallengingResultVOEntity> Result { set; get; } 
    }
}