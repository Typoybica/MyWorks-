namespace Kursovaya
{
    partial class DiskViewForm
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
            this.SongGridView = new System.Windows.Forms.DataGridView();
            this.DiskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddSongButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteSongButton = new System.Windows.Forms.Button();
            this.EditSongButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SongGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SongGridView
            // 
            this.SongGridView.AllowUserToAddRows = false;
            this.SongGridView.AllowUserToDeleteRows = false;
            this.SongGridView.AllowUserToResizeColumns = false;
            this.SongGridView.AllowUserToResizeRows = false;
            this.SongGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.SongGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiskName,
            this.Duration});
            this.SongGridView.Location = new System.Drawing.Point(12, 12);
            this.SongGridView.MultiSelect = false;
            this.SongGridView.Name = "SongGridView";
            this.SongGridView.ReadOnly = true;
            this.SongGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SongGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SongGridView.Size = new System.Drawing.Size(532, 355);
            this.SongGridView.TabIndex = 1;
            // 
            // DiskName
            // 
            this.DiskName.HeaderText = "Название";
            this.DiskName.Name = "DiskName";
            this.DiskName.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Длительность";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // AddSongButton
            // 
            this.AddSongButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSongButton.Location = new System.Drawing.Point(12, 373);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.Size = new System.Drawing.Size(123, 65);
            this.AddSongButton.TabIndex = 8;
            this.AddSongButton.Text = "Добавить композицию";
            this.AddSongButton.UseVisualStyleBackColor = false;
            this.AddSongButton.Click += new System.EventHandler(this.AddSongButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(469, 401);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 37);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Назад";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteSongButton
            // 
            this.DeleteSongButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSongButton.Location = new System.Drawing.Point(141, 373);
            this.DeleteSongButton.Name = "DeleteSongButton";
            this.DeleteSongButton.Size = new System.Drawing.Size(123, 65);
            this.DeleteSongButton.TabIndex = 10;
            this.DeleteSongButton.Text = "Удалить композицию";
            this.DeleteSongButton.UseVisualStyleBackColor = false;
            this.DeleteSongButton.Click += new System.EventHandler(this.DeleteSongButton_Click);
            // 
            // EditSongButton
            // 
            this.EditSongButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditSongButton.Location = new System.Drawing.Point(270, 373);
            this.EditSongButton.Name = "EditSongButton";
            this.EditSongButton.Size = new System.Drawing.Size(123, 65);
            this.EditSongButton.TabIndex = 11;
            this.EditSongButton.Text = "Редактировать композицию";
            this.EditSongButton.UseVisualStyleBackColor = false;
            this.EditSongButton.Click += new System.EventHandler(this.EditSongButton_Click);
            // 
            // DiskViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.EditSongButton);
            this.Controls.Add(this.DeleteSongButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddSongButton);
            this.Controls.Add(this.SongGridView);
            this.Name = "DiskViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Содержимое диска";
            this.Load += new System.EventHandler(this.DiskViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SongGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SongGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteSongButton;
        private System.Windows.Forms.Button EditSongButton;
    }
}