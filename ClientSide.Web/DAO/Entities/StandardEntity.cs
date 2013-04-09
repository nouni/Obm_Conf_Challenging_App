using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientSide.Web.DAO.Entities
{
    public class StandardEntity
    {
        public int Id { set; get; }
        public string TaName { set; get; }
        public string Aim { set; get; }
        public int Count { set; get; }
    }
}