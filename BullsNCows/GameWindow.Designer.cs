using System.Drawing;
using System.Collections.Generic;

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
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelNum3 = new System.Windows.Forms.Label();
            this.labelNum4 = new System.Windows.Forms.Label();
            this.counterPanel = new System.Windows.Forms.Panel();
            this.tipButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cowCountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cowLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bullCountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.bullLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lastNumberPanel = new System.Windows.Forms.Panel();
            this.inputTextBoxPanel = new System.Windows.Forms.Panel();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.counterPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.lastNumberPanel.SuspendLayout();
            this.inputTextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(8, 14);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(0, 20);
            this.labelNum1.TabIndex = 0;
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(24, 14);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(0, 20);
            this.labelNum2.TabIndex = 0;
            // 
            // labelNum3
            // 
            this.labelNum3.AutoSize = true;
            this.labelNum3.Location = new System.Drawing.Point(41, 14);
            this.labelNum3.Name = "labelNum3";
            this.labelNum3.Size = new System.Drawing.Size(0, 20);
            this.labelNum3.TabIndex = 0;
            // 
            // labelNum4
            // 
            this.labelNum4.AutoSize = true;
            this.labelNum4.Location = new System.Drawing.Point(56, 14);
            this.labelNum4.Name = "labelNum4";
            this.labelNum4.Size = new System.Drawing.Size(0, 20);
            this.labelNum4.TabIndex = 0;
            // 
            // counterPanel
            // 
            this.counterPanel.Controls.Add(this.tipButton);
            this.counterPanel.Controls.Add(this.cowCountLabel);
            this.counterPanel.Controls.Add(this.cowLabel);
            this.counterPanel.Controls.Add(this.bullCountLabel);
            this.counterPanel.Controls.Add(this.bullLabel);
            this.counterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.counterPanel.Location = new System.Drawing.Point(0, 311);
            this.counterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.counterPanel.Name = "counterPanel";
            this.counterPanel.Size = new System.Drawing.Size(307, 53);
            this.counterPanel.TabIndex = 0;
            // 
            // tipButton
            // 
            this.tipButton.Depth = 0;
            this.tipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tipButton.Location = new System.Drawing.Point(257, 12);
            this.tipButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.tipButton.Name = "tipButton";
            this.tipButton.Primary = true;
            this.tipButton.Size = new System.Drawing.Size(38, 29);
            this.tipButton.TabIndex = 2;
            this.tipButton.Text = "?";
            this.tipButton.UseVisualStyleBackColor = true;
            this.tipButton.Visible = false;
            // 
            // cowCountLabel
            // 
            this.cowCountLabel.AutoSize = true;
            this.cowCountLabel.Depth = 0;
            this.cowCountLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.cowCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cowCountLabel.Location = new System.Drawing.Point(205, 16);
            this.cowCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cowCountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cowCountLabel.Name = "cowCountLabel";
            this.cowCountLabel.Size = new System.Drawing.Size(17, 19);
            this.cowCountLabel.TabIndex = 1;
            this.cowCountLabel.Text = "0";
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
            // bullCountLabel
            // 
            this.bullCountLabel.AutoSize = true;
            this.bullCountLabel.Depth = 0;
            this.bullCountLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.bullCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bullCountLabel.Location = new System.Drawing.Point(59, 16);
            this.bullCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bullCountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.bullCountLabel.Name = "bullCountLabel";
            this.bullCountLabel.Size = new System.Drawing.Size(17, 19);
            this.bullCountLabel.TabIndex = 1;
            this.bullCountLabel.Text = "0";
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
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.inputListBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 114);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(307, 197);
            this.mainPanel.TabIndex = 2;
            // 
            // inputListBox
            // 
            this.inputListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputListBox.FormattingEnabled = true;
            this.inputListBox.ItemHeight = 20;
            this.inputListBox.Location = new System.Drawing.Point(0, 0);
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.Size = new System.Drawing.Size(307, 197);
            this.inputListBox.TabIndex = 3;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.inputTextBoxPanel);
            this.headerPanel.Controls.Add(this.lastNumberPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.headerPanel.Location = new System.Drawing.Point(0, 65);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(307, 49);
            this.headerPanel.TabIndex = 3;
            // 
            // lastNumberPanel
            // 
            this.lastNumberPanel.Controls.Add(this.labelNum4);
            this.lastNumberPanel.Controls.Add(this.labelNum3);
            this.lastNumberPanel.Controls.Add(this.labelNum2);
            this.lastNumberPanel.Controls.Add(this.labelNum1);
            this.lastNumberPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.lastNumberPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNumberPanel.Location = new System.Drawing.Point(209, 0);
            this.lastNumberPanel.Name = "lastNumberPanel";
            this.lastNumberPanel.Size = new System.Drawing.Size(98, 49);
            this.lastNumberPanel.TabIndex = 4;
            this.lastNumberPanel.Visible = false;
            // 
            // inputTextBoxPanel
            // 
            this.inputTextBoxPanel.Controls.Add(this.inputTextBox);
            this.inputTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.inputTextBoxPanel.Name = "inputTextBoxPanel";
            this.inputTextBoxPanel.Size = new System.Drawing.Size(209, 49);
            this.inputTextBoxPanel.TabIndex = 5;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(209, 49);
            this.inputTextBox.TabIndex = 4;
            this.inputTextBox.Text = "";
            this.inputTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyUp);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 364);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.counterPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameWindow_FormClosed);
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.counterPanel.ResumeLayout(false);
            this.counterPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.lastNumberPanel.ResumeLayout(false);
            this.lastNumberPanel.PerformLayout();
            this.inputTextBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.Panel counterPanel;
        private MaterialSkin.Controls.MaterialLabel bullLabel;
        private MaterialSkin.Controls.MaterialLabel bullCountLabel;
        private MaterialSkin.Controls.MaterialLabel cowCountLabel;
        private MaterialSkin.Controls.MaterialLabel cowLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ListBox inputListBox;
        private MaterialSkin.Controls.MaterialRaisedButton tipButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel lastNumberPanel;      
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum4;
        private System.Windows.Forms.Label labelNum3;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Panel inputTextBoxPanel;
        private System.Windows.Forms.RichTextBox inputTextBox;
    }
}