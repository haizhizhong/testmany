using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private TUC_HMDevXManager.TUC_HMDevXManager dxmgr  = new TUC_HMDevXManager.TUC_HMDevXManager();
		private CurrencyManager cm;


		private AccountingPicker.ucAccountingPicker ucAccountingPicker1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private TestApp.DataSet1 dataSet11;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colJOURNAL_ID;
		private DevExpress.XtraGrid.Columns.GridColumn colGL_YEAR;
		private DevExpress.XtraGrid.Columns.GridColumn colPERIOD;
		private DevExpress.XtraGrid.Columns.GridColumn colTRANSACTION_DATE;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton simpleButton3;
		private DevExpress.XtraEditors.SimpleButton simpleButton4;
		private AccountingPicker.ucAccountingPicker ucAccountingPicker2;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraEditors.SimpleButton simpleButton5;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraEditors.SpinEdit spinEdit1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			dxmgr.AppInit("testApp");

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ucAccountingPicker1 = new AccountingPicker.ucAccountingPicker();
			this.dataSet11 = new TestApp.DataSet1();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colJOURNAL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGL_YEAR = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPERIOD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTRANSACTION_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
			this.ucAccountingPicker2 = new AccountingPicker.ucAccountingPicker();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// ucAccountingPicker1
			// 
			this.ucAccountingPicker1.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.ucAccountingPicker1.Appearance.Options.UseBackColor = true;
			this.ucAccountingPicker1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedYear", this.dataSet11, "GL_JOURNAL_HEADERS.GL_YEAR"));
			this.ucAccountingPicker1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedPeriod", this.dataSet11, "GL_JOURNAL_HEADERS.PERIOD"));
			this.ucAccountingPicker1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedEntryDate", this.dataSet11, "GL_JOURNAL_HEADERS.TRANSACTION_DATE"));
			this.ucAccountingPicker1.DataBound = true;
			this.ucAccountingPicker1.LLayout = AccountingPicker.ucAccountingPicker.enmLayout.Horizontal;
			this.ucAccountingPicker1.Location = new System.Drawing.Point(8, 32);
			this.ucAccountingPicker1.Name = "ucAccountingPicker1";
			this.ucAccountingPicker1.SelectedPeriod = 7;
			this.ucAccountingPicker1.Size = new System.Drawing.Size(520, 48);
			this.ucAccountingPicker1.TabIndex = 0;
			this.ucAccountingPicker1.UserName = "hm";
			this.ucAccountingPicker1.Load += new System.EventHandler(this.ucAccountingPicker1_Load);
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=DEV2;packet size=4096;user id=sa;data source=DEV2;persist security" +
				" info=True;initial catalog=TR_RealEstateBeta;password=sa";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "GL_JOURNAL_HEADERS", new System.Data.Common.DataColumnMapping[] {
																																																							new System.Data.Common.DataColumnMapping("JOURNAL_ID", "JOURNAL_ID"),
																																																							new System.Data.Common.DataColumnMapping("JOURNAL_NUMBER", "JOURNAL_NUMBER"),
																																																							new System.Data.Common.DataColumnMapping("GL_YEAR", "GL_YEAR"),
																																																							new System.Data.Common.DataColumnMapping("PERIOD", "PERIOD"),
																																																							new System.Data.Common.DataColumnMapping("MODULE", "MODULE"),
																																																							new System.Data.Common.DataColumnMapping("TYPE", "TYPE"),
																																																							new System.Data.Common.DataColumnMapping("TRANSACTION_DATE", "TRANSACTION_DATE"),
																																																							new System.Data.Common.DataColumnMapping("REFERENCE", "REFERENCE"),
																																																							new System.Data.Common.DataColumnMapping("TOTAL_DEBITS", "TOTAL_DEBITS"),
																																																							new System.Data.Common.DataColumnMapping("TOTAL_CREDITS", "TOTAL_CREDITS"),
																																																							new System.Data.Common.DataColumnMapping("PRINTED", "PRINTED"),
																																																							new System.Data.Common.DataColumnMapping("REVERSED", "REVERSED"),
																																																							new System.Data.Common.DataColumnMapping("CREATED_BY", "CREATED_BY"),
																																																							new System.Data.Common.DataColumnMapping("STATUS", "STATUS"),
																																																							new System.Data.Common.DataColumnMapping("NEXT_LINE_NUMBER", "NEXT_LINE_NUMBER"),
																																																							new System.Data.Common.DataColumnMapping("OPERATOR", "OPERATOR"),
																																																							new System.Data.Common.DataColumnMapping("DATE_SAVED", "DATE_SAVED"),
																																																							new System.Data.Common.DataColumnMapping("EXPIRE_PERIOD", "EXPIRE_PERIOD"),
																																																							new System.Data.Common.DataColumnMapping("EXPIRE_YEAR", "EXPIRE_YEAR"),
																																																							new System.Data.Common.DataColumnMapping("F9_UPDATED", "F9_UPDATED")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM GL_JOURNAL_HEADERS WHERE (JOURNAL_ID = @Original_JOURNAL_ID) AND (CREATED_BY = @Original_CREATED_BY) AND (DATE_SAVED = @Original_DATE_SAVED OR @Original_DATE_SAVED IS NULL AND DATE_SAVED IS NULL) AND (EXPIRE_PERIOD = @Original_EXPIRE_PERIOD OR @Original_EXPIRE_PERIOD IS NULL AND EXPIRE_PERIOD IS NULL) AND (EXPIRE_YEAR = @Original_EXPIRE_YEAR OR @Original_EXPIRE_YEAR IS NULL AND EXPIRE_YEAR IS NULL) AND (F9_UPDATED = @Original_F9_UPDATED OR @Original_F9_UPDATED IS NULL AND F9_UPDATED IS NULL) AND (GL_YEAR = @Original_GL_YEAR) AND (JOURNAL_NUMBER = @Original_JOURNAL_NUMBER) AND (MODULE = @Original_MODULE) AND (NEXT_LINE_NUMBER = @Original_NEXT_LINE_NUMBER) AND (OPERATOR = @Original_OPERATOR OR @Original_OPERATOR IS NULL AND OPERATOR IS NULL) AND (PERIOD = @Original_PERIOD) AND (PRINTED = @Original_PRINTED) AND (REFERENCE = @Original_REFERENCE OR @Original_REFERENCE IS NULL AND REFERENCE IS NULL) AND (REVERSED = @Original_REVERSED) AND (STATUS = @Original_STATUS) AND (TOTAL_CREDITS = @Original_TOTAL_CREDITS) AND (TOTAL_DEBITS = @Original_TOTAL_DEBITS) AND (TRANSACTION_DATE = @Original_TRANSACTION_DATE) AND (TYPE = @Original_TYPE)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_JOURNAL_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "JOURNAL_ID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CREATED_BY", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CREATED_BY", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_DATE_SAVED", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DATE_SAVED", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EXPIRE_PERIOD", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EXPIRE_PERIOD", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EXPIRE_YEAR", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EXPIRE_YEAR", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_F9_UPDATED", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "F9_UPDATED", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GL_YEAR", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GL_YEAR", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_JOURNAL_NUMBER", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "JOURNAL_NUMBER", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_MODULE", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MODULE", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_NEXT_LINE_NUMBER", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NEXT_LINE_NUMBER", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OPERATOR", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OPERATOR", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PERIOD", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PERIOD", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PRINTED", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PRINTED", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_REFERENCE", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "REFERENCE", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_REVERSED", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "REVERSED", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_STATUS", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "STATUS", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TOTAL_CREDITS", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TOTAL_CREDITS", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TOTAL_DEBITS", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TOTAL_DEBITS", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TRANSACTION_DATE", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TRANSACTION_DATE", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TYPE", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TYPE", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO GL_JOURNAL_HEADERS(JOURNAL_ID, JOURNAL_NUMBER, GL_YEAR, PERIOD, MODULE, TYPE, TRANSACTION_DATE, REFERENCE, TOTAL_DEBITS, TOTAL_CREDITS, PRINTED, REVERSED, CREATED_BY, STATUS, NEXT_LINE_NUMBER, OPERATOR, DATE_SAVED, EXPIRE_PERIOD, EXPIRE_YEAR, F9_UPDATED) VALUES (@JOURNAL_ID, @JOURNAL_NUMBER, @GL_YEAR, @PERIOD, @MODULE, @TYPE, @TRANSACTION_DATE, @REFERENCE, @TOTAL_DEBITS, @TOTAL_CREDITS, @PRINTED, @REVERSED, @CREATED_BY, @STATUS, @NEXT_LINE_NUMBER, @OPERATOR, @DATE_SAVED, @EXPIRE_PERIOD, @EXPIRE_YEAR, @F9_UPDATED); SELECT JOURNAL_ID, JOURNAL_NUMBER, GL_YEAR, PERIOD, MODULE, TYPE, TRANSACTION_DATE, REFERENCE, TOTAL_DEBITS, TOTAL_CREDITS, PRINTED, REVERSED, CREATED_BY, STATUS, NEXT_LINE_NUMBER, OPERATOR, DATE_SAVED, EXPIRE_PERIOD, EXPIRE_YEAR, F9_UPDATED FROM GL_JOURNAL_HEADERS WHERE (JOURNAL_ID = @JOURNAL_ID)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@JOURNAL_ID", System.Data.SqlDbType.Int, 4, "JOURNAL_ID"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@JOURNAL_NUMBER", System.Data.SqlDbType.Int, 4, "JOURNAL_NUMBER"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GL_YEAR", System.Data.SqlDbType.Int, 4, "GL_YEAR"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PERIOD", System.Data.SqlDbType.Int, 4, "PERIOD"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MODULE", System.Data.SqlDbType.VarChar, 20, "MODULE"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TYPE", System.Data.SqlDbType.VarChar, 1, "TYPE"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TRANSACTION_DATE", System.Data.SqlDbType.DateTime, 8, "TRANSACTION_DATE"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@REFERENCE", System.Data.SqlDbType.VarChar, 40, "REFERENCE"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TOTAL_DEBITS", System.Data.SqlDbType.Money, 8, "TOTAL_DEBITS"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TOTAL_CREDITS", System.Data.SqlDbType.Money, 8, "TOTAL_CREDITS"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PRINTED", System.Data.SqlDbType.VarChar, 1, "PRINTED"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@REVERSED", System.Data.SqlDbType.VarChar, 1, "REVERSED"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CREATED_BY", System.Data.SqlDbType.VarChar, 40, "CREATED_BY"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@STATUS", System.Data.SqlDbType.VarChar, 1, "STATUS"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NEXT_LINE_NUMBER", System.Data.SqlDbType.Int, 4, "NEXT_LINE_NUMBER"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OPERATOR", System.Data.SqlDbType.VarChar, 10, "OPERATOR"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@DATE_SAVED", System.Data.SqlDbType.DateTime, 8, "DATE_SAVED"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EXPIRE_PERIOD", System.Data.SqlDbType.Int, 4, "EXPIRE_PERIOD"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EXPIRE_YEAR", System.Data.SqlDbType.Int, 4, "EXPIRE_YEAR"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@F9_UPDATED", System.Data.SqlDbType.VarChar, 1, "F9_UPDATED"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = @"SELECT JOURNAL_ID, JOURNAL_NUMBER, GL_YEAR, PERIOD, MODULE, TYPE, TRANSACTION_DATE, REFERENCE, TOTAL_DEBITS, TOTAL_CREDITS, PRINTED, REVERSED, CREATED_BY, STATUS, NEXT_LINE_NUMBER, OPERATOR, DATE_SAVED, EXPIRE_PERIOD, EXPIRE_YEAR, F9_UPDATED FROM GL_JOURNAL_HEADERS";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE GL_JOURNAL_HEADERS SET JOURNAL_ID = @JOURNAL_ID, JOURNAL_NUMBER = @JOURNAL" +
				"_NUMBER, GL_YEAR = @GL_YEAR, PERIOD = @PERIOD, MODULE = @MODULE, TYPE = @TYPE, T" +
				"RANSACTION_DATE = @TRANSACTION_DATE, REFERENCE = @REFERENCE, TOTAL_DEBITS = @TOT" +
				"AL_DEBITS, TOTAL_CREDITS = @TOTAL_CREDITS, PRINTED = @PRINTED, REVERSED = @REVER" +
				"SED, CREATED_BY = @CREATED_BY, STATUS = @STATUS, NEXT_LINE_NUMBER = @NEXT_LINE_N" +
				"UMBER, OPERATOR = @OPERATOR, DATE_SAVED = @DATE_SAVED, EXPIRE_PERIOD = @EXPIRE_P" +
				"ERIOD, EXPIRE_YEAR = @EXPIRE_YEAR, F9_UPDATED = @F9_UPDATED WHERE (JOURNAL_ID = " +
				"@Original_JOURNAL_ID) AND (CREATED_BY = @Original_CREATED_BY) AND (DATE_SAVED = " +
				"@Original_DATE_SAVED OR @Original_DATE_SAVED IS NULL AND DATE_SAVED IS NULL) AND" +
				" (EXPIRE_PERIOD = @Original_EXPIRE_PERIOD OR @Original_EXPIRE_PERIOD IS NULL AND" +
				" EXPIRE_PERIOD IS NULL) AND (EXPIRE_YEAR = @Original_EXPIRE_YEAR OR @Original_EX" +
				"PIRE_YEAR IS NULL AND EXPIRE_YEAR IS NULL) AND (F9_UPDATED = @Original_F9_UPDATE" +
				"D OR @Original_F9_UPDATED IS NULL AND F9_UPDATED IS NULL) AND (GL_YEAR = @Origin" +
				"al_GL_YEAR) AND (JOURNAL_NUMBER = @Original_JOURNAL_NUMBER) AND (MODULE = @Origi" +
				"nal_MODULE) AND (NEXT_LINE_NUMBER = @Original_NEXT_LINE_NUMBER) AND (OPERATOR = " +
				"@Original_OPERATOR OR @Original_OPERATOR IS NULL AND OPERATOR IS NULL) AND (PERI" +
				"OD = @Original_PERIOD) AND (PRINTED = @Original_PRINTED) AND (REFERENCE = @Origi" +
				"nal_REFERENCE OR @Original_REFERENCE IS NULL AND REFERENCE IS NULL) AND (REVERSE" +
				"D = @Original_REVERSED) AND (STATUS = @Original_STATUS) AND (TOTAL_CREDITS = @Or" +
				"iginal_TOTAL_CREDITS) AND (TOTAL_DEBITS = @Original_TOTAL_DEBITS) AND (TRANSACTI" +
				"ON_DATE = @Original_TRANSACTION_DATE) AND (TYPE = @Original_TYPE); SELECT JOURNA" +
				"L_ID, JOURNAL_NUMBER, GL_YEAR, PERIOD, MODULE, TYPE, TRANSACTION_DATE, REFERENCE" +
				", TOTAL_DEBITS, TOTAL_CREDITS, PRINTED, REVERSED, CREATED_BY, STATUS, NEXT_LINE_" +
				"NUMBER, OPERATOR, DATE_SAVED, EXPIRE_PERIOD, EXPIRE_YEAR, F9_UPDATED FROM GL_JOU" +
				"RNAL_HEADERS WHERE (JOURNAL_ID = @JOURNAL_ID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@JOURNAL_ID", System.Data.SqlDbType.Int, 4, "JOURNAL_ID"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@JOURNAL_NUMBER", System.Data.SqlDbType.Int, 4, "JOURNAL_NUMBER"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@GL_YEAR", System.Data.SqlDbType.Int, 4, "GL_YEAR"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PERIOD", System.Data.SqlDbType.Int, 4, "PERIOD"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@MODULE", System.Data.SqlDbType.VarChar, 20, "MODULE"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TYPE", System.Data.SqlDbType.VarChar, 1, "TYPE"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TRANSACTION_DATE", System.Data.SqlDbType.DateTime, 8, "TRANSACTION_DATE"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@REFERENCE", System.Data.SqlDbType.VarChar, 40, "REFERENCE"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TOTAL_DEBITS", System.Data.SqlDbType.Money, 8, "TOTAL_DEBITS"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TOTAL_CREDITS", System.Data.SqlDbType.Money, 8, "TOTAL_CREDITS"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PRINTED", System.Data.SqlDbType.VarChar, 1, "PRINTED"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@REVERSED", System.Data.SqlDbType.VarChar, 1, "REVERSED"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CREATED_BY", System.Data.SqlDbType.VarChar, 40, "CREATED_BY"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@STATUS", System.Data.SqlDbType.VarChar, 1, "STATUS"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@NEXT_LINE_NUMBER", System.Data.SqlDbType.Int, 4, "NEXT_LINE_NUMBER"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OPERATOR", System.Data.SqlDbType.VarChar, 10, "OPERATOR"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@DATE_SAVED", System.Data.SqlDbType.DateTime, 8, "DATE_SAVED"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EXPIRE_PERIOD", System.Data.SqlDbType.Int, 4, "EXPIRE_PERIOD"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EXPIRE_YEAR", System.Data.SqlDbType.Int, 4, "EXPIRE_YEAR"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@F9_UPDATED", System.Data.SqlDbType.VarChar, 1, "F9_UPDATED"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_JOURNAL_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "JOURNAL_ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CREATED_BY", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CREATED_BY", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_DATE_SAVED", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DATE_SAVED", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EXPIRE_PERIOD", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EXPIRE_PERIOD", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EXPIRE_YEAR", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EXPIRE_YEAR", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_F9_UPDATED", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "F9_UPDATED", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_GL_YEAR", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "GL_YEAR", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_JOURNAL_NUMBER", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "JOURNAL_NUMBER", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_MODULE", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MODULE", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_NEXT_LINE_NUMBER", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NEXT_LINE_NUMBER", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OPERATOR", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OPERATOR", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PERIOD", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PERIOD", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PRINTED", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PRINTED", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_REFERENCE", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "REFERENCE", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_REVERSED", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "REVERSED", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_STATUS", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "STATUS", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TOTAL_CREDITS", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TOTAL_CREDITS", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TOTAL_DEBITS", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TOTAL_DEBITS", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TRANSACTION_DATE", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TRANSACTION_DATE", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TYPE", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TYPE", System.Data.DataRowVersion.Original, null));
			// 
			// gridControl1
			// 
			this.gridControl1.DataMember = "GL_JOURNAL_HEADERS";
			this.gridControl1.DataSource = this.dataSet11;
			// 
			// gridControl1.EmbeddedNavigator
			// 
			this.gridControl1.EmbeddedNavigator.Name = "";
			this.gridControl1.Location = new System.Drawing.Point(8, 144);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(576, 232);
			this.gridControl1.TabIndex = 1;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																										this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
																							 this.colJOURNAL_ID,
																							 this.colGL_YEAR,
																							 this.colPERIOD,
																							 this.colTRANSACTION_DATE});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// colJOURNAL_ID
			// 
			this.colJOURNAL_ID.Caption = "JOURNAL_ID";
			this.colJOURNAL_ID.FieldName = "JOURNAL_ID";
			this.colJOURNAL_ID.Name = "colJOURNAL_ID";
			this.colJOURNAL_ID.Visible = true;
			this.colJOURNAL_ID.VisibleIndex = 0;
			this.colJOURNAL_ID.Width = 99;
			// 
			// colGL_YEAR
			// 
			this.colGL_YEAR.Caption = "GL_YEAR";
			this.colGL_YEAR.FieldName = "GL_YEAR";
			this.colGL_YEAR.Name = "colGL_YEAR";
			this.colGL_YEAR.Visible = true;
			this.colGL_YEAR.VisibleIndex = 1;
			this.colGL_YEAR.Width = 99;
			// 
			// colPERIOD
			// 
			this.colPERIOD.Caption = "PERIOD";
			this.colPERIOD.FieldName = "PERIOD";
			this.colPERIOD.Name = "colPERIOD";
			this.colPERIOD.Visible = true;
			this.colPERIOD.VisibleIndex = 2;
			this.colPERIOD.Width = 99;
			// 
			// colTRANSACTION_DATE
			// 
			this.colTRANSACTION_DATE.Caption = "TRANSACTION_DATE";
			this.colTRANSACTION_DATE.FieldName = "TRANSACTION_DATE";
			this.colTRANSACTION_DATE.Name = "colTRANSACTION_DATE";
			this.colTRANSACTION_DATE.Visible = true;
			this.colTRANSACTION_DATE.VisibleIndex = 3;
			this.colTRANSACTION_DATE.Width = 128;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(16, 384);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(120, 23);
			this.simpleButton1.TabIndex = 2;
			this.simpleButton1.Text = "ReadOnly----Property";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(144, 384);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(144, 23);
			this.simpleButton2.TabIndex = 3;
			this.simpleButton2.Text = "HasEntryDate---- Property";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// simpleButton3
			// 
			this.simpleButton3.Location = new System.Drawing.Point(304, 384);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new System.Drawing.Size(112, 23);
			this.simpleButton3.TabIndex = 4;
			this.simpleButton3.Text = "LLayout----Property";
			this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
			// 
			// simpleButton4
			// 
			this.simpleButton4.Location = new System.Drawing.Point(424, 384);
			this.simpleButton4.Name = "simpleButton4";
			this.simpleButton4.Size = new System.Drawing.Size(144, 23);
			this.simpleButton4.TabIndex = 5;
			this.simpleButton4.Text = "Type---Property";
			this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
			// 
			// ucAccountingPicker2
			// 
			this.ucAccountingPicker2.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.ucAccountingPicker2.Appearance.Options.UseBackColor = true;
			this.ucAccountingPicker2.Location = new System.Drawing.Point(608, 152);
			this.ucAccountingPicker2.Name = "ucAccountingPicker2";
			this.ucAccountingPicker2.SelectedPeriod = 0;
			this.ucAccountingPicker2.Size = new System.Drawing.Size(176, 120);
			this.ucAccountingPicker2.TabIndex = 6;
			this.ucAccountingPicker2.UserName = "";
			// 
			// textEdit1
			// 
			this.textEdit1.EditValue = "packet size=4096;user id=hmsqlsa;data source=Dev2;persist security info=True;init" +
				"ial catalog= TR_Comco;password=hmsqlsa;";
			this.textEdit1.Location = new System.Drawing.Point(32, 24);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Size = new System.Drawing.Size(720, 20);
			this.textEdit1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "TreasuryConnectionString";
			// 
			// simpleButton5
			// 
			this.simpleButton5.Location = new System.Drawing.Point(760, 24);
			this.simpleButton5.Name = "simpleButton5";
			this.simpleButton5.TabIndex = 9;
			this.simpleButton5.Text = "Connect";
			this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.spinEdit1);
			this.panelControl1.Controls.Add(this.textEdit2);
			this.panelControl1.Controls.Add(this.label4);
			this.panelControl1.Controls.Add(this.label3);
			this.panelControl1.Controls.Add(this.label2);
			this.panelControl1.Controls.Add(this.ucAccountingPicker2);
			this.panelControl1.Controls.Add(this.simpleButton2);
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Controls.Add(this.gridControl1);
			this.panelControl1.Controls.Add(this.simpleButton4);
			this.panelControl1.Controls.Add(this.simpleButton3);
			this.panelControl1.Controls.Add(this.ucAccountingPicker1);
			this.panelControl1.Location = new System.Drawing.Point(0, 80);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(896, 440);
			this.panelControl1.TabIndex = 10;
			this.panelControl1.Text = "panelControl1";
			this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
			// 
			// spinEdit1
			// 
			this.spinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataSet11, "GL_JOURNAL_HEADERS.GL_YEAR"));
			this.spinEdit1.EditValue = new System.Decimal(new int[] {
																		0,
																		0,
																		0,
																		0});
			this.spinEdit1.Location = new System.Drawing.Point(600, 80);
			this.spinEdit1.Name = "spinEdit1";
			// 
			// spinEdit1.Properties
			// 
			this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
																											  new DevExpress.XtraEditors.Controls.EditorButton()});
			this.spinEdit1.TabIndex = 12;
			this.spinEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spinEdit1_EditValueChanging);
			this.spinEdit1.EditValueChanged += new System.EventHandler(this.spinEdit1_EditValueChanged);
			// 
			// textEdit2
			// 
			this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataSet11, "GL_JOURNAL_HEADERS.GL_YEAR"));
			this.textEdit2.Location = new System.Drawing.Point(600, 48);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(576, 368);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(296, 32);
			this.label4.TabIndex = 9;
			this.label4.Text = "***buttons show what the properties do, they are only tied to the databound accou" +
				"nting picker";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(616, 128);
			this.label3.Name = "label3";
			this.label3.TabIndex = 8;
			this.label3.Text = "Not DataBound";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "DataBound";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(896, 518);
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.simpleButton5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textEdit1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			
			dxmgr.FormInit(this);
			//this.panelControl1.Visible = false;
		}

		private void simpleButton1_Click(object sender, System.EventArgs e)
		{
			this.ucAccountingPicker1.ReadOnly = !this.ucAccountingPicker1.ReadOnly;
			this.ucAccountingPicker2.ConnectionString =  this.ucAccountingPicker1.ConnectionString;
		}

		private void simpleButton2_Click(object sender, System.EventArgs e)
		{
			this.ucAccountingPicker1.HasEntryDate = !ucAccountingPicker1.HasEntryDate;
			
		}

		private void simpleButton3_Click(object sender, System.EventArgs e)
		{
			if(this.ucAccountingPicker1.LLayout == AccountingPicker.ucAccountingPicker.enmLayout.Horizontal)
				this.ucAccountingPicker1.LLayout = AccountingPicker.ucAccountingPicker.enmLayout.Vertical;
			else
				this.ucAccountingPicker1.LLayout = AccountingPicker.ucAccountingPicker.enmLayout.Horizontal;
		}

		private void simpleButton4_Click(object sender, System.EventArgs e)
		{
			if(this.ucAccountingPicker1.Type == AccountingPicker.ucAccountingPicker.enmType.GL)
				this.ucAccountingPicker1.Type = AccountingPicker.ucAccountingPicker.enmType.Subledger;
			else
				this.ucAccountingPicker1.Type = AccountingPicker.ucAccountingPicker.enmType.GL;
		}

		
		private void simpleButton5_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				dataSet11.Tables[0].Rows.Clear();
				this.sqlDataAdapter1.SelectCommand.Connection.ConnectionString = this.textEdit1.Text;
				this.sqlDataAdapter1.Fill(dataSet11);
				cm = ((CurrencyManager)BindingContext[dataSet11,"GL_JOURNAL_HEADERS"]);
				cm.Refresh();

				for(int index = 0; index < cm.Bindings.Count; index++)
				{
					if(cm.Bindings[index].Control != null)
					{
						MessageBox.Show(cm.Bindings[index].Control.Name);
					}
				}
				
				this.ucAccountingPicker1.ConnectionString = this.textEdit1.Text;
				this.ucAccountingPicker2.ConnectionString = this.ucAccountingPicker1.ConnectionString;
				//this.panelControl1.Visible = true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message + ex.StackTrace);
			}
			this.gridView1.RefreshData();

		}

		private void panelControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void ucAccountingPicker1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void spinEdit1_EditValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void spinEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
		{
			
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			
		}
	}
}
