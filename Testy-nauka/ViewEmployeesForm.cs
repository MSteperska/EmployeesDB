using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testy_nauka
{
    
    public partial class ViewEmployeesForm : Form
    {
        private PeopleListManager peopleListManager;
        public ViewEmployeesForm(PeopleListManager manager)
        {
            InitializeComponent();
            peopleListManager = manager;
            DisplayPeople();
        }

        private void DisplayPeople()
        {
            //pobranie listy
            var people = peopleListManager.GetAllPersons();

            dataGridView1.Rows.Clear();

            //dodawanie wierszy
            foreach(var person in people)
            {
                dataGridView1.Rows.Add(person.name, person.surname, person.birthdate, person.salary, person.bonus, person.email, person.phone, 
                    person.budget, person.department, person.teamsize,
                    person.programminglanguages, person.github, 
                    person.comissionrate, person.keyaccounts,
                    person.supportedsystems, person.ticketsresolved,
                    person.campaignsmanaged, person.digitalmaketingskills);
            }
        }

    }
}
