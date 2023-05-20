using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сhess_Сompetitions
{
    public partial class MainForm : Form
    {
        List<ChessPlayer> CurrentChessPlayers;
        String Report;
        public MainForm()
        {
            InitializeComponent();
        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            FiltrInstitComboBox.SelectedIndex = 0;
            FiltrInstitComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrInstitComboBox_SelectedIndexChanged);
            CategoryComboBox.SelectedIndex = 0;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.Width = 1139;
            this.Height = 583;
            MainPanel.Visible = true;
            BDPanel.Visible = false;
            MessageBox.Show(
                "Вас приветствует программа БД Шахматные соревнования\n" +
                "Группа 21ВП2, студент Грунин",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            await Task.Run(() => new ApplicationContext());
        }

        private void Main_Click(object sender, EventArgs e)
        {
            this.Width = 1139;
            this.Height = 583;
            MainPanel.Visible = true;
            BDPanel.Visible = false;
            StandingTable.Visible = false;
            ReportPanel.Visible = false;
        }

        private void DataBase_Click(object sender, EventArgs e)
        {
            this.Width = 1139;
            this.Height = 583;
            BDPanel.Visible = true;
            MainPanel.Visible = false;
            StandingTable.Visible = false;
            ReportPanel.Visible = false;
            PrintDataBase();
            var institutuions = new HashSet<string>();
            var categories = new HashSet<string>();
            foreach (ChessPlayer cp in CurrentChessPlayers)
            {
                institutuions.Add(cp.Institution);
                categories.Add(cp.Category.ToString());
            }
            FiltrInstitComboBox.SelectedIndexChanged -= new System.EventHandler(this.FiltrInstitComboBox_SelectedIndexChanged);
            CategoryComboBox.SelectedIndexChanged -= new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            CategoryComboBox.Items.Clear();
            FiltrInstitComboBox.Items.Clear();
            CategoryComboBox.Items.Add("Все");
            FiltrInstitComboBox.Items.Add("Все");
            foreach (String cp in institutuions)
                FiltrInstitComboBox.Items.Add(cp);
            foreach (String cp in categories)
                CategoryComboBox.Items.Add(cp);
            CategoryComboBox.SelectedIndex = 0;
            FiltrInstitComboBox.SelectedIndex = 0;
            CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            FiltrInstitComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrInstitComboBox_SelectedIndexChanged);
        }

        private void Standings_Click(object sender, EventArgs e)
        {
            this.Width = 1129;
            this.Height = 583;
            MainPanel.Visible = false;
            BDPanel.Visible = false;
            ReportPanel.Visible = false;
            StandingTable.Visible = true;
            PrintStanding();
        }

        private void ReporttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1139;
            this.Height = 583;
            BDPanel.Visible = false;
            MainPanel.Visible = false;
            StandingTable.Visible = false;
            ReportPanel.Visible = true;
            ReportTextBox.Text = Report;
        }

        private void PrintDataBase()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                AllRadioButton.Checked = true;
                var players = db.ChessPlayers.ToList();
                CurrentChessPlayers = new List<ChessPlayer>(players);
                if (players.Count != 0)
                {
                    BDTable.RowCount = players.Count();
                    Print(players);
                }
                else
                {
                    BDTable.Rows.Clear();
                }
            }
        }

        private void Print(List<ChessPlayer> players)
        {
            if (players.Count() == 0)
                BDTable.Rows.Clear();
            else
            {
                BDTable.RowCount = players.Count();
                int index = 0;
                foreach (ChessPlayer cp in players)
                {
                    BDTable.Rows[index].Cells[0].Value = cp.ID;
                    BDTable.Rows[index].Cells[1].Value = cp.FirstName;
                    BDTable.Rows[index].Cells[2].Value = cp.SecondName;
                    BDTable.Rows[index].Cells[3].Value = cp.Institution;
                    BDTable.Rows[index].Cells[4].Value = cp.Age;
                    BDTable.Rows[index++].Cells[5].Value = cp.Category;
                }
            }
        }
        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            CreatePlayerForm createPlayerForm = new CreatePlayerForm();
            createPlayerForm.ShowDialog();
            CheckFilter();
        }

        private void BDTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangePlayerForm changePlayerForm = new ChangePlayerForm((int)BDTable.Rows[BDTable.CurrentRow.Index].Cells[0].Value);
            changePlayerForm.ShowDialog();
            CheckFilter();
        }

        private void AgeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AgeRadioButton.Checked == true)
            {
                List<ChessPlayer> players = new List<ChessPlayer>(CurrentChessPlayers);
                var select = (from p in players
                              orderby p.Age
                              select p
                              ).ToList();
                Print(select);
            }
        }

        private void NameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NameRadioButton.Checked == true)
            {
                List<ChessPlayer> players = new List<ChessPlayer>(CurrentChessPlayers);
                var select = (from p in players
                              orderby p.FirstName
                              select p
                              ).ToList();
                Print(select);
            }
        }

        private void CategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CategoryRadioButton.Checked == true)
            {
                List<ChessPlayer> players = new List<ChessPlayer>(CurrentChessPlayers);
                var select = (from p in players
                              orderby p.Category
                              select p
                              ).ToList();
                Print(select);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (AllRadioButton.Checked == true)
            {
                List<ChessPlayer> players = new List<ChessPlayer>(CurrentChessPlayers);
                var select = (from p in players
                              orderby p.ID
                              select p
                              ).ToList();
                Print(select);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string FSName = System.Text.RegularExpressions.Regex.Replace(SearchNameTextBox.Text, @"\s+", " ");
            string[] FSN = FSName.Split(" ");
            using (ApplicationContext db = new ApplicationContext())
            {
                List<ChessPlayer> players = db.ChessPlayers.ToList();
                try
                {
                    var result = (from p in players
                                  where p.FirstName == FSN[1] && p.SecondName == FSN[0]
                                  select p).First();
                    ChangePlayerForm changePlayerForm = new ChangePlayerForm(result.ID);
                    changePlayerForm.ShowDialog();
                    PrintDataBase();
                }
                catch(Exception ex)
                { 
                    MessageBox.Show("Шахматиста с таким ФИ нет","Ошибка!");
                }
            }
        }
        private void FiltrInstitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var players = db.ChessPlayers.ToList();

                var select = (from p in players
                              where p.Institution.ToString() == FiltrInstitComboBox.SelectedItem.ToString()
                              orderby p.Category
                              select p.Category).ToHashSet();
                if (FiltrInstitComboBox.SelectedItem.ToString() == "Все")
                {
                    CategoryComboBox.SelectedIndexChanged -= new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
                    CategoryComboBox.Items.Clear();
                    CategoryComboBox.Items.Add("Все");
                    var categ = (from p in players
                                 select p.Category).ToHashSet();
                    foreach (var cp in categ)
                        CategoryComboBox.Items.Add(cp);
                    CategoryComboBox.SelectedIndex = 0;
                    CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
                }
                else
                {
                    CategoryComboBox.SelectedIndexChanged -= new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
                    CategoryComboBox.Items.Clear();
                    CategoryComboBox.Items.Add("Все");
                    foreach (int cp in select)
                        CategoryComboBox.Items.Add(cp);
                    CategoryComboBox.SelectedIndex = 0;
                    CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
                }
            }
            CheckFilter();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckFilter();
        }

        private void CheckFilter()
        {
            AllRadioButton.Checked = true;
            using (ApplicationContext db = new ApplicationContext())
            {
                var players = db.ChessPlayers.ToList();
                if (FiltrInstitComboBox.SelectedItem.ToString() == "Все" && CategoryComboBox.SelectedItem.ToString() == "Все")
                {
                    CurrentChessPlayers = new List<ChessPlayer>(players);
                    PrintDataBase();
                }
                else if (CategoryComboBox.SelectedItem.ToString() == "Все")
                {
                    var select = (from c in players
                                  where c.Institution == FiltrInstitComboBox.SelectedItem.ToString()
                                  select c).ToList();
                    CurrentChessPlayers = select;
                    Print(CurrentChessPlayers);
                }
                else if (FiltrInstitComboBox.SelectedItem.ToString() == "Все")
                {
                    var select = (from c in players
                                  where c.Category.ToString() == CategoryComboBox.SelectedItem.ToString()
                                  select c).ToList();
                    CurrentChessPlayers = select;
                    Print(CurrentChessPlayers);
                }
                else
                {
                    var select = (from c in players
                                  where c.Category.ToString() == CategoryComboBox.SelectedItem.ToString() && c.Institution == FiltrInstitComboBox.SelectedItem.ToString()
                                  select c).ToList();
                    CurrentChessPlayers = select;
                    Print(CurrentChessPlayers);
                }
            }
        }

        private void PrintStanding()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var players = db.ChessPlayers.ToList();
                var select = (from p in players
                              orderby p.Score descending
                              select p).ToList();
                players = select;
                if (players.Count() == 0) return;
                BDStanding.RowCount = players.Count();
                int index = 0;
                foreach (ChessPlayer cp in players)
                {
                    BDStanding.Rows[index].Cells[0].Value = cp.FirstName;
                    BDStanding.Rows[index].Cells[1].Value = cp.SecondName;
                    BDStanding.Rows[index].Cells[2].Value = cp.NumberOfWins;
                    BDStanding.Rows[index].Cells[3].Value = cp.NumberOFLose;
                    BDStanding.Rows[index].Cells[4].Value = cp.NumberOfDraw;
                    BDStanding.Rows[index].Cells[5].Value = cp.Score;
                    BDStanding.Rows[index++].Cells[6].Value = index;
                }
                for (int i = 0; i < Math.Min(3, players.Count()); ++i)
                {
                    BDStanding.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                for (int i = 3; i < Math.Min(10, players.Count()); ++i)
                {
                    BDStanding.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                for (int i = 10; i <  players.Count(); ++i)
                {
                    BDStanding.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                }
            }
        }

        private void DoGameButton_Click(object sender, EventArgs e)
        {
            Report = "";
            using (ApplicationContext db = new ApplicationContext())
            {
                var players = db.ChessPlayers.ToList();
                foreach (var p in players)
                {
                    p.NumberOfDraw = 0;
                    p.NumberOFLose = 0;
                    p.NumberOfWins = 0;
                    p.Score = 0;
                }
                Report = Game.DoTournament(players);
                db.SaveChanges();
            }
            PrintStanding();
        }

        private void DeleteBaseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Вы действительно хотите удалить базу данных?",
        "Предупреждение!",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    var players = db.ChessPlayers.ToList();
                    foreach (ChessPlayer c in players)
                        db.ChessPlayers.Remove(c);
                    db.SaveChanges();
                }
                PrintDataBase();
            }
            this.TopMost = true;
        }
    }
}
