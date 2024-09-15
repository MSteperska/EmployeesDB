using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy_nauka
{
    public class Person
    {
        public string name {get; set;}
        public string surname { get; set;}
        public DateTime birthdate { get; set;}
        public string position { get; set;}
        public string salary { get; set;}
        public string bonus { get; set;}
        public string email { get; set;}
        public string phone { get; set;}

        // pola specyficzne dla roznych stanowisk
        //manager
        public string budget { get; set; } = "";
        public string department { get; set;} = "";
        public string teamsize { get; set;} = "";

        //developer
        public string programminglanguages { get; set;} = "";
        public string github { get; set;} = "";

        //Sales Representative
        public string comissionrate { get; set; } = "";
        public string keyaccounts { get; set;} = "";

        //IT support
        public string supportedsystems { get; set; } = "";
        public string ticketsresolved { get; set; } = "";

        //Marketing Specialist
        public string campaignsmanaged { get; set; } = "";
        public string digitalmaketingskills { get; set; } = "";

        //konstruktor domyslny
        public Person()
        {

        }

        //konstruktor z parametrami
        public Person(string name, string surname, DateTime birthdate, string position, string salary, string bonus, string email, string phone, string buget, 
            string department, string teamsize, string programminglanguages, string github, string comissionrate, string keyaccounts, string supportedsystems, 
            string ticketsresolved, string campainsmanaged, string digitalmarketingskills)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.position = position;
            this.salary = salary;
            this.bonus = bonus;
            this.email = email;
            this.phone = phone;
            this.budget = buget;
            this.department = department;
            this.teamsize = teamsize;
            this.programminglanguages = programminglanguages;
            this.github = github;
            this.comissionrate = comissionrate;
            this.keyaccounts = keyaccounts;
            this.supportedsystems = supportedsystems;
            this.ticketsresolved = ticketsresolved;
            this.campaignsmanaged = campainsmanaged;
            this.digitalmaketingskills = digitalmarketingskills;

        }
    }
}
