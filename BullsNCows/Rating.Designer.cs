namespace BullsNCows
{
    partial class Rating
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
            this.RatingGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RatingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RatingGridView
            // 
            this.RatingGridView.AllowUserToAddRows = false;
            this.RatingGridView.AllowUserToDeleteRows = false;
            this.RatingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RatingGridView.BackgroundColor = System.Drawing.Color.White;
            this.RatingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RatingGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RatingGridView.Location = new System.Drawing.Point(0, 64);
            this.RatingGridView.Name = "RatingGridView";
            this.RatingGridView.ReadOnly = true;
            this.RatingGridView.Size = new System.Drawing.Size(373, 282);
            this.RatingGridView.TabIndex = 0;
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 346);
            this.Controls.Add(this.RatingGridView);
            this.Name = "Rating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рейтинг";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rating_FormClosed);
            this.Load += new System.EventHandler(this.Rating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RatingGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RatingGridView;
    }
}