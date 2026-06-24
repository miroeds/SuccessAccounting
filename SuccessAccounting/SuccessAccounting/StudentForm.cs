using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuccessAccounting
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            this.Text = "Личный кабинет студента";
            this.Size = new Size(600, 400);
            this.Font = new Font("Comic Sans MS", 10);

            DataGridView dgv = new DataGridView()
            {
                Location = new Point(20, 20),
                Size = new Size(540, 250),
                ColumnCount = 4,
                ReadOnly = true,
                AllowUserToAddRows = false
            };
            dgv.Columns[0].Name = "Дисциплина";
            dgv.Columns[1].Name = "Оценка";
            dgv.Columns[2].Name = "Дата";
            dgv.Columns[3].Name = "Семестр";
            dgv.Rows.Add("Математика", "5", "10.01.2026", "1");
            dgv.Rows.Add("Физика", "4", "15.01.2026", "1");
            dgv.Rows.Add("Программирование", "3", "20.01.2026", "1");

            Label lblAvg = new Label() { Text = "Средний балл: 4.0", Location = new Point(20, 290), Size = new Size(200, 25) };

            Button btnExit = new Button() { Text = "Выход", Location = new Point(250, 320), Size = new Size(100, 30) };
            btnExit.Click += (s, e) => { new LoginForm().Show(); this.Close(); };

            Controls.AddRange(new Control[] { dgv, lblAvg, btnExit });
        }
    }
}