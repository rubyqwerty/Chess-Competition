
namespace Сhess_Сompetitions
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Main = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBase = new System.Windows.Forms.ToolStripMenuItem();
            this.Standings = new System.Windows.Forms.ToolStripMenuItem();
            this.ReporttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.StandingTable = new System.Windows.Forms.Panel();
            this.DoGameButton = new System.Windows.Forms.Button();
            this.BDStanding = new System.Windows.Forms.DataGridView();
            this.NameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrawColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Institution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDPanel = new System.Windows.Forms.Panel();
            this.DeleteBaseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FiltrInstitComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryRadioButton = new System.Windows.Forms.RadioButton();
            this.AgeRadioButton = new System.Windows.Forms.RadioButton();
            this.NameRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CreatePlayerButton = new System.Windows.Forms.Button();
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.ReportTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.StandingTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDStanding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDTable)).BeginInit();
            this.BDPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ReportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TT Firs Neue", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(180, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Программа БД \"Шахматные соревнования\"\r\n                        Грунин 21ВП2\r\n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main,
            this.DataBase,
            this.Standings,
            this.ReporttoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1121, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Main
            // 
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(79, 24);
            this.Main.Text = "Главная";
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // DataBase
            // 
            this.DataBase.Name = "DataBase";
            this.DataBase.Size = new System.Drawing.Size(115, 24);
            this.DataBase.Text = "Учет игроков";
            this.DataBase.Click += new System.EventHandler(this.DataBase_Click);
            // 
            // Standings
            // 
            this.Standings.Name = "Standings";
            this.Standings.Size = new System.Drawing.Size(160, 24);
            this.Standings.Text = "Турнирная таблица";
            this.Standings.Click += new System.EventHandler(this.Standings_Click);
            // 
            // ReporttoolStripMenuItem
            // 
            this.ReporttoolStripMenuItem.Name = "ReporttoolStripMenuItem";
            this.ReporttoolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ReporttoolStripMenuItem.Text = "Отчет";
            this.ReporttoolStripMenuItem.Click += new System.EventHandler(this.ReporttoolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(8, 25);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1110, 583);
            this.MainPanel.TabIndex = 3;
            // 
            // StandingTable
            // 
            this.StandingTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StandingTable.Controls.Add(this.DoGameButton);
            this.StandingTable.Controls.Add(this.BDStanding);
            this.StandingTable.Location = new System.Drawing.Point(0, 25);
            this.StandingTable.Name = "StandingTable";
            this.StandingTable.Size = new System.Drawing.Size(1105, 503);
            this.StandingTable.TabIndex = 5;
            this.StandingTable.Visible = false;
            // 
            // DoGameButton
            // 
            this.DoGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoGameButton.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoGameButton.Location = new System.Drawing.Point(938, 9);
            this.DoGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoGameButton.Name = "DoGameButton";
            this.DoGameButton.Size = new System.Drawing.Size(161, 66);
            this.DoGameButton.TabIndex = 6;
            this.DoGameButton.Text = "Провести игры";
            this.DoGameButton.UseVisualStyleBackColor = true;
            this.DoGameButton.Click += new System.EventHandler(this.DoGameButton_Click);
            // 
            // BDStanding
            // 
            this.BDStanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BDStanding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn1,
            this.SecondNameColumn1,
            this.WinsColumn,
            this.LoseColumn,
            this.DrawColumn,
            this.ScoreColumn,
            this.PlaceColumn});
            this.BDStanding.Location = new System.Drawing.Point(3, 3);
            this.BDStanding.Name = "BDStanding";
            this.BDStanding.RowHeadersWidth = 51;
            this.BDStanding.RowTemplate.Height = 29;
            this.BDStanding.Size = new System.Drawing.Size(929, 474);
            this.BDStanding.TabIndex = 5;
            // 
            // NameColumn1
            // 
            this.NameColumn1.HeaderText = "Имя";
            this.NameColumn1.MinimumWidth = 6;
            this.NameColumn1.Name = "NameColumn1";
            this.NameColumn1.Width = 125;
            // 
            // SecondNameColumn1
            // 
            this.SecondNameColumn1.HeaderText = "Фамилия";
            this.SecondNameColumn1.MinimumWidth = 6;
            this.SecondNameColumn1.Name = "SecondNameColumn1";
            this.SecondNameColumn1.Width = 125;
            // 
            // WinsColumn
            // 
            this.WinsColumn.HeaderText = "Победы";
            this.WinsColumn.MinimumWidth = 6;
            this.WinsColumn.Name = "WinsColumn";
            this.WinsColumn.Width = 125;
            // 
            // LoseColumn
            // 
            this.LoseColumn.HeaderText = "Поражения";
            this.LoseColumn.MinimumWidth = 6;
            this.LoseColumn.Name = "LoseColumn";
            this.LoseColumn.Width = 125;
            // 
            // DrawColumn
            // 
            this.DrawColumn.HeaderText = "Ничьи";
            this.DrawColumn.MinimumWidth = 6;
            this.DrawColumn.Name = "DrawColumn";
            this.DrawColumn.Width = 125;
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.HeaderText = "Очки";
            this.ScoreColumn.MinimumWidth = 6;
            this.ScoreColumn.Name = "ScoreColumn";
            this.ScoreColumn.Width = 125;
            // 
            // PlaceColumn
            // 
            this.PlaceColumn.HeaderText = "Место";
            this.PlaceColumn.MinimumWidth = 6;
            this.PlaceColumn.Name = "PlaceColumn";
            this.PlaceColumn.Width = 125;
            // 
            // BDTable
            // 
            this.BDTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BDTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameColumn,
            this.SecondName,
            this.Institution,
            this.Age,
            this.Category});
            this.BDTable.Location = new System.Drawing.Point(4, 33);
            this.BDTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BDTable.Name = "BDTable";
            this.BDTable.ReadOnly = true;
            this.BDTable.RowHeadersWidth = 51;
            this.BDTable.RowTemplate.Height = 29;
            this.BDTable.Size = new System.Drawing.Size(804, 443);
            this.BDTable.TabIndex = 5;
            this.BDTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BDTable_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 125;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "Фамилия";
            this.SecondName.MinimumWidth = 6;
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Width = 125;
            // 
            // Institution
            // 
            this.Institution.HeaderText = "Организация";
            this.Institution.MinimumWidth = 6;
            this.Institution.Name = "Institution";
            this.Institution.ReadOnly = true;
            this.Institution.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Разряд";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // BDPanel
            // 
            this.BDPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BDPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BDPanel.Controls.Add(this.BDTable);
            this.BDPanel.Controls.Add(this.DeleteBaseButton);
            this.BDPanel.Controls.Add(this.panel1);
            this.BDPanel.Controls.Add(this.AllRadioButton);
            this.BDPanel.Controls.Add(this.SearchNameTextBox);
            this.BDPanel.Controls.Add(this.CategoryRadioButton);
            this.BDPanel.Controls.Add(this.AgeRadioButton);
            this.BDPanel.Controls.Add(this.NameRadioButton);
            this.BDPanel.Controls.Add(this.SearchButton);
            this.BDPanel.Controls.Add(this.CreatePlayerButton);
            this.BDPanel.Location = new System.Drawing.Point(0, 28);
            this.BDPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BDPanel.Name = "BDPanel";
            this.BDPanel.Size = new System.Drawing.Size(1119, 498);
            this.BDPanel.TabIndex = 4;
            // 
            // DeleteBaseButton
            // 
            this.DeleteBaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBaseButton.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBaseButton.Location = new System.Drawing.Point(840, 418);
            this.DeleteBaseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBaseButton.Name = "DeleteBaseButton";
            this.DeleteBaseButton.Size = new System.Drawing.Size(248, 58);
            this.DeleteBaseButton.TabIndex = 14;
            this.DeleteBaseButton.Text = "Очистить базу";
            this.DeleteBaseButton.UseVisualStyleBackColor = true;
            this.DeleteBaseButton.Click += new System.EventHandler(this.DeleteBaseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FiltrInstitComboBox);
            this.panel1.Controls.Add(this.CategoryComboBox);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 24);
            this.panel1.TabIndex = 13;
            // 
            // FiltrInstitComboBox
            // 
            this.FiltrInstitComboBox.FormattingEnabled = true;
            this.FiltrInstitComboBox.Items.AddRange(new object[] {
            "Все"});
            this.FiltrInstitComboBox.Location = new System.Drawing.Point(429, -3);
            this.FiltrInstitComboBox.Name = "FiltrInstitComboBox";
            this.FiltrInstitComboBox.Size = new System.Drawing.Size(125, 27);
            this.FiltrInstitComboBox.TabIndex = 11;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Все"});
            this.CategoryComboBox.Location = new System.Drawing.Point(679, 0);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(125, 27);
            this.CategoryComboBox.TabIndex = 12;
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Checked = true;
            this.AllRadioButton.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllRadioButton.Location = new System.Drawing.Point(840, 277);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(78, 27);
            this.AllRadioButton.TabIndex = 10;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "По ID";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            this.AllRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchNameTextBox.Location = new System.Drawing.Point(840, 326);
            this.SearchNameTextBox.Multiline = true;
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.PlaceholderText = "Введите фамилию и имя";
            this.SearchNameTextBox.Size = new System.Drawing.Size(248, 34);
            this.SearchNameTextBox.TabIndex = 9;
            // 
            // CategoryRadioButton
            // 
            this.CategoryRadioButton.AutoSize = true;
            this.CategoryRadioButton.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryRadioButton.Location = new System.Drawing.Point(840, 222);
            this.CategoryRadioButton.Name = "CategoryRadioButton";
            this.CategoryRadioButton.Size = new System.Drawing.Size(265, 27);
            this.CategoryRadioButton.TabIndex = 8;
            this.CategoryRadioButton.Text = "Отсортировать по разряду";
            this.CategoryRadioButton.UseVisualStyleBackColor = true;
            this.CategoryRadioButton.CheckedChanged += new System.EventHandler(this.CategoryRadioButton_CheckedChanged);
            // 
            // AgeRadioButton
            // 
            this.AgeRadioButton.AutoSize = true;
            this.AgeRadioButton.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeRadioButton.Location = new System.Drawing.Point(840, 166);
            this.AgeRadioButton.Name = "AgeRadioButton";
            this.AgeRadioButton.Size = new System.Drawing.Size(272, 27);
            this.AgeRadioButton.TabIndex = 7;
            this.AgeRadioButton.Text = "Отсортировать по возрасту";
            this.AgeRadioButton.UseVisualStyleBackColor = true;
            this.AgeRadioButton.CheckedChanged += new System.EventHandler(this.AgeRadioButton_CheckedChanged);
            // 
            // NameRadioButton
            // 
            this.NameRadioButton.AutoSize = true;
            this.NameRadioButton.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameRadioButton.Location = new System.Drawing.Point(840, 113);
            this.NameRadioButton.Name = "NameRadioButton";
            this.NameRadioButton.Size = new System.Drawing.Size(248, 27);
            this.NameRadioButton.TabIndex = 5;
            this.NameRadioButton.Text = "Отсортировать по имени";
            this.NameRadioButton.UseVisualStyleBackColor = true;
            this.NameRadioButton.CheckedChanged += new System.EventHandler(this.NameRadioButton_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(840, 365);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(248, 31);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CreatePlayerButton
            // 
            this.CreatePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePlayerButton.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatePlayerButton.Location = new System.Drawing.Point(840, 33);
            this.CreatePlayerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatePlayerButton.Name = "CreatePlayerButton";
            this.CreatePlayerButton.Size = new System.Drawing.Size(248, 66);
            this.CreatePlayerButton.TabIndex = 5;
            this.CreatePlayerButton.Text = "Создать шахматиста";
            this.CreatePlayerButton.UseVisualStyleBackColor = true;
            this.CreatePlayerButton.Click += new System.EventHandler(this.CreatePlayerButton_Click);
            // 
            // ReportPanel
            // 
            this.ReportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportPanel.Controls.Add(this.ReportTextBox);
            this.ReportPanel.Location = new System.Drawing.Point(0, 25);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(1121, 503);
            this.ReportPanel.TabIndex = 6;
            this.ReportPanel.Visible = false;
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReportTextBox.Font = new System.Drawing.Font("TT Firs Neue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReportTextBox.Location = new System.Drawing.Point(8, 3);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.ReadOnly = true;
            this.ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportTextBox.Size = new System.Drawing.Size(1107, 503);
            this.ReportTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 536);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ReportPanel);
            this.Controls.Add(this.StandingTable);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BDPanel);
            this.Font = new System.Drawing.Font("TT Firs Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шахматные соревнования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.StandingTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BDStanding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDTable)).EndInit();
            this.BDPanel.ResumeLayout(false);
            this.BDPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ReportPanel.ResumeLayout(false);
            this.ReportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Main;
        private System.Windows.Forms.ToolStripMenuItem DataBase;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BDPanel;
        private System.Windows.Forms.Button CreatePlayerButton;
        private System.Windows.Forms.DataGridView BDTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Institution;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.RadioButton CategoryRadioButton;
        private System.Windows.Forms.RadioButton AgeRadioButton;
        private System.Windows.Forms.RadioButton NameRadioButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.RadioButton AllRadioButton;
        private System.Windows.Forms.ComboBox FiltrInstitComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteBaseButton;
        private System.Windows.Forms.ToolStripMenuItem Standings;
        private System.Windows.Forms.Panel StandingTable;
        private System.Windows.Forms.DataGridView BDStanding;
        private System.Windows.Forms.Button DoGameButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrawColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceColumn;
        private System.Windows.Forms.ToolStripMenuItem ReporttoolStripMenuItem;
        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.TextBox ReportTextBox;
    }
}

