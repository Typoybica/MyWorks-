namespace Kursovaya
{
    partial class MainMenu
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
            this.DiskGridView = new System.Windows.Forms.DataGridView();
            this.DiskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiskSinger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiskGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteDiskButton = new System.Windows.Forms.Button();
            this.EditDiskButton = new System.Windows.Forms.Button();
            this.DiskContentButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.GenreUpDown = new System.Windows.Forms.DomainUpDown();
            this.GenreRadioButton = new System.Windows.Forms.RadioButton();
            this.SingerBox = new System.Windows.Forms.TextBox();
            this.SingerRadioButton = new System.Windows.Forms.RadioButton();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DiskGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiskGridView
            // 
            this.DiskGridView.AllowUserToAddRows = false;
            this.DiskGridView.AllowUserToDeleteRows = false;
            this.DiskGridView.AllowUserToResizeColumns = false;
            this.DiskGridView.AllowUserToResizeRows = false;
            this.DiskGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.DiskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiskGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiskName,
            this.DiskSinger,
            this.DiskGenre,
            this.SongQuantity});
            this.DiskGridView.Location = new System.Drawing.Point(12, 12);
            this.DiskGridView.MultiSelect = false;
            this.DiskGridView.Name = "DiskGridView";
            this.DiskGridView.ReadOnly = true;
            this.DiskGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DiskGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiskGridView.ShowEditingIcon = false;
            this.DiskGridView.Size = new System.Drawing.Size(570, 355);
            this.DiskGridView.TabIndex = 0;
            this.DiskGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiskGridView_CellContentClick);
            // 
            // DiskName
            // 
            this.DiskName.HeaderText = "Название";
            this.DiskName.Name = "DiskName";
            this.DiskName.ReadOnly = true;
            // 
            // DiskSinger
            // 
            this.DiskSinger.HeaderText = "Исполнитель";
            this.DiskSinger.Name = "DiskSinger";
            this.DiskSinger.ReadOnly = true;
            // 
            // DiskGenre
            // 
            this.DiskGenre.HeaderText = "Жанр";
            this.DiskGenre.Name = "DiskGenre";
            this.DiskGenre.ReadOnly = true;
            // 
            // SongQuantity
            // 
            this.SongQuantity.HeaderText = "Кол-во композиций";
            this.SongQuantity.Name = "SongQuantity";
            this.SongQuantity.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить диск";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(713, 401);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 37);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteDiskButton
            // 
            this.DeleteDiskButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDiskButton.Location = new System.Drawing.Point(141, 373);
            this.DeleteDiskButton.Name = "DeleteDiskButton";
            this.DeleteDiskButton.Size = new System.Drawing.Size(123, 65);
            this.DeleteDiskButton.TabIndex = 4;
            this.DeleteDiskButton.Text = "Удалить диск";
            this.DeleteDiskButton.UseVisualStyleBackColor = false;
            this.DeleteDiskButton.Click += new System.EventHandler(this.DeleteDiskButton_Click);
            // 
            // EditDiskButton
            // 
            this.EditDiskButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditDiskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDiskButton.Location = new System.Drawing.Point(270, 373);
            this.EditDiskButton.Name = "EditDiskButton";
            this.EditDiskButton.Size = new System.Drawing.Size(123, 65);
            this.EditDiskButton.TabIndex = 5;
            this.EditDiskButton.Text = "Редактировать диск";
            this.EditDiskButton.UseVisualStyleBackColor = false;
            this.EditDiskButton.Click += new System.EventHandler(this.EditDiskButton_Click);
            // 
            // DiskContentButton
            // 
            this.DiskContentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DiskContentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiskContentButton.Location = new System.Drawing.Point(459, 373);
            this.DiskContentButton.Name = "DiskContentButton";
            this.DiskContentButton.Size = new System.Drawing.Size(123, 65);
            this.DiskContentButton.TabIndex = 7;
            this.DiskContentButton.Text = "Содержимое диска";
            this.DiskContentButton.UseVisualStyleBackColor = false;
            this.DiskContentButton.Click += new System.EventHandler(this.DiskContentButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.ClearSearchButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.GenreUpDown);
            this.groupBox1.Controls.Add(this.GenreRadioButton);
            this.groupBox1.Controls.Add(this.SingerBox);
            this.groupBox1.Controls.Add(this.SingerRadioButton);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.NameRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 355);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearSearchButton.Location = new System.Drawing.Point(6, 213);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(188, 65);
            this.ClearSearchButton.TabIndex = 7;
            this.ClearSearchButton.Text = "Отменить критерии поиска";
            this.ClearSearchButton.UseVisualStyleBackColor = false;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Location = new System.Drawing.Point(6, 284);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(188, 65);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // GenreUpDown
            // 
            this.GenreUpDown.Items.Add("Поп");
            this.GenreUpDown.Items.Add("Рок");
            this.GenreUpDown.Items.Add("Рэп");
            this.GenreUpDown.Items.Add("Классика");
            this.GenreUpDown.Items.Add("Хип-хоп");
            this.GenreUpDown.Items.Add("Другое");
            this.GenreUpDown.Location = new System.Drawing.Point(6, 179);
            this.GenreUpDown.Name = "GenreUpDown";
            this.GenreUpDown.Size = new System.Drawing.Size(188, 26);
            this.GenreUpDown.TabIndex = 5;
            // 
            // GenreRadioButton
            // 
            this.GenreRadioButton.AutoSize = true;
            this.GenreRadioButton.Location = new System.Drawing.Point(6, 149);
            this.GenreRadioButton.Name = "GenreRadioButton";
            this.GenreRadioButton.Size = new System.Drawing.Size(94, 24);
            this.GenreRadioButton.TabIndex = 4;
            this.GenreRadioButton.TabStop = true;
            this.GenreRadioButton.Text = "по жанру";
            this.GenreRadioButton.UseVisualStyleBackColor = true;
            // 
            // SingerBox
            // 
            this.SingerBox.Location = new System.Drawing.Point(6, 117);
            this.SingerBox.Name = "SingerBox";
            this.SingerBox.Size = new System.Drawing.Size(188, 26);
            this.SingerBox.TabIndex = 3;
            // 
            // SingerRadioButton
            // 
            this.SingerRadioButton.AutoSize = true;
            this.SingerRadioButton.Location = new System.Drawing.Point(6, 87);
            this.SingerRadioButton.Name = "SingerRadioButton";
            this.SingerRadioButton.Size = new System.Drawing.Size(152, 24);
            this.SingerRadioButton.TabIndex = 2;
            this.SingerRadioButton.TabStop = true;
            this.SingerRadioButton.Text = "по исполнителю";
            this.SingerRadioButton.UseVisualStyleBackColor = true;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 55);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(188, 26);
            this.NameBox.TabIndex = 1;
            // 
            // NameRadioButton
            // 
            this.NameRadioButton.AutoSize = true;
            this.NameRadioButton.Location = new System.Drawing.Point(6, 25);
            this.NameRadioButton.Name = "NameRadioButton";
            this.NameRadioButton.Size = new System.Drawing.Size(123, 24);
            this.NameRadioButton.TabIndex = 0;
            this.NameRadioButton.TabStop = true;
            this.NameRadioButton.Text = "по названию";
            this.NameRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DiskContentButton);
            this.Controls.Add(this.DeleteDiskButton);
            this.Controls.Add(this.EditDiskButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DiskGridView);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталогизатор музыкальных дисков";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiskGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn DiskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiskSinger;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiskGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongQuantity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteDiskButton;
        private System.Windows.Forms.Button EditDiskButton;
        private System.Windows.Forms.Button DiskContentButton;
        private System.Windows.Forms.DataGridView DiskGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown GenreUpDown;
        private System.Windows.Forms.RadioButton GenreRadioButton;
        private System.Windows.Forms.TextBox SingerBox;
        private System.Windows.Forms.RadioButton SingerRadioButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.RadioButton NameRadioButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearSearchButton;
    }
}