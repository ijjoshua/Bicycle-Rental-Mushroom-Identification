using System;
using System.Drawing;
using System.Windows.Forms;

namespace BicycleMushroomSystem
{
    public class BicycleForm : Form
    {
        TextBox txtStart;
        TextBox txtEnd;
        TextBox txtTotal;

        public BicycleForm()
        {
            UiTheme.ApplyForm(this, "Bicycle & Mushroom System | Bicycle Rental", new Size(860, 620));

            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 145,
                BackColor = UiTheme.PrimaryDark,
                Padding = new Padding(48, 28, 48, 20)
            };
            Label title = UiTheme.CreateTitle("BICYCLE RENTAL", 27);
            title.ForeColor = Color.White;
            title.Dock = DockStyle.Top;
            Label subtitle = UiTheme.CreateSubtitle("Calculate your rental fee by entering the start and end times.");
            subtitle.ForeColor = Color.FromArgb(220, 239, 227);
            subtitle.Dock = DockStyle.Top;
            header.Controls.Add(subtitle);
            header.Controls.Add(title);
            Controls.Add(header);

            Panel card = UiTheme.CreateCard();
            card.Width = 620;
            card.Height = 330;
            card.Anchor = AnchorStyles.None;
            card.Location = new Point((ClientSize.Width - card.Width) / 2, 185);

            TableLayoutPanel fields = UiTheme.CreateContentTable();
            fields.RowCount = 3;
            fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 58));
            fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 58));
            fields.RowStyles.Add(new RowStyle(SizeType.Absolute, 65));

            txtStart = UiTheme.CreateTextBox();
            txtEnd = UiTheme.CreateTextBox();
            txtTotal = UiTheme.CreateTextBox();
            txtTotal.ReadOnly = true;
            txtTotal.BackColor = Color.FromArgb(232, 244, 236);
            txtTotal.ForeColor = UiTheme.PrimaryDark;
            txtTotal.Font = new Font("Segoe UI Semibold", 13F);
            fields.Controls.Add(UiTheme.CreateFieldLabel("Starting time (0-23)"), 0, 0);
            fields.Controls.Add(txtStart, 1, 0);
            fields.Controls.Add(UiTheme.CreateFieldLabel("Ending time (1-24)"), 0, 1);
            fields.Controls.Add(txtEnd, 1, 1);
            fields.Controls.Add(UiTheme.CreateFieldLabel("Total payment"), 0, 2);
            fields.Controls.Add(txtTotal, 1, 2);

            FlowLayoutPanel actions = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 62,
                FlowDirection = FlowDirection.RightToLeft,
                WrapContents = false
            };
            Button btnCalculate = UiTheme.CreateButton("CALCULATE", UiTheme.Primary, 170);
            btnCalculate.Click += BtnCalculate_Click;
            Button btnLogout = UiTheme.CreateButton("BACK", UiTheme.Accent, 130);

            btnLogout.Click += (s, e) =>
            {
                ChooseForm choose = new ChooseForm();
                choose.Show();
                this.Close();
            };

            actions.Controls.Add(btnCalculate);
            actions.Controls.Add(btnLogout);
            card.Controls.Add(actions);
            card.Controls.Add(fields);
            Controls.Add(card);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int startTime;
            int endTime;
            int total = 0;

            if (!int.TryParse(txtStart.Text, out startTime) ||
                !int.TryParse(txtEnd.Text, out endTime))
            {
                MessageBox.Show("Please enter valid numbers!");
                return;
            }

            if (startTime < 0 || startTime > 23 ||
                endTime < 1 || endTime > 24 ||
                startTime >= endTime)
            {
                MessageBox.Show("Invalid time!");
                return;
            }

            for (int hour = startTime; hour < endTime; hour++)
            {
                int price;

                if (hour < 7 || hour >= 21)
                {
                    price = 500;
                }
                else if (hour < 14 || hour >= 19)
                {
                    price = 1000;
                }
                else
                {
                    price = 1500;
                }

                total = total + price;
            }

            txtTotal.Text = total + " RWF";

            MessageBox.Show("Total payment = " + total + " RWF");
        }
    }
}