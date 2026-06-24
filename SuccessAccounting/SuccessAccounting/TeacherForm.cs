using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuccessAccounting
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            this.Text = "Рабочее место преподавателя";
            this.Size = new Size(600, 400);
            this.Font = new Font("Comic Sans MS", 10);

            DataGridView dgv = new DataGridView()
            {
                Location = new Point(20, 20),
                Size = new Size(540, 250),
                ColumnCount = 4
            };
            dgv.Columns[0].Name = "Студент";
            dgv.Columns[1].Name = "Дисциплина";
            dgv.Columns[2].Name = "Оценка";
            dgv.Columns[3].Name = "Дата";
            dgv.Rows.Add("Иванов", "Математика", "5", "10.01.2026");
            dgv.Rows.Add("Петров", "Математика", "4", "10.01.2026");

            Button btnSave = new Button() { Text = "Сохранить", Location = new Point(20, 290), Size = new Size(120, 30) };
            btnSave.Click += (s, e) => MessageBox.Show("Оценки сохранены.", "Успех");

            Button btnReport = new Button() { Text = "Ведомость", Location = new Point(160, 290), Size = new Size(120, 30) };
            btnReport.Click += (s, e) => { new ReportForm().Show(); this.Hide(); };

            Button btnExit = new Button() { Text = "Выход", Location = new Point(400, 290), Size = new Size(100, 30) };
            btnExit.Click += (s, e) => { new LoginForm().Show(); this.Close(); };

            Controls.AddRange(new Control[] { dgv, btnSave, btnReport, btnExit });
        }
    }
}