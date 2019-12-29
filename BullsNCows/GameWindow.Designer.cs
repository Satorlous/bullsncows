using System.Drawing;

namespace BullsNCows
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.counterPanel = new System.Windows.Forms.Panel();
            this.bullLabel = new MaterialSkin.Controls.MaterialLabel();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.bullCountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cowLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cowCountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.counterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // counterPanel
            // 
            this.counterPanel.Controls.Add(this.cowCountLabel);
            this.counterPanel.Controls.Add(this.cowLabel);
            this.counterPanel.Controls.Add(this.bullCountLabel);
            this.counterPanel.Controls.Add(this.bullLabel);
            this.counterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.counterPanel.Location = new System.Drawing.Point(0, 311);
            this.counterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.counterPanel.Name = "counterPanel";
            this.counterPanel.Size = new System.Drawing.Size(307, 53);
            this.counterPanel.TabIndex = 0;
            // 
            // bullLabel
            // 
            this.bullLabel.AutoSize = true;
            this.bullLabel.Depth = 0;
            this.bullLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.bullLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bullLabel.Location = new System.Drawing.Point(4, 16);
            this.bullLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bullLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bullLabel.Name = "bullLabel";
            this.bullLabel.Size = new System.Drawing.Size(60, 19);
            this.bullLabel.TabIndex = 0;
            this.bullLabel.Text = "Быков:";
            // 
            // bullCountLabel
            // 
            this.bullCountLabel.AutoSize = true;
            this.bullCountLabel.Depth = 0;
            this.bullCountLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.bullCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bullCountLabel.Location = new System.Drawing.Point(77, 16);
            this.bullCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bullCountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bullCountLabel.Name = "bullCountLabel";
            this.bullCountLabel.Size = new System.Drawing.Size(17, 19);
            this.bullCountLabel.TabIndex = 1;
            this.bullCountLabel.Text = "0";
            // 
            // cowLabel
            // 
            this.cowLabel.AutoSize = true;
            this.cowLabel.Depth = 0;
            this.cowLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.cowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cowLabel.Location = new System.Drawing.Point(152, 16);
            this.cowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cowLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cowLabel.Name = "cowLabel";
            this.cowLabel.Size = new System.Drawing.Size(58, 19);
            this.cowLabel.TabIndex = 0;
            this.cowLabel.Text = "Коров:";
            // 
            // cowCountLabel
            // 
            this.cowCountLabel.AutoSize = true;
            this.cowCountLabel.Depth = 0;
            this.cowCountLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.cowCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cowCountLabel.Location = new System.Drawing.Point(223, 16);
            this.cowCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cowCountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cowCountLabel.Name = "cowCountLabel";
            this.cowCountLabel.Size = new System.Drawing.Size(17, 19);
            this.cowCountLabel.TabIndex = 1;
            this.cowCountLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.inputListBox);
            this.panel1.Controls.Add(this.inputTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 249);
            this.panel1.TabIndex = 2;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(307, 42);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "";
            this.inputTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyUp);
            // 
            // inputListBox
            // 
            this.inputListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.ItemHeight = 20;
            this.inputListBox.Location = new System.Drawing.Point(0, 42);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(307, 207);
            this.inputListBox.TabIndex = 3;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.counterPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameWindow";
            this.Text = "Игра";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameWindow_FormClosed);
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.counterPanel.ResumeLayout(false);
            this.counterPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel counterPanel;
        private MaterialSkin.Controls.MaterialLabel bullLabel;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private MaterialSkin.Controls.MaterialLabel bullCountLabel;
        private MaterialSkin.Controls.MaterialLabel cowCountLabel;
        private MaterialSkin.Controls.MaterialLabel cowLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.ListBox inputListBox;
    }
}