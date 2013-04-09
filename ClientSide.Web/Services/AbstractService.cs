using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientSide.Web.VOEntities;

namespace ClientSide.Web.Services
{
    public abstract class AbstractService
    {
        private DAO.AbstractDAO _dao = null;

        /// <summary>
        /// Initialise Service class with DAO implementation class
        /// </summary>
        /// <param name="dao">DAO Implementation class of AbstractDAO</param>
        /// <exception cref="Exception : If dao is null">If dao is null</exception>
        protected void Init(DAO.AbstractDAO dao)
        {
            if (dao == null) throw new Exception("A DAO clas should be specified for Service CLass");
            _dao = dao;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract List<ChallengingResultVOEntity> LoadChallengingResult(int baseSet = 0,int count = Int32.MaxValue);
    }
}