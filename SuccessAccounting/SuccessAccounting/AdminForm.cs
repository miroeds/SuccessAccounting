using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuccessAccounting
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            this.Text = "Учебная часть";
            this.Size = new Size(500, 350);
            this.Font = new Font("Comic Sans MS", 10);

            Button btnGroups = new Button() { Text = "Управление группами", Location = new Point(50, 40), Size = new Size(250, 35) };
            btnGroups.Click += (s, e) => { new GroupManagementForm().Show(); this.Hide(); };

            Button btnDisciplines = new Button() { Text = "Назначение дисциплин", Location = new Point(50, 90), Size = new Size(250, 35) };
            btnDisciplines.Click += (s, e) => { new DisciplineForm().Show(); this.Hide(); };

            Button btnReport = new Button() { Text = "Сводный отчёт", Location = new Point(50, 140), Size = new Size(250, 35) };
            btnReport.Click += (s, e) => MessageBox.Show("Отчёт сформирован.", "Успех");

            Button btnExit = new Button() { Text = "Выход", Location = new Point(50, 240), Size = new Size(100, 30) };
            btnExit.Click += (s, e) => { new LoginForm().Show(); this.Close(); };

            Controls.AddRange(new Control[] { btnGroups, btnDisciplines, btnReport, btnExit });
        }
    }
}