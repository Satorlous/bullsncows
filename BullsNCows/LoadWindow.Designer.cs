namespace BullsNCows
{
    partial class LoadWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadGamesGridView = new System.Windows.Forms.DataGridView();
            this.Btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGamesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LoadGamesGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 322);
            this.panel1.TabIndex = 0;
            // 
            // LoadGamesGridView
            // 
            this.LoadGamesGridView.AllowUserToAddRows = false;
            this.LoadGamesGridView.AllowUserToDeleteRows = false;
            this.LoadGamesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadGamesGridView.BackgroundColor = System.Drawing.Color.White;
            this.LoadGamesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadGamesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Btn});
            this.LoadGamesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadGamesGridView.Location = new System.Drawing.Point(0, 0);
            this.LoadGamesGridView.Name = "LoadGamesGridView";
            this.LoadGamesGridView.ReadOnly = true;
            this.LoadGamesGridView.Size = new System.Drawing.Size(340, 322);
            this.LoadGamesGridView.TabIndex = 2;
            this.LoadGamesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoadGamesGridView_CellContentClick);
            // 
            // Btn
            // 
            this.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn.HeaderText = "";
            this.Btn.Name = "Btn";
            this.Btn.ReadOnly = true;
            this.Btn.Text = "Выбрать";
            this.Btn.UseColumnTextForButtonValue = true;
            // 
            // LoadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 386);
            this.Controls.Add(this.panel1);
            this.Name = "LoadWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доступные игры. ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadWindow_FormClosed);
            this.Load += new System.EventHandler(this.LoadWindow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadGamesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView LoadGamesGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Btn;
    }
}