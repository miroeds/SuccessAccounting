using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuccessAccounting
{
    public partial class LoginForm : Form
    {
        private TextBox txtLogin, txtPassword;
        private CheckBox chkShow;
        private Button btnLogin;
        private Label lblError;
        private int attempts = 0;

        public LoginForm()
        {
            this.Text = "Вход в систему";
            this.Size = new Size(400, 300);
            this.MinimumSize = new Size(400, 300);
            this.Font = new Font("Comic Sans MS", 10);

            Label lblLogin = new Label() { Text = "Логин:", Location = new Point(50, 50), Size = new Size(60, 25) };
            txtLogin = new TextBox() { Location = new Point(130, 50), Size = new Size(180, 25) };

            Label lblPass = new Label() { Text = "Пароль:", Location = new Point(50, 90), Size = new Size(60, 25) };
            txtPassword = new TextBox() { Location = new Point(130, 90), Size = new Size(180, 25), UseSystemPasswordChar = true };

            chkShow = new CheckBox() { Text = "Показать пароль", Location = new Point(130, 120), Size = new Size(150, 25) };
            chkShow.CheckedChanged += (s, e) => txtPassword.UseSystemPasswordChar = !chkShow.Checked;

            btnLogin = new Button() { Text = "Войти", Location = new Point(130, 160), Size = new Size(100, 30) };
            btnLogin.Click += BtnLogin_Click;

            lblError = new Label() { Location = new Point(50, 210), Size = new Size(280, 30), ForeColor = Color.Red };

            Controls.AddRange(new Control[] { lblLogin, txtLogin, lblPass, txtPassword, chkShow, btnLogin, lblError });
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pass = txtPassword.Text;

            if (login == "student" && pass == "123")
                OpenForm(new StudentForm(), "Студент: Иванов Иван");
            else if (login == "teacher" && pass == "123")
                OpenForm(new TeacherForm(), "Преподаватель: Петрова Анна");
            else if (login == "admin" && pass == "123")
                OpenForm(new AdminForm(), "Учебная часть: Сидоров Олег");
            else
            {
                attempts++;
                lblError.Text = $"Неверный логин или пароль. Попыток: {attempts}";
                if (attempts >= 3) { MessageBox.Show("Доступ заблокирован."); Application.Exit(); }
            }
        }

        private void OpenForm(Form form, string message)
        {
            MessageBox.Show(message, "Добро пожаловать");
            form.Show();
            this.Hide();
        }
    }
}