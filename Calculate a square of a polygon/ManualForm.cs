using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CalculateASquareOfAPolygon
{
    public partial class CoordinatesForm : Form
    {
        Polygon _polygon = new Polygon();
        int _deletingRowIndex;

        public CoordinatesForm() => InitializeComponent();

        private void PointsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= PointsDataGridViewCell_KeyPress;
            e.Control.KeyPress += PointsDataGridViewCell_KeyPress;
        }

        private void PointsDataGridViewCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow to input only digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow to input the dot. The dot should be only one
            if (e.KeyChar == '.' & (sender as Control).Text.Count(x => x == '.') < 1)
                return;

            // Allow to input the minus. The minus should be only one
            if (e.KeyChar == '-' & (sender as Control).Text.Count(x => x == '-') < 1)
                return;

            // Allow Backspace
            if (char.IsControl(e.KeyChar)) return;

            e.Handled = true;
        }

        private void PointsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            PointsDataGridView[0, e.RowIndex].Value = 0;
            PointsDataGridView[1, e.RowIndex].Value = 0;
        }

        private void PointsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = 0;
            e.Row.Cells[1].Value = 0;
        }

        private void PointsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = PointsDataGridView[e.ColumnIndex, e.RowIndex];
            var cellText = JustifyCellValue(cell);

            float f;
            if (float.TryParse(cellText, out f) == false)
            {
                cell.ErrorText = "Entered value should be a number";
            }
            else
            {
                CalculateSquare();
                cell.ErrorText = null;
            }

            ShowSquare();
        }

        private void CalculateSquare()
        {
            _polygon.ClearPoints();

            foreach (DataGridViewRow row in PointsDataGridView.Rows)
            {
                // Except new row
                if (row.IsNewRow) continue;

                try
                {
                    var x = float.Parse(row.Cells[0].Value.ToString());
                    var y = float.Parse(row.Cells[1].Value.ToString());

                    _polygon.AddPoint(new PointF(x, y));
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "ProgrammException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowSquare()
        {
            foreach (DataGridViewRow row in PointsDataGridView.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    if (string.IsNullOrEmpty(cell.ErrorText) == false)
                    {
                        SquareLabel.Text = "Square: Nan";
                        return;
                    }

            if (double.IsNaN(_polygon.Square)) SquareLabel.Text = "Minimum three points needed";
            else SquareLabel.Text = $"Square: {_polygon.Square:F}";
        }

        private string JustifyCellValue(DataGridViewCell cell)
        {
            var cellText = cell.Value?.ToString() ?? "0";

            cellText = cellText.TrimStart('0');
            if (cellText == "-" || cellText == ".") cellText = "0";
            if (cellText.StartsWith(".")) cellText = "0" + cellText;
            if (cellText.EndsWith(".")) cellText = cellText.Replace(".", "");
            if (cellText == "0.0" || cellText == "-0") cellText = "0";
            if (string.IsNullOrEmpty(cellText)) cellText = "0";

            cell.Value = cellText;

            return cellText;
        }

        private void PointsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            // Show the menu only when Right Mouse Button have pressed
            if (e.Button != MouseButtons.Right) return;

            // Check the hit on a row
            _deletingRowIndex = PointsDataGridView.HitTest(e.X, e.Y).RowIndex;
            if (_deletingRowIndex < 0) return;

            // Check if a row is not new row
            if (PointsDataGridView.Rows[_deletingRowIndex].IsNewRow) return;

            DeleteRowContextMenuStrip.Show(PointsDataGridView, e.Location);
        }

        private void ManualForm_Load(object sender, EventArgs e)
        {
            DeleteRowToolStripMenuItem.Click += (s, ea) =>
            {
                PointsDataGridView.Rows.Remove(PointsDataGridView.Rows[_deletingRowIndex]);
                CalculateSquare();
                ShowSquare();
            };
        }
    }
}
