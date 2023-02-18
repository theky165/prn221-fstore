using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        bool AuthenticateUser(string email, string password);
        void Add(Member Member);
        void Edit(Member Member);
        void Remove(int id);
        Member GetById(int id);
        IEnumerable<Member> GetByAll();
    }
}
