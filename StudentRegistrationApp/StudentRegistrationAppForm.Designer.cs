namespace StudentRegistrationApp
{
	partial class StudentRegistrationAppForm
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartmentMajorsCount = new System.Windows.Forms.DataGridView();
            this.buttonBackupDatabase = new System.Windows.Forms.Button();
            this.buttonRestoreDatabaseFromBackup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentMajorsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(68, 55);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 62;
            this.dataGridViewStudents.Size = new System.Drawing.Size(718, 231);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(68, 335);
            this.dataGridViewDepartments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.RowHeadersWidth = 62;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(718, 231);
            this.dataGridViewDepartments.TabIndex = 1;
            // 
            // dataGridViewDepartmentMajorsCount
            // 
            this.dataGridViewDepartmentMajorsCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmentMajorsCount.Location = new System.Drawing.Point(68, 614);
            this.dataGridViewDepartmentMajorsCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDepartmentMajorsCount.Name = "dataGridViewDepartmentMajorsCount";
            this.dataGridViewDepartmentMajorsCount.RowHeadersWidth = 62;
            this.dataGridViewDepartmentMajorsCount.Size = new System.Drawing.Size(718, 231);
            this.dataGridViewDepartmentMajorsCount.TabIndex = 2;
            // 
            // buttonBackupDatabase
            // 
            this.buttonBackupDatabase.Location = new System.Drawing.Point(888, 205);
            this.buttonBackupDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBackupDatabase.Name = "buttonBackupDatabase";
            this.buttonBackupDatabase.Size = new System.Drawing.Size(112, 82);
            this.buttonBackupDatabase.TabIndex = 3;
            this.buttonBackupDatabase.Text = "Backup Database";
            this.buttonBackupDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonRestoreDatabaseFromBackup
            // 
            this.buttonRestoreDatabaseFromBackup.Location = new System.Drawing.Point(888, 351);
            this.buttonRestoreDatabaseFromBackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRestoreDatabaseFromBackup.Name = "buttonRestoreDatabaseFromBackup";
            this.buttonRestoreDatabaseFromBackup.Size = new System.Drawing.Size(112, 82);
            this.buttonRestoreDatabaseFromBackup.TabIndex = 4;
            this.buttonRestoreDatabaseFromBackup.Text = "Restore Database";
            this.buttonRestoreDatabaseFromBackup.UseVisualStyleBackColor = true;
            // 
            // StudentRegistrationAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 943);
            this.Controls.Add(this.buttonRestoreDatabaseFromBackup);
            this.Controls.Add(this.buttonBackupDatabase);
            this.Controls.Add(this.dataGridViewDepartmentMajorsCount);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Controls.Add(this.dataGridViewStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentRegistrationAppForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentMajorsCount)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.DataGridView dataGridViewDepartments;
		private System.Windows.Forms.DataGridView dataGridViewDepartmentMajorsCount;
		private System.Windows.Forms.Button buttonBackupDatabase;
		private System.Windows.Forms.Button buttonRestoreDatabaseFromBackup;
	}
}

