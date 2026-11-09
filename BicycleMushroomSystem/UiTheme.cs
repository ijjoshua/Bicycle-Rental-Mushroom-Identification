using System.Drawing;
using System.Windows.Forms;

namespace BicycleMushroomSystem
{
    internal static class UiTheme
    {
        internal static readonly Color Background = Color.FromArgb(239, 247, 242);
        internal static readonly Color Surface = Color.White;
        internal static readonly Color Primary = Color.FromArgb(31, 112, 82);
        internal static readonly Color PrimaryDark = Color.FromArgb(22, 79, 58);
        internal static readonly Color Accent = Color.FromArgb(232, 166, 56);
        internal static readonly Color Text = Color.FromArgb(35, 54, 45);
        internal static readonly Color MutedText = Color.FromArgb(91, 112, 101);
        internal static readonly Color Border = Color.FromArgb(211, 226, 217);

        internal static void ApplyForm(Form form, string title, Size clientSize)
        {
            form.Text = title;
            form.ClientSize = clientSize;
            form.MinimumSize = new Size(720, 520);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.BackColor = Background;
            form.ForeColor = Text;
            form.Font = new Font("Segoe UI", 11F);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
        }

        internal static Label CreateTitle(string text, int size = 24)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Segoe UI", size, FontStyle.Bold),
                ForeColor = PrimaryDark,
                Margin = new Padding(0, 0, 0, 8)
            };
        }

        internal static Label CreateSubtitle(string text)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Segoe UI", 11F),
                ForeColor = MutedText,
                Margin = new Padding(0, 0, 0, 20)
            };
        }

        internal static Label CreateFieldLabel(string text)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 11F),
                ForeColor = Text,
                Anchor = AnchorStyles.Left,
                Margin = new Padding(0, 8, 16, 8)
            };
        }

        internal static TextBox CreateTextBox()
        {
            return new TextBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Surface,
                ForeColor = Text,
                Font = new Font("Segoe UI", 12F),
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 4, 0, 12),
                Height = 38
            };
        }

        internal static Button CreateButton(string text, Color color, int width = 160)
        {
            Button button = new Button
            {
                Text = text,
                Width = width,
                Height = 46,
                FlatStyle = FlatStyle.Flat,
                BackColor = color,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 11F),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false,
                Margin = new Padding(6)
            };
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(
                Math.Min(color.R + 20, 255), Math.Min(color.G + 20, 255), Math.Min(color.B + 20, 255));
            return button;
        }

        internal static Panel CreateCard()
        {
            return new Panel
            {
                BackColor = Surface,
                Padding = new Padding(34),
                Margin = new Padding(20),
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill
            };
        }

        internal static TableLayoutPanel CreateContentTable(int columns = 2)
        {
            TableLayoutPanel table = new TableLayoutPanel
            {
                ColumnCount = columns,
                RowCount = 0,
                Dock = DockStyle.Top,
                AutoSize = true,
                BackColor = Color.Transparent,
                Padding = new Padding(0)
            };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            return table;
        }
    }
}
