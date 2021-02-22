using AllShowMVC.Dao;
using AllShowMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Service
{
    public class TestService
    {
        readonly TestDao testDao;
        public TestService()
        {
            testDao = new TestDao();
        }

        public List<Member> GetMembers()
        {
            return testDao.GetMembers();
        }
    }
}
