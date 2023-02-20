﻿using BusinessObject;
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
    public class MemberDAO : IMemberRepository
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
            if (email != null && password != null)
            {
                Member member = db.Members.FirstOrDefault(m => m.Email == email && m.Password == password);
                if (member == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
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
