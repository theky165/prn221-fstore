using BusinessObject;
using DataAccess.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess
{
    public class MemberDAO : IMemberRepository
    {
        public FstoreContext db = new FstoreContext();
        public void Add(Member Member)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(string email, string password)
        {
            return true;
        }

        public void Edit(Member Member)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Member> GetByAll()
        {
            throw new NotImplementedException();
        }
        public Member GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
