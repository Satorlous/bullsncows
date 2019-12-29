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
            this.loadGameButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gamesListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gamesListBox);
            this.panel1.Controls.Add(this.loadGameButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 322);
            this.panel1.TabIndex = 0;
            // 
            // loadGameButton
            // 
            this.loadGameButton.Depth = 0;
            this.loadGameButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadGameButton.Location = new System.Drawing.Point(0, 285);
            this.loadGameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Primary = true;
            this.loadGameButton.Size = new System.Drawing.Size(317, 37);
            this.loadGameButton.TabIndex = 0;
            this.loadGameButton.Text = "Загрузить";
            this.loadGameButton.UseVisualStyleBackColor = true;
            // 
            // gamesListBox
            // 
            this.gamesListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gamesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesListBox.FormattingEnabled = true;
            this.gamesListBox.ItemHeight = 20;
            this.gamesListBox.Location = new System.Drawing.Point(0, 1);
            this.gamesListBox.Name = "gamesListBox";
            this.gamesListBox.Size = new System.Drawing.Size(317, 284);
            this.gamesListBox.TabIndex = 1;
            // 
            // LoadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 386);
            this.Controls.Add(this.panel1);
            this.Name = "LoadWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузить игру";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadWindow_FormClosed);
            this.Load += new System.EventHandler(this.LoadWindow_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton loadGameButton;
        private System.Windows.Forms.ListBox gamesListBox;
    }
}