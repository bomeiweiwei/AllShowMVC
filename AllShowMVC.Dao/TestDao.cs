using AllShowMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Dao
{
    public class TestDao
    {
        readonly AllShowEntities allShowEntities;
        public TestDao()
        {
            allShowEntities = new AllShowEntities();
        }
        public List<Member> GetMembers()
        {
            return allShowEntities.Member.ToList();
        }
    }
}
