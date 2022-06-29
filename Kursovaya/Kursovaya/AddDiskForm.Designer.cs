namespace Kursovaya
{
    partial class AddDiskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SingerBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.GenreUpDown = new System.Windows.Forms.DomainUpDown();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddDiskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Исполнитель";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Жанр";
            // 
            // SingerBox
            // 
            this.SingerBox.Location = new System.Drawing.Point(181, 57);
            this.SingerBox.Name = "SingerBox";
            this.SingerBox.Size = new System.Drawing.Size(120, 20);
            this.SingerBox.TabIndex = 3;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(181, 22);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(120, 20);
            this.NameBox.TabIndex = 4;
            // 
            // GenreUpDown
            // 
            this.GenreUpDown.Items.Add("Поп");
            this.GenreUpDown.Items.Add("Рок");
            this.GenreUpDown.Items.Add("Рэп");
            this.GenreUpDown.Items.Add("Классика");
            this.GenreUpDown.Items.Add("Хип-хоп");
            this.GenreUpDown.Items.Add("Другое");
            this.GenreUpDown.Location = new System.Drawing.Point(181, 90);
            this.GenreUpDown.Name = "GenreUpDown";
            this.GenreUpDown.Size = new System.Drawing.Size(120, 20);
            this.GenreUpDown.TabIndex = 5;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(12, 133);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 44);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddDiskButton
            // 
            this.AddDiskButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDiskButton.Location = new System.Drawing.Point(207, 133);
            this.AddDiskButton.Name = "AddDiskButton";
            this.AddDiskButton.Size = new System.Drawing.Size(94, 44);
            this.AddDiskButton.TabIndex = 7;
            this.AddDiskButton.Text = "Добавить";
            this.AddDiskButton.UseVisualStyleBackColor = false;
            this.AddDiskButton.Click += new System.EventHandler(this.AddDiskButton_Click);
            // 
            // AddDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 189);
            this.Controls.Add(this.AddDiskButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GenreUpDown);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SingerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDiskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить диск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SingerBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.DomainUpDown GenreUpDown;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddDiskButton;
    }
}