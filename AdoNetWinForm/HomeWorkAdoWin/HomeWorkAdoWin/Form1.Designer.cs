namespace HomeWorkAdoWin
{
	partial class Form1
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
            this.allUsers = new System.Windows.Forms.Button();
            this.adminUsers = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listViewTable = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // allUsers
            // 
            this.allUsers.BackColor = System.Drawing.Color.Aqua;
            this.allUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.allUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.allUsers.Location = new System.Drawing.Point(563, 22);
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(123, 66);
            this.allUsers.TabIndex = 8;
            this.allUsers.Text = "Показать всех";
            this.allUsers.UseVisualStyleBackColor = false;
            this.allUsers.Click += new System.EventHandler(this.AllUsers_Click);
            // 
            // adminUsers
            // 
            this.adminUsers.BackColor = System.Drawing.Color.Purple;
            this.adminUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.adminUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminUsers.Location = new System.Drawing.Point(58, 12);
            this.adminUsers.Name = "adminUsers";
            this.adminUsers.Size = new System.Drawing.Size(141, 64);
            this.adminUsers.TabIndex = 9;
            this.adminUsers.Text = "Показать админов";
            this.adminUsers.UseVisualStyleBackColor = false;
            this.adminUsers.Click += new System.EventHandler(this.AdminUsers_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(326, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 61);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить Юсера";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // listViewTable
            // 
            this.listViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Logo,
            this.Password,
            this.Adres,
            this.Phone_,
            this.Admin});
            this.listViewTable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.listViewTable.ForeColor = System.Drawing.Color.DarkGray;
            this.listViewTable.FullRowSelect = true;
            this.listViewTable.GridLines = true;
            this.listViewTable.Location = new System.Drawing.Point(0, 103);
            this.listViewTable.MultiSelect = false;
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(773, 345);
            this.listViewTable.TabIndex = 11;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.View = System.Windows.Forms.View.Details;
            this.listViewTable.SelectedIndexChanged += new System.EventHandler(this.listViewTable_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 33;
            // 
            // Logo
            // 
            this.Logo.Text = "Logo";
            this.Logo.Width = 84;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 94;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 93;
            // 
            // Phone_
            // 
            this.Phone_.Text = "Phone";
            this.Phone_.Width = 132;
            // 
            // Admin
            // 
            this.Admin.Text = "Admin";
            this.Admin.Width = 133;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 446);
            this.Controls.Add(this.listViewTable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.adminUsers);
            this.Controls.Add(this.allUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button allUsers;
		private System.Windows.Forms.Button adminUsers;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ListView listViewTable;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader Logo;
		private System.Windows.Forms.ColumnHeader Password;
		private System.Windows.Forms.ColumnHeader Adres;
		private System.Windows.Forms.ColumnHeader Phone_;
		private System.Windows.Forms.ColumnHeader Admin;
	}
}

