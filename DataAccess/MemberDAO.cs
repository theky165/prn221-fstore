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
using System.Windows;
using System.Windows.Controls;

namespace DataAccess
{
    internal class MemberDAO : IMemberRepository
    {
        public FstoreContext db = new FstoreContext();

        public void addMember(Member member)
        {
            db.Add<Member>(member);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Add successfully!");
            }
        }

        public bool AuthenticateUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void deleteMember(Member member)
        {
            db.Remove<Member>(member);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Record removed successfully");
            }
        }

        public void editMember(Member member)
        {
            db.Update<Member>(member);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Edit success.");
            }
            else
            {
                MessageBox.Show("Edit failed.");
            }
        }
    }
}
