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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelNum3 = new System.Windows.Forms.Label();
            this.labelNum4 = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.tipToggler = new MaterialSkin.Controls.MaterialCheckBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputListBox = new System.Windows.Forms.ListBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.inputTextBoxPanel = new System.Windows.Forms.Panel();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.lastNumberPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SaveGameButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.footerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.inputTextBoxPanel.SuspendLayout();
            this.lastNumberPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Location = new System.Drawing.Point(19, 14);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(0, 20);
            this.labelNum1.TabIndex = 0;
            this.labelNum1.MouseEnter += new System.EventHandler(this.LabelNumberEnter);
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Location = new System.Drawing.Point(35, 14);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(0, 20);
            this.labelNum2.TabIndex = 0;
            this.labelNum2.MouseEnter += new System.EventHandler(this.LabelNumberEnter);
            // 
            // labelNum3
            // 
            this.labelNum3.AutoSize = true;
            this.labelNum3.Location = new System.Drawing.Point(52, 14);
            this.labelNum3.Name = "labelNum3";
            this.labelNum3.Size = new System.Drawing.Size(0, 20);
            this.labelNum3.TabIndex = 0;
            this.labelNum3.MouseEnter += new System.EventHandler(this.LabelNumberEnter);
            // 
            // labelNum4
            // 
            this.labelNum4.AutoSize = true;
            this.labelNum4.Location = new System.Drawing.Point(67, 14);
            this.labelNum4.Name = "labelNum4";
            this.labelNum4.Size = new System.Drawing.Size(0, 20);
            this.labelNum4.TabIndex = 0;
            this.labelNum4.MouseEnter += new System.EventHandler(this.LabelNumberEnter);
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.SaveGameButton);
            this.footerPanel.Controls.Add(this.tipToggler);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 311);
            this.footerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(307, 53);
            this.footerPanel.TabIndex = 0;
            // 
            // tipToggler
            // 
            this.tipToggler.AutoSize = true;
            this.tipToggler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipToggler.Depth = 0;
            this.tipToggler.Font = new System.Drawing.Font("Roboto", 10F);
            this.tipToggler.Location = new System.Drawing.Point(9, 14);
            this.tipToggler.Margin = new System.Windows.Forms.Padding(0);
            this.tipToggler.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tipToggler.MouseState = MaterialSkin.MouseState.HOVER;
            this.tipToggler.Name = "tipToggler";
            this.tipToggler.Ripple = true;
            this.tipToggler.Size = new System.Drawing.Size(167, 30);
            this.tipToggler.TabIndex = 3;
            this.tipToggler.Text = "Включить подсказки";
            this.tipToggler.UseVisualStyleBackColor = true;
            this.tipToggler.Visible = false;
            this.tipToggler.CheckedChanged += new System.EventHandler(this.TipToggler_CheckedChanged);
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
            this.inputTextBox.Multiline = false;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(209, 49);
            this.inputTextBox.TabIndex = 4;
            this.inputTextBox.Text = "";
            this.inputTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyUp);
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
            // SaveGameButton
            // 
            this.SaveGameButton.Depth = 0;
            this.SaveGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveGameButton.Location = new System.Drawing.Point(209, 14);
            this.SaveGameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Primary = true;
            this.SaveGameButton.Size = new System.Drawing.Size(86, 23);
            this.SaveGameButton.TabIndex = 4;
            this.SaveGameButton.Text = "Сохранить";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            this.SaveGameButton.MouseEnter += new System.EventHandler(this.SaveGameButton_MouseEnter);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 364);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.footerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameWindow_FormClosed);
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.Shown += new System.EventHandler(this.GameWindow_Shown);
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.inputTextBoxPanel.ResumeLayout(false);
            this.lastNumberPanel.ResumeLayout(false);
            this.lastNumberPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ListBox inputListBox;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel lastNumberPanel;      
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum4;
        private System.Windows.Forms.Label labelNum3;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Panel inputTextBoxPanel;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private MaterialSkin.Controls.MaterialCheckBox tipToggler;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialRaisedButton SaveGameButton;
    }
}