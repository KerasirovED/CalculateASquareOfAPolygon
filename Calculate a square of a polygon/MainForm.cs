using System;
using System.Windows.Forms;

namespace CalculateASquareOfAPolygon
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void HandwritingButton_Click(object sender, EventArgs e)
        {
            var form = new HandwritingForm();
            form.Show();
            form.FormClosed += (s, ea) => { Show(); };

            Hide();
        }

        private void CoordinatesButton_Click(object sender, EventArgs e)
        {
            var form = new CoordinatesForm();
            form.Show();
            form.FormClosed += (s, ea) => { Show(); };

            Hide();
        }
    }
}
