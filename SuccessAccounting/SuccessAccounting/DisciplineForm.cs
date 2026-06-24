using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuccessAccounting
{
    public partial class DisciplineForm : Form
    {
        public DisciplineForm()
        {
            this.Text = "Назначение дисциплин";
            this.Size = new Size(500, 400);
            this.Font = new Font("Comic Sans MS", 10);

            DataGridView dgv = new DataGridView()
            {
                Location = new Point(20, 20),
                Size = new Size(440, 250),
                ColumnCount = 4
            };
            dgv.Columns[0].Name = "Дисциплина";
            dgv.Columns[1].Name = "Группа";
            dgv.Columns[2].Name = "Преподаватель";
            dgv.Columns[3].Name = "Часы";
            dgv.Rows.Add("Математика", "ИСП-21", "Петрова А.С.", "72");

            Button btnAdd = new Button() { Text = "Добавить", Location = new Point(20, 290), Size = new Size(100, 30) };
            Button btnBack = new Button() { Text = "Назад", Location = new Point(340, 290), Size = new Size(100, 30) };
            btnBack.Click += (s, e) => { new AdminForm().Show(); this.Close(); };

            Controls.AddRange(new Control[] { dgv, btnAdd, btnBack });
        }
    }
}