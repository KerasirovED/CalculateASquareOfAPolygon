
namespace CalculateASquareOfAPolygon
{
    partial class CoordinatesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PointsDataGridView = new System.Windows.Forms.DataGridView();
            this.XColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.SquareLabel = new System.Windows.Forms.Label();
            this.DeleteRowContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).BeginInit();
            this.DeleteRowContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PointsDataGridView
            // 
            this.PointsDataGridView.AllowUserToResizeColumns = false;
            this.PointsDataGridView.AllowUserToResizeRows = false;
            this.PointsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XColumn,
            this.YColumn});
            this.PointsDataGridView.Location = new System.Drawing.Point(12, 29);
            this.PointsDataGridView.Name = "PointsDataGridView";
            this.PointsDataGridView.RowHeadersVisible = false;
            this.PointsDataGridView.RowHeadersWidth = 51;
            this.PointsDataGridView.RowTemplate.Height = 24;
            this.PointsDataGridView.Size = new System.Drawing.Size(239, 343);
            this.PointsDataGridView.TabIndex = 0;
            this.PointsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PointsDataGridView_CellEndEdit);
            this.PointsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.PointsDataGridView_DefaultValuesNeeded);
            this.PointsDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.PointsDataGridView_EditingControlShowing);
            this.PointsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PointsDataGridView_RowsAdded);
            this.PointsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PointsDataGridView_MouseClick);
            // 
            // XColumn
            // 
            this.XColumn.HeaderText = "X";
            this.XColumn.MinimumWidth = 6;
            this.XColumn.Name = "XColumn";
            this.XColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // YColumn
            // 
            this.YColumn.HeaderText = "Y";
            this.YColumn.MinimumWidth = 6;
            this.YColumn.Name = "YColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Points\' list";
            // 
            // SquareLabel
            // 
            this.SquareLabel.AutoSize = true;
            this.SquareLabel.Location = new System.Drawing.Point(12, 375);
            this.SquareLabel.Name = "SquareLabel";
            this.SquareLabel.Size = new System.Drawing.Size(194, 17);
            this.SquareLabel.TabIndex = 2;
            this.SquareLabel.Text = "Minimum three points needed";
            // 
            // DeleteRowContextMenuStrip
            // 
            this.DeleteRowContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DeleteRowContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteRowToolStripMenuItem});
            this.DeleteRowContextMenuStrip.Name = "contextMenuStrip1";
            this.DeleteRowContextMenuStrip.Size = new System.Drawing.Size(184, 28);
            // 
            // DeleteRowToolStripMenuItem
            // 
            this.DeleteRowToolStripMenuItem.Name = "DeleteRowToolStripMenuItem";
            this.DeleteRowToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.DeleteRowToolStripMenuItem.Text = "Удалить строку";
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 404);
            this.Controls.Add(this.SquareLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PointsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManualForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate a square of a polygon";
            this.Load += new System.EventHandler(this.ManualForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PointsDataGridView)).EndInit();
            this.DeleteRowContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PointsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn XColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YColumn;
        private System.Windows.Forms.Label SquareLabel;
        private System.Windows.Forms.ContextMenuStrip DeleteRowContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteRowToolStripMenuItem;
    }
}