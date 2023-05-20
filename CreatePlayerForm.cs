using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Сhess_Сompetitions
{
    public partial class CreatePlayerForm : Form
    {
        public CreatePlayerForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
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
                AddInBase(new ChessPlayer { FirstName = FirstName, SecondName = SecondName, Age = Age, 
                    Institution = Institution, Category = Category });
            }
        }

        private void AddInBase(ChessPlayer chessPlayer)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var players = db.ChessPlayers.ToList();
                var result = (from p in players
                              where p.FirstName == chessPlayer.FirstName && p.SecondName == chessPlayer.SecondName
                              select p).ToList();
                if (result.Count() == 0)
                {
                    db.ChessPlayers.Add(chessPlayer);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Шахматист с таким ФИ уже есть", "Ошибка!");
                }
               
            }
        }
    }
}
