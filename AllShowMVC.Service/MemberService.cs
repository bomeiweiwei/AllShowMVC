using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllShowMVC.Models;
using AllShowMVC.Dao;

namespace AllShowMVC.Service
{
    public class MemberService
    {
        readonly MemberDataOperation memberDataOperation;
        public MemberService()
        {
            memberDataOperation = new MemberDataOperation();
        }

        public List<Member> GetMembers()
        {
            return memberDataOperation.GetObj.GetAll().ToList();
        }
    }
}
