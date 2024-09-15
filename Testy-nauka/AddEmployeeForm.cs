using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Testy_nauka
{
    public partial class AddEmployeeForm : Form
    {
        PeopleListManager peopleListManager;
        DataBaseManager dataBaseManager = new DataBaseManager("C:\\Gocha\\Studia\\6\\XPW\\2\\DBLearning\\Testy-nauka\\EmployeesDB.db");
        public AddEmployeeForm(PeopleListManager manager)
        {
            InitializeComponent();
            peopleListManager = manager;

            //ukrycie opcji zaleznych od rodzaju stanowiska
            SetFalse();
        }

        private void AddEmployeeButton2_Click(object sender, EventArgs e)
        {
            //pobranie danych z textbox'ow
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string salary = SalaryTextBox.Text; 
            string bonus = BonusTextBox.Text;   
            string email = EmailTextBox.Text;   
            string selectedPositon = comboBox1.SelectedItem as string;
            DateTime birthdate = dateTimePicker1.Value;
            string phone = PhoneTextBox.Text;   

            //pola specyficzne dla danego stanowiska
            string budget = "";
            string department = "";
            string teamsize = "";
            string programminglanguages = "";
            string github = "";
            string comissionrate = "";
            string keyaccounts = "";
            string supportedsystems = "";
            string ticketsresolved = "";
            string campaignsmanaged = "";
            string digitalmaketingskills = "";

            //walidacja danych podstawowych
            if (!Validator.IsOnlyText(name))
            {
                MessageBox.Show("Invalid name");
                return;
            }
            if (!Validator.IsOnlyText(surname))
            {
                MessageBox.Show("Invalid surname");
                return;
            }
            if (!Validator.OnlyOneDotPlace(salary) && !Validator.IsOnlyDigits(salary) && !Validator.IsPosDecimal(salary))
            {
                MessageBox.Show("Invalid salary");
                return;
            }
            if (!Validator.OnlyOneDotPlace(bonus) && !Validator.IsOnlyDigits(bonus) && !Validator.IsPosDecimal(bonus))
            {
                MessageBox.Show("Invalid bonus");
                return;
            }
            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email");
                return;
            }
            if (!Validator.IsValidPhone(phone))
            {
                MessageBox.Show("Invalid phone");
                return;
            }


            //dodanie wartosci charakterystycznych dla danego stanowiska
            switch (selectedPositon)
            {
                case "Manager":

                    budget = BudgetTextBox.Text;
                    department = DepartmentTextBox.Text;
                    teamsize = TeamsizeTextBox.Text;

                    //walidacja danych
                    if (!Validator.OnlyOneDotPlace(budget) && !Validator.IsOnlyDigits(budget) && !Validator.IsPosDecimal(budget))
                    {
                        MessageBox.Show("Invalid budget");
                        return;
                    }
                    if (!Validator.IsOnlyDigits(teamsize))
                    {
                        MessageBox.Show("Invalid team size");
                        return;
                    }

                    break;

                case "Developer":

                    programminglanguages = ProgLangTextBox.Text;
                    github = GithubTextBox.Text;
                    break;

                case "Marketing Specialist":

                    comissionrate = CommRateTextBox.Text;
                    keyaccounts = KeyAccountsTextBox.Text;

                    //walidacja danych
                    if (!Validator.IsPercent(comissionrate))
                    {
                        MessageBox.Show("Invalid comission rate");
                        return;
                    }
                    break;

                case "IT support":

                    supportedsystems = SuppSysTextBox.Text;
                    ticketsresolved = TicResTextBox.Text;

                    //walidacja danych
                    if (!Validator.IsPosDecimal(ticketsresolved))
                    {
                        MessageBox.Show("Invalid tickets resolved");
                        return;
                    }
                    break;

                case "Sales Representative":

                    campaignsmanaged = CampManTextBox.Text;
                    digitalmaketingskills = DMSTextBox.Text;
                    break;

            }


            //utworzenie obiektu person i dodanie go do listy
            Person person = new Person(name, surname, birthdate, selectedPositon, salary, bonus, email, phone, budget, department, teamsize, 
                programminglanguages, github, comissionrate, keyaccounts, supportedsystems, ticketsresolved, campaignsmanaged, digitalmaketingskills);
            
            peopleListManager.AddPerson(person);
            //dataBaseManager.AddEmployee(person);

            ClearTextBoxes();
            
        }

        //wyswietlanie odpowiednich kontrolek
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPosition = comboBox1.SelectedItem as string;
            switch(selectedPosition)
            {
                case "Manager":
                    SetFalse();

                    BudgetLabel.Visible = true;
                    DepartmentLabel.Visible = true;
                    TeamsizeLabel.Visible = true;
                    BudgetTextBox.Visible = true;
                    DepartmentTextBox.Visible = true;
                    TeamsizeTextBox.Visible = true;
                    break;

                case "Developer":
                    SetFalse();

                    ProgLangLabel.Visible = true;
                    GithubLabel.Visible = true;
                    ProgLangTextBox.Visible = true;
                    GithubTextBox.Visible = true;
                    break;

                case "Marketing Specialist":
                    SetFalse();

                    CommRateLabel.Visible = true;
                    KeyAccountsLabel.Visible = true;
                    CommRateTextBox.Visible = true;
                    KeyAccountsTextBox.Visible = true;
                    break;

                case "IT support":
                    SetFalse();

                    SuppSysLabel.Visible = true;
                    TicResLabel.Visible = true;
                    SuppSysTextBox.Visible = true;
                    TicResTextBox.Visible = true;
                    break;
                case "Sales Representative":
                    SetFalse();

                    CampManLabel.Visible = true;
                    DMSLabel.Visible = true;
                    CampManTextBox.Visible = true;
                    DMSTextBox.Visible = true;
                    break;

            }
        }

        void SetFalse()
        {
            //manager
            BudgetLabel.Visible = false;
            DepartmentLabel.Visible = false;
            TeamsizeLabel.Visible = false;
            BudgetTextBox.Visible = false;
            DepartmentTextBox.Visible = false;
            TeamsizeTextBox.Visible = false;

            //developer
            ProgLangLabel.Visible = false;
            GithubLabel.Visible = false;
            ProgLangTextBox.Visible = false;
            GithubTextBox.Visible = false;

            //marketing specialist
            CommRateLabel.Visible = false;
            KeyAccountsLabel.Visible = false;
            CommRateTextBox.Visible = false;
            KeyAccountsTextBox.Visible = false;

            //IT support
            SuppSysLabel.Visible = false;
            TicResLabel.Visible = false;
            SuppSysTextBox.Visible = false;
            TicResTextBox.Visible = false;

            //sales representative
            CampManLabel.Visible = false;
            DMSLabel.Visible = false;
            CampManTextBox.Visible = false;
            DMSTextBox.Visible = false;


        }

        //czyszczenie textbox
        private void ClearTextBoxes()
        {
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            SalaryTextBox.Clear();   
            BonusTextBox.Clear();   
            EmailTextBox.Clear();   
            PhoneTextBox.Clear();

            BudgetTextBox.Clear();
            DepartmentTextBox.Clear();
            TeamsizeTextBox.Clear();
            ProgLangTextBox.Clear();
            GithubTextBox.Clear();
            CommRateTextBox.Clear();
            KeyAccountsTextBox.Clear();
            SuppSysTextBox.Clear();
            TicResTextBox.Clear();
            CampManTextBox.Clear();
            DMSTextBox.Clear();

            }

    }
}
