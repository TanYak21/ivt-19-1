﻿using System;
using System.Collections.Generic;
using System.Text;
using Autoreport.Models;
using Autoreport.Database;
using Autoreport.UI.Classes;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Autoreport.Services
{
    public class DepositService
    {
        Deposit currentDeposit;
        public Deposit CurrentDeposit
        {
            get { return currentDeposit; }
        }

        public void Add(string data, int _value,DepositType position, Client clients)
        {
            string value = Convert.ToString(_value);
            Deposit deposit = new Deposit()
            {
                Data = data,
                Value = value,
                TypePosition = position,
                Owner = clients
            };

            using (DataContext db = Connection.Connect())
            {
                db.Update(deposit);             
                db.Deposits.Add(deposit);
                db.SaveChanges();
            }

        }

        public void Get()
        {

        }
        public List<Deposit> GetAll()
        {
            using (DataContext db = Connection.Connect())
            {
               // var users = from u in db.Users
                //            join c in db.Companies on u.CompanyId equals c.Id
                //            select new { Name = u.Name, Company = c.Name, Age = u.Age };
                return db.Deposits.Include("Owner")
                    .ToList();
            }
        }


        public void Delete(int Id)
        {
            using (DataContext db = Connection.Connect())
            {
                db.Deposits.Remove(db.Deposits.Where(empl => empl.Id == Id).ToList()[0]);
                db.SaveChanges();
            }
        }

        public void Edit()
        {

        }
    }
}
