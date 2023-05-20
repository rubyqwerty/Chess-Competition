using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Сhess_Сompetitions
{
    public partial class ChangePlayerForm : Form
    {
        int IDUser=0;
        ChessPlayer cp;
        List<ChessPlayer> players;
        public ChangePlayerForm()
        {
            InitializeComponent();
        }
        public ChangePlayerForm(int _IDUser)
        {
            InitializeComponent();
            IDUser = _IDUser;
            PrintInfoPlayer();
        }

        private void PrintInfoPlayer()
        {
            
            using (ApplicationContext db = new ApplicationContext())
            {
                players = db.ChessPlayers.ToList();
            }
            cp = (from c in players
                 where c.ID == IDUser
                 select c).First();
            NameTextBox.Text = cp.FirstName;
            SecondNameTextBox.Text = cp.SecondName;
            InstitutionTextBox.Text = cp.Institution;
            AgeNumericUpDown.Value = cp.Age;
            CategoryNumericUpDown.Value = cp.Category;
        }

        private void SaveChangeButton_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                players = db.ChessPlayers.ToList();
                cp = (from c in players
                      where c.ID == IDUser
                      select c).First();
                string FirstName = NameTextBox.Text;
                string SecondName = SecondNameTextBox.Text;
                int Age = (int)AgeNumericUpDown.Value;
                string Institution = InstitutionTextBox.Text;
                int Category = (int)CategoryNumericUpDown.Value;

                int flag = 0;

                if (!Regex.IsMatch(FirstName, @"^[А-Яа-яA-Za-z]+$"))
                {
                    NameErrorLabel.Text = "Имя состоит только из букв";
                    flag++;
                }
                else
                {
                    NameErrorLabel.Text = "";
                }

                if (!Regex.IsMatch(SecondName, @"^[А-Яа-яA-Za-z]+$"))
                {
                    SecondNameErrorLabel.Text = "Фамилия состоит только из букв";
                    flag++;
                }
                else
                {
                    SecondNameErrorLabel.Text = "";
                }

                if (!Regex.IsMatch(Institution, @"^[А-Яа-яA-Za-z]+$"))
                {
                    InstitutionErrorLabel.Text = "Название организации состоит только из букв";
                    flag++;
                }
                else
                {
                    InstitutionErrorLabel.Text = "";
                }

                if (!(10 < Age && Age < 100))
                {
                    AgeErrorLabel.Text = "Допустимый возраст от 10 до 100";
                    flag++;
                }
                else
                {
                    AgeErrorLabel.Text = "";
                }

                if (!(0 < Category && Category <= 4))
                {
                    CategoryErrorLabel.Text = "Допустимый разряд 1-4";
                    flag++;
                }
                else
                {
                    CategoryErrorLabel.Text = "";
                }

                if (flag == 0)
                {
                    cp.FirstName = FirstName;
                    cp.SecondName = SecondName;
                    cp.Age = Age;
                    cp.Institution = Institution;
                    cp.Category = Category;

                    db.SaveChanges();
                    this.Close();
                }                   
                
            }
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.ChessPlayers.Remove(cp);
                db.SaveChanges();
            }
            this.Close();
        }
    }

}
