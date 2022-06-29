namespace Kursovaya
{
    partial class EditDiskForm
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
            this.SingerBox = new System.Windows.Forms.TextBox();
            this.GenreUpDown = new System.Windows.Forms.DomainUpDown();
            this.EditDiskButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SingerBox
            // 
            this.SingerBox.Location = new System.Drawing.Point(12, 94);
            this.SingerBox.Name = "SingerBox";
            this.SingerBox.Size = new System.Drawing.Size(188, 20);
            this.SingerBox.TabIndex = 9;
            // 
            // GenreUpDown
            // 
            this.GenreUpDown.Items.Add("Поп");
            this.GenreUpDown.Items.Add("Рок");
            this.GenreUpDown.Items.Add("Рэп");
            this.GenreUpDown.Items.Add("Классика");
            this.GenreUpDown.Items.Add("Хип-хоп");
            this.GenreUpDown.Items.Add("Другое");
            this.GenreUpDown.Location = new System.Drawing.Point(12, 148);
            this.GenreUpDown.Name = "GenreUpDown";
            this.GenreUpDown.Size = new System.Drawing.Size(188, 20);
            this.GenreUpDown.TabIndex = 11;
            // 
            // EditDiskButton
            // 
            this.EditDiskButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDiskButton.Location = new System.Drawing.Point(93, 184);
            this.EditDiskButton.Name = "EditDiskButton";
            this.EditDiskButton.Size = new System.Drawing.Size(107, 47);
            this.EditDiskButton.TabIndex = 12;
            this.EditDiskButton.Text = "Редактировать диск";
            this.EditDiskButton.UseVisualStyleBackColor = false;
            this.EditDiskButton.Click += new System.EventHandler(this.EditDiskButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(12, 194);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 37);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 40);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(188, 20);
            this.NameBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Исполнитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Жанр";
            // 
            // EditDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(212, 243);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EditDiskButton);
            this.Controls.Add(this.GenreUpDown);
            this.Controls.Add(this.SingerBox);
            this.Name = "EditDiskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить диск";
            this.Load += new System.EventHandler(this.EditDiskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SingerBox;
        private System.Windows.Forms.DomainUpDown GenreUpDown;
        private System.Windows.Forms.Button EditDiskButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}