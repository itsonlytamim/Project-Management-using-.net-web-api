using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MemberRepo : Repo, IRepo<Member, int, bool>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> Get()
        {
            throw new NotImplementedException();
        }

        public Member Get(int id)
        {
            throw new NotImplementedException();
        }

        public Member Insert(Member obj)
        {
            throw new NotImplementedException();
        }

        public Member Update(Member obj)
        {
            throw new NotImplementedException();
        }

        bool IRepo<Member, int, bool>.Insert(Member obj)
        {
            throw new NotImplementedException();
        }

        bool IRepo<Member, int, bool>.Update(Member obj)
        {
            throw new NotImplementedException();
        }
    }
}
