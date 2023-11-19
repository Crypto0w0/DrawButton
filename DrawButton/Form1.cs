using System.Runtime.Serialization;

namespace DrawButton
{
    public partial class Form1 : Form
    {
        Point p1;
        Point p2;
        public Form1()
        {
            InitializeComponent();
        }

        private void IfMDown(object sender, MouseEventArgs e)
        {
            p1 = new Point(e.X, e.Y);
        }

        private void IfMUp(object sender, MouseEventArgs e)
        {
            p2 = new Point(e.X, e.Y);
            Button button = new Button();
            button.Location = p1;
            button.Width = p2.X - p1.X;
            button.Height = p2.Y - p1.Y;
            button.Name = "";
            Controls.Add(button);
        }
    }
}
