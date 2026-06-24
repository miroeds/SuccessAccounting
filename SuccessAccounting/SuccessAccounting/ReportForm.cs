using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuccessAccounting
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            this.Text = "Зачётно-экзаменационная ведомость";
            this.Size = new Size(600, 500);
            this.Font = new Font("Comic Sans MS", 10);

            Label lbl = new Label() { Text = "Ведомость: Математика, группа ИСП-21, семестр 1", Location = new Point(20, 20), Size = new Size(500, 25) };

            DataGridView dgv = new DataGridView()
            {
                Location = new Point(20, 60),
                Size = new Size(540, 300),
                ColumnCount = 3,
                ReadOnly = true,
                AllowUserToAddRows = false
            };
            dgv.Columns[0].Name = "Студент";
            dgv.Columns[1].Name = "Оценка";
            dgv.Columns[2].Name = "Дата";
            dgv.Rows.Add("Иванов И.И.", "5", "20.01.2026");
            dgv.Rows.Add("Петров П.П.", "4", "20.01.2026");
            dgv.Rows.Add("Сидоров С.С.", "3", "20.01.2026");

            Button btnPrint = new Button() { Text = "Печать", Location = new Point(200, 380), Size = new Size(100, 30) };
            btnPrint.Click += (s, e) => MessageBox.Show("Ведомость отправлена на печать.", "Успех");

            Button btnBack = new Button() { Text = "Назад", Location = new Point(400, 380), Size = new Size(100, 30) };
            btnBack.Click += (s, e) => { new TeacherForm().Show(); this.Close(); };

            Controls.AddRange(new Control[] { lbl, dgv, btnPrint, btnBack });
        }
    }
}