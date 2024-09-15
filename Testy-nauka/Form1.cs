using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testy_nauka
{
    public partial class Form1 : Form
    {
        private PeopleListManager peopleListManager = new PeopleListManager();    //polaczenie z lista przechowujaca rekordy
        private DataBaseManager dataBaseManager; //polaczenie z plikem bazodanowym
        public List<Person> peopleList = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            string dbpath = "C:\\Gocha\\Studia\\6\\XPW\\2\\DBLearning\\Testy-nauka\\EmployeesDB.db";//System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EmployeesDB.db");
            //peopleListManager = new PeopleListManager();
            dataBaseManager = new DataBaseManager(dbpath);

            //LoadEmployeesFromDB
           peopleList = dataBaseManager.GetAllEmployees(peopleList);
        }

    
    private void AddButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm AddForm = new AddEmployeeForm(peopleListManager);
            AddForm.ShowDialog();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewEmployeesForm ViewForm = new ViewEmployeesForm(peopleListManager);
            ViewForm.ShowDialog();
        }

        /*
        private void LoadEmployeesFromDB()
        {
            DataBaseManager dataBaseManager = new DataBaseManager();
            List<Person> PeopleList = dataBaseManager.GetAllEmployees();
    
        }
        */

    }
}
