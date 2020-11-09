using DataTableAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
	public partial class StudentRegistrationAppForm : Form
	{

		// field to keep the access layer field

		private SqlDataTableAccessLayer registrationDB;

		// dataset will hold all tables being used

		private DataSet registrationDataSet;

		public StudentRegistrationAppForm()
		{
			InitializeComponent();

			// form display name

			Text = "Student Registration App";

			// get a new access layer and dataset

			registrationDB = new SqlDataTableAccessLayer();

			registrationDataSet = new DataSet()
			{
				// must be named for backup purposes

				DataSetName = "StudentRegistrationDataSet",
			};

			// YOUR CODE HERE
			// set the connectionString from App.config
			string connectingString = registrationDB.GetConnectionString("StudentRegistrationDB");
			registrationDB.OpenConnection(connectingString);

			// set the form title
			Text = "Student Registration App";

			// associate the datagridview controls with a database table
			// this also adds each table to the dataset

			// make sure Orders is added to database last or database restore will crash
			InitializeDataGridViewAndDataSet(dataGridViewDepartments, registrationDataSet, "Departments");
			InitializeDataGridViewAndDataSet(dataGridViewStudents, registrationDataSet, "Students");

			// DepartmentMajorCount is a view, do not add it to DataSet.Tables
			dataGridViewDepartmentMajorsCount.ReadOnly = true;
			dataGridViewDepartmentMajorsCount.AllowUserToAddRows = false;
			dataGridViewDepartmentMajorsCount.RowHeadersVisible = false;
			dataGridViewDepartmentMajorsCount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewDepartmentMajorsCount.DataSource = registrationDB.GetDataTable("DepartmentMajorCount");

			// Add button event hanlder for database backup to xml
			buttonBackupDatabase.Click += (s, e) => registrationDB.BackupDataSetToXML(registrationDataSet);
			buttonRestoreDatabaseFromBackup.Click += (s, e) => registrationDB.RestoreDataSetFromBackup(registrationDataSet);

			// Ensure that the connection to the db is closed
			this.FormClosing += (s, e) => registrationDB.CloseConnection();
			


		}

        private void InitializeDataGridViewAndDataSet(DataGridView dataGridView, DataSet dataSet, string tableName)
        {
			// Get the table filled with the records from the db
			DataTable table = registrationDB.GetDataTable(tableName);

			// set the datasource to the table
			// when control change, the table will change as well with one of the event below
			// so make sure to handle revelant table change events

			// this auto generates the column name, so no need to set them manually
			dataGridView.DataSource = table;

			// if we have an identity column, anytime a row is added we want the column to be set to -1
			if(table.Columns[0].AutoIncrement == true)
            {
				dataGridView.DefaultValuesNeeded += (s, e) => NewRowBeingAdded(s as DataGridView, e);
            }

			// handle insertion
			table.RowChanged += (s, e) => RegistrationTableRowChanged(e);

			// handle updates
			table.ColumnChanged += (s, e) => RegistrationTableColumnChanged(e);

			// handle deletes 
			table.RowDeleted += (s, e) => RegistrationTableRowDelete(e);

			// auto resize the columns to fill out as much as  possible
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// allow multiple select to allow for deletion of multiple rows
			dataGridView.MultiSelect = true;

			// Add to table to the table collection
			// This is only use for backup and restore
			dataSet.Tables.Add(table);

        }

       

        private void NewRowBeingAdded(DataGridView dataGridView, DataGridViewRowEventArgs e)
        {
			DataTable table = dataGridView.DataSource as DataTable;
			if(table.Columns[0].AutoIncrement == true)
            {
				e.Row.Cells[0].Value = -1;
            }
        }

		private void RegistrationTableRowChanged(DataRowChangeEventArgs e)
		{
			// only insert if there was an Add action. Updates will be handled
			// by ColumnChanged
			if (e.Action == DataRowAction.Add)
			{
				try
				{
					registrationDB.InsertTableRow(e.Row);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Insertion fail: " + ex.Message);
				}

				// updata a lower control, a view
				registrationDB.LoadDataTable(dataGridViewDepartmentMajorsCount.DataSource as DataTable);
			}
		}

		private void RegistrationTableColumnChanged(DataColumnChangeEventArgs e)
		{
			// If the row is in the process of being added (detached), don't update the cells
			
			// only do this if an existing cell is changed
			if(e.Row.RowState != DataRowState.Detached)
            {
				// if this is an identity colum, it is only modified by the db in InsertTableRow()
				// so don't send an update back
				if(e.Column.AutoIncrement == false)
                {
                    // just update the entire row even though just one column was changed
                    // this could be optimized
                    try
                    {
						registrationDB.UpdateTableRow(e.Row);
                    }
					catch (Exception ex)
                    {
						MessageBox.Show(ex.Message);
                    }

					// Update the view (bottom control)
					registrationDB.LoadDataTable(dataGridViewDepartmentMajorsCount.DataSource as DataTable);
                }
            }
		}


		private void RegistrationTableRowDelete(DataRowChangeEventArgs e)
		{
            try
            {
				registrationDB.DeleteTableRow(e.Row);
            }
            catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }

			// updata the lower control (a view)
			registrationDB.LoadDataTable(dataGridViewDepartmentMajorsCount.DataSource as DataTable);

		}

		// YOUR METHODS and CODE HERE
	}
}
