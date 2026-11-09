using System;
using System.Drawing;
using System.Windows.Forms;

namespace BicycleMushroomSystem
{
    public class MushroomForm : Form
    {
        public MushroomForm()
        {
            UiTheme.ApplyForm(this, "Bicycle & Mushroom System | Mushroom Guide", new Size(860, 680));

            Panel header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 145,
                BackColor = UiTheme.PrimaryDark,
                Padding = new Padding(48, 28, 48, 20)
            };
            Label title = UiTheme.CreateTitle("MUSHROOM GUIDE", 27);
            title.ForeColor = Color.White;
            title.Dock = DockStyle.Top;
            Label instruction = UiTheme.CreateSubtitle("Choose a mushroom in your mind, then answer a few questions.");
            instruction.ForeColor = Color.FromArgb(220, 239, 227);
            instruction.Dock = DockStyle.Top;
            header.Controls.Add(instruction);
            header.Controls.Add(title);
            Controls.Add(header);

            Panel card = UiTheme.CreateCard();
            card.Width = 640;
            card.Height = 390;
            card.Anchor = AnchorStyles.None;
            card.Location = new Point((ClientSize.Width - card.Width) / 2, 175);

            Label listHeading = UiTheme.CreateTitle("Available mushrooms", 19);
            listHeading.Dock = DockStyle.Top;

            Label mushroomList = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 230,
                Font = new Font("Segoe UI", 13F),
                ForeColor = UiTheme.Text,
                Padding = new Padding(12, 8, 0, 0)
            };
            mushroomList.Text =
                "1.  Agaric Jaunissant\n" +
                "2.  Amanite tue-mouche\n" +
                "3.  Cepe de Bordeaux\n" +
                "4.  Coprin chevelu\n" +
                "5.  Girolle\n" +
                "6.  Pied bleu";

            FlowLayoutPanel actions = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 62,
                FlowDirection = FlowDirection.RightToLeft,
                WrapContents = false
            };
            Button btnIdentify = UiTheme.CreateButton("IDENTIFY MUSHROOM", UiTheme.Primary, 230);
            btnIdentify.Click += BtnIdentify_Click;
            Button btnLogout = UiTheme.CreateButton("BACK", UiTheme.Accent, 130);

            btnLogout.Click += (s, e) =>
            {
                ChooseForm choose = new ChooseForm();
                choose.Show();
                this.Close();
            };

            actions.Controls.Add(btnIdentify);
            actions.Controls.Add(btnLogout);
            card.Controls.Add(actions);
            card.Controls.Add(mushroomList);
            card.Controls.Add(listHeading);
            Controls.Add(card);
        }

        private void BtnIdentify_Click(object sender, EventArgs e)
        {
            DialogResult answer1 = MessageBox.Show(
                "Does it grow in the forest?",
                "Question 1",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            string mushroom;

            if (answer1 == DialogResult.No)
            {
                DialogResult answer2 = MessageBox.Show(
                    "Does it have a convex cap?",
                    "Question 2",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (answer2 == DialogResult.Yes)
                {
                    mushroom = "Agaric Jaunissant";
                }
                else
                {
                    mushroom = "Coprin chevelu";
                }
            }
            else
            {
                DialogResult answer2 = MessageBox.Show(
                    "Does it have a convex cap?",
                    "Question 2",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (answer2 == DialogResult.Yes)
                {
                    DialogResult answer3 = MessageBox.Show(
                        "Does it have a ring?",
                        "Question 3",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (answer3 == DialogResult.Yes)
                    {
                        mushroom = "Amanite tue-mouche";
                    }
                    else
                    {
                        mushroom = "Pied bleu";
                    }
                }
                else
                {
                    DialogResult answer3 = MessageBox.Show(
                        "Does it have gills?",
                        "Question 3",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (answer3 == DialogResult.Yes)
                    {
                        mushroom = "Girolle";
                    }
                    else
                    {
                        mushroom = "Cepe de Bordeaux";
                    }
                }
            }

            MessageBox.Show(
                "The identified mushroom is: " + mushroom,
                "Mushroom Result",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}