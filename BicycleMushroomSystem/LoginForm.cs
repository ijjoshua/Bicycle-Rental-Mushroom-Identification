using System;
using System.Drawing;
using System.Windows.Forms;

namespace BicycleMushroomSystem
{
    public partial class LoginForm : Form
    {
        TextBox txtUsername;
        TextBox txtPassword;

        public LoginForm()
        {
            InitializeComponent();

            UiTheme.ApplyForm(this, "Bicycle & Mushroom System | Login", new Size(860, 620));

            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 126,
                BackColor = UiTheme.PrimaryDark,
                Padding = new Padding(48, 24, 48, 18)
            };
            Label title = UiTheme.CreateTitle("WELCOME BACK", 27);
            title.ForeColor = Color.White;
            title.Dock = DockStyle.Top;
            Label subtitle = UiTheme.CreateSubtitle("Sign in to manage bicycle rentals and identify mushrooms.");
            subtitle.ForeColor = Color.FromArgb(220, 239, 227);
            subtitle.Dock = DockStyle.Top;
            header.Controls.Add(subtitle);
            header.Controls.Add(title);
            Controls.Add(header);

            Panel card = UiTheme.CreateCard();
            card.Width = 560;
            card.Height = 385;
            card.Anchor = AnchorStyles.None;
            card.Location = new Point((ClientSize.Width - card.Width) / 2, 160);

            Label cardTitle = UiTheme.CreateTitle("Sign in", 21);
            cardTitle.Dock = DockStyle.Top;
            Label cardSubtitle = UiTheme.CreateSubtitle("Use your system account to continue.");
            cardSubtitle.Dock = DockStyle.Top;
            Label credentials = new Label
            {
                Text = "Demo credentials:  admin  /  1234",
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 10F),
                ForeColor = UiTheme.Primary,
                Margin = new Padding(0, 0, 0, 12)
            };

            TableLayoutPanel fields = UiTheme.CreateContentTable();
            fields.Dock = DockStyle.Top;
            fields.RowStyles.Clear();
            fields.RowCount = 2;
            fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 58));
            fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 58));

            txtUsername = UiTheme.CreateTextBox();
            txtPassword = UiTheme.CreateTextBox();
            txtPassword.UseSystemPasswordChar = true;
            fields.Controls.Add(UiTheme.CreateFieldLabel("Username"), 0, 0);
            fields.Controls.Add(txtUsername, 1, 0);
            fields.Controls.Add(UiTheme.CreateFieldLabel("Password"), 0, 1);
            fields.Controls.Add(txtPassword, 1, 1);

            FlowLayoutPanel actions = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 66,
                FlowDirection = FlowDirection.RightToLeft,
                WrapContents = false,
                Padding = new Padding(0, 12, 0, 0)
            };
            Button btnLogin = UiTheme.CreateButton("LOGIN", UiTheme.Primary, 150);
            btnLogin.Click += BtnLogin_Click;
            Button btnExit = UiTheme.CreateButton("EXIT", UiTheme.Accent, 130);
            btnExit.Click += (s, e) => Application.Exit();
            actions.Controls.Add(btnLogin);
            actions.Controls.Add(btnExit);

            card.Controls.Add(actions);
            card.Controls.Add(fields);
            card.Controls.Add(credentials);
            card.Controls.Add(cardSubtitle);
            card.Controls.Add(cardTitle);
            Controls.Add(card);
        }

        // Login Button Method
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" &&
                txtPassword.Text == "1234")
            {
                MessageBox.Show("Login successful!");

                ChooseForm choose = new ChooseForm();
                choose.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}