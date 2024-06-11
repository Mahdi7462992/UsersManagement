using DataLayer.Context;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repositories;
using DataLayer.Services;
using DataLayer;

namespace Client_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyContext db = new MyContext();

            //Person p = new Person()
            //{
            //    Name = "Iman",
            //    Family = "Madaeny",
            //    website = "Toplearn.com"
            //};
            //db.Persons.Add(p);
            //db.SaveChanges();

            //MyContext db = new MyContext();
            //IPersonRepository personRepository = new PersonRepository(db);
            //personRepository.InsertPerson(new Person()
            //{
            //    Name = "Ali",
            //    Family = "Alizadeh",
            //    website = "Barnamenevisan.org"
            //});
            //personRepository.Save();


            MyContext db = new MyContext();
            MyGenericRepository<Person> personRepository = new MyGenericRepository<Person>(db);

            var query = personRepository.Get(p=>p.Name=="Iman");
            db.Dispose();
        }
    }
}
