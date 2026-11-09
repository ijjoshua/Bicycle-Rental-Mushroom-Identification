using System;
using System.Drawing;
using System.Windows.Forms;

namespace BicycleMushroomSystem
{
    public class ChooseForm : Form
    {
        public ChooseForm()
        {
            UiTheme.ApplyForm(this, "Bicycle & Mushroom System | Services", new Size(860, 620));

            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 150,
                BackColor = UiTheme.PrimaryDark,
                Padding = new Padding(48, 30, 48, 20)
            };
            Label title = UiTheme.CreateTitle("CHOOSE YOUR SERVICE", 27);
            title.ForeColor = Color.White;
            title.Dock = DockStyle.Top;
            Label subtitle = UiTheme.CreateSubtitle("What would you like to do today?");
            subtitle.ForeColor = Color.FromArgb(220, 239, 227);
            subtitle.Dock = DockStyle.Top;
            header.Controls.Add(subtitle);
            header.Controls.Add(title);
            Controls.Add(header);

            TableLayoutPanel services = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 280,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(36, 34, 36, 20)
            };
            services.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            services.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            Button btnBicycle = UiTheme.CreateButton("BICYCLE RENTAL", UiTheme.Primary, 260);
            btnBicycle.Dock = DockStyle.Fill;
            btnBicycle.Margin = new Padding(18);

            btnBicycle.Click += (s, e) =>
            {
                BicycleForm bicycle = new BicycleForm();
                bicycle.Show();
                this.Hide();
            };

            Button btnMushroom = UiTheme.CreateButton("MUSHROOM GUIDE", UiTheme.Accent, 260);
            btnMushroom.Dock = DockStyle.Fill;
            btnMushroom.Margin = new Padding(18);

            btnMushroom.Click += (s, e) =>
            {
                MushroomForm mushroom = new MushroomForm();
                mushroom.Show();
                this.Hide();
            };

            services.Controls.Add(btnBicycle, 0, 0);
            services.Controls.Add(btnMushroom, 1, 0);
            Controls.Add(services);

            Button btnLogout = UiTheme.CreateButton("LOGOUT", UiTheme.PrimaryDark, 150);
            btnLogout.Anchor = AnchorStyles.Top;
            btnLogout.Location = new Point((ClientSize.Width - btnLogout.Width) / 2, 475);

            btnLogout.Click += (s, e) =>
            {
                Application.Exit();
            };

            Controls.Add(btnLogout);
        }
    }
}