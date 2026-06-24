using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuccessAccounting
{
    public partial class GroupManagementForm : Form
    {
        public GroupManagementForm()
        {
            this.Text = "Управление группами";
            this.Size = new Size(500, 400);
            this.Font = new Font("Comic Sans MS", 10);

            DataGridView dgv = new DataGridView()
            {
                Location = new Point(20, 20),
                Size = new Size(440, 250),
                ColumnCount = 3
            };
            dgv.Columns[0].Name = "Номер группы";
            dgv.Columns[1].Name = "Специальность";
            dgv.Columns[2].Name = "Курс";
            dgv.Rows.Add("ИСП-21", "Информационные системы", "2");

            Button btnAdd = new Button() { Text = "Добавить", Location = new Point(20, 290), Size = new Size(100, 30) };
            Button btnDelete = new Button() { Text = "Удалить", Location = new Point(140, 290), Size = new Size(100, 30) };
            Button btnBack = new Button() { Text = "Назад", Location = new Point(340, 290), Size = new Size(100, 30) };
            btnBack.Click += (s, e) => { new AdminForm().Show(); this.Close(); };

            Controls.AddRange(new Control[] { dgv, btnAdd, btnDelete, btnBack });
        }
    }
}