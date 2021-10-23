
namespace CalculateASquareOfAPolygon
{
    partial class MainForm
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
            this.HandwritingButton = new System.Windows.Forms.Button();
            this.CoordinatesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HandwritingButton
            // 
            this.HandwritingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HandwritingButton.Location = new System.Drawing.Point(12, 12);
            this.HandwritingButton.Name = "HandwritingButton";
            this.HandwritingButton.Size = new System.Drawing.Size(278, 27);
            this.HandwritingButton.TabIndex = 0;
            this.HandwritingButton.Text = "By handwriting";
            this.HandwritingButton.UseVisualStyleBackColor = true;
            this.HandwritingButton.Click += new System.EventHandler(this.HandwritingButton_Click);
            // 
            // CoordinatesButton
            // 
            this.CoordinatesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoordinatesButton.Location = new System.Drawing.Point(12, 45);
            this.CoordinatesButton.Name = "CoordinatesButton";
            this.CoordinatesButton.Size = new System.Drawing.Size(278, 27);
            this.CoordinatesButton.TabIndex = 1;
            this.CoordinatesButton.Text = "By coordinates of points";
            this.CoordinatesButton.UseVisualStyleBackColor = true;
            this.CoordinatesButton.Click += new System.EventHandler(this.CoordinatesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 83);
            this.Controls.Add(this.CoordinatesButton);
            this.Controls.Add(this.HandwritingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate a square of a polygon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HandwritingButton;
        private System.Windows.Forms.Button CoordinatesButton;
    }
}