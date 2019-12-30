namespace BullsNCows
{
    partial class Parent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
            this.newGameButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.loadGameButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.trainingButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ratingButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Depth = 0;
            this.newGameButton.Location = new System.Drawing.Point(61, 130);
            this.newGameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Primary = true;
            this.newGameButton.Size = new System.Drawing.Size(174, 39);
            this.newGameButton.TabIndex = 8;
            this.newGameButton.Text = "НОВАЯ ИГРА";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGame);
            // 
            // loadGameButton
            // 
            this.loadGameButton.Depth = 0;
            this.loadGameButton.Location = new System.Drawing.Point(61, 175);
            this.loadGameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadGameButton.Name = "loadGameButton";
            this.loadGameButton.Primary = true;
            this.loadGameButton.Size = new System.Drawing.Size(174, 39);
            this.loadGameButton.TabIndex = 9;
            this.loadGameButton.Text = "ЗАГРУЗИТЬ ИГРУ";
            this.loadGameButton.UseVisualStyleBackColor = true;
            this.loadGameButton.Click += new System.EventHandler(this.LoadGame);
            // 
            // trainingButton
            // 
            this.trainingButton.Depth = 0;
            this.trainingButton.Location = new System.Drawing.Point(61, 220);
            this.trainingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.trainingButton.Name = "trainingButton";
            this.trainingButton.Primary = true;
            this.trainingButton.Size = new System.Drawing.Size(174, 39);
            this.trainingButton.TabIndex = 9;
            this.trainingButton.Text = "ПРОЙТИ ОБУЧЕНИЕ";
            this.trainingButton.UseVisualStyleBackColor = true;
            this.trainingButton.Click += new System.EventHandler(this.TrainingGame);
            // 
            // ratingButton
            // 
            this.ratingButton.Depth = 0;
            this.ratingButton.Location = new System.Drawing.Point(61, 265);
            this.ratingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ratingButton.Name = "ratingButton";
            this.ratingButton.Primary = true;
            this.ratingButton.Size = new System.Drawing.Size(174, 39);
            this.ratingButton.TabIndex = 9;
            this.ratingButton.Text = "РЕЙТИНГ";
            this.ratingButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Игрок1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(101, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Имя игрока";
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 319);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ratingButton);
            this.Controls.Add(this.trainingButton);
            this.Controls.Add(this.loadGameButton);
            this.Controls.Add(this.newGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Быки и Коровы\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parent_FormClosing);
            this.Load += new System.EventHandler(this.Parent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton newGameButton;
        private MaterialSkin.Controls.MaterialRaisedButton loadGameButton;
        private MaterialSkin.Controls.MaterialRaisedButton trainingButton;
        private MaterialSkin.Controls.MaterialRaisedButton ratingButton;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

