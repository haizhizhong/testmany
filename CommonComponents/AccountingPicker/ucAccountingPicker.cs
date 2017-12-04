using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Reflection;
namespace AccountingPicker
{
	
	
	/// <summary>
	/// Summary description for ucAccountingPicker.
	/// </summary>
	public class ucAccountingPicker : DevExpress.XtraEditors.XtraUserControl
	{
		private TUC_HMDevXManager.TUC_HMDevXManager dxmgr = null;
		public enum enmLayout
		{
			Vertical,
			Horizontal
		}
		public enum enmType
		{
			Subledger,
			GL
		}

		string filePathName = System.Windows.Forms.Application.StartupPath + "\\WebConnection.txt";
		private DataSet ds_years;
		private DataSet ds_periods;
		private System.Windows.Forms.Panel pnlYear;
		private System.Windows.Forms.Panel pnlPeriod;
		private System.Windows.Forms.Label lblPeriod;
		private System.Windows.Forms.Panel pnlEntryDate;
		private System.Windows.Forms.Label lblEntryDate;
		private DevExpress.XtraEditors.SimpleButton btnPeriodLookup;
		public DevExpress.XtraEditors.DateEdit editEntryDate;
		private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
		public DevExpress.XtraEditors.GridLookUpEdit editPeriod;
		private DevExpress.XtraGrid.Columns.GridColumn colPeriodOpen;
		private DevExpress.XtraGrid.Columns.GridColumn colPeriod;
		private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkPeriodOpen;
		public DevExpress.XtraEditors.GridLookUpEdit editYear;
		private DevExpress.XtraGrid.Columns.GridColumn colYear;
		private DevExpress.XtraGrid.Views.Grid.GridView gvYear;
		private DevExpress.XtraGrid.Columns.GridColumn colOpen;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditYearOpen;
		private System.Windows.Forms.Label lblYear;

		private void InitializeComponent()
		{
            this.lblYear = new System.Windows.Forms.Label();
            this.pnlYear = new System.Windows.Forms.Panel();
            this.editYear = new DevExpress.XtraEditors.GridLookUpEdit();
            this.repositoryItemCheckEditYearOpen = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gvYear = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlPeriod = new System.Windows.Forms.Panel();
            this.editPeriod = new DevExpress.XtraEditors.GridLookUpEdit();
            this.chkPeriodOpen = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodOpen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPeriodLookup = new DevExpress.XtraEditors.SimpleButton();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.pnlEntryDate = new System.Windows.Forms.Panel();
            this.editEntryDate = new DevExpress.XtraEditors.DateEdit();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.pnlYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditYearOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvYear)).BeginInit();
            this.pnlPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.pnlEntryDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editEntryDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEntryDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(5, 8);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 16);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Acct Year";
            // 
            // pnlYear
            // 
            this.pnlYear.Controls.Add(this.editYear);
            this.pnlYear.Controls.Add(this.lblYear);
            this.pnlYear.Location = new System.Drawing.Point(8, 0);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(168, 32);
            this.pnlYear.TabIndex = 2;
            // 
            // editYear
            // 
            this.editYear.EditValue = 0;
            this.editYear.Location = new System.Drawing.Point(65, 5);
            this.editYear.Name = "editYear";
            this.editYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editYear.Properties.DisplayMember = "Year";
            this.editYear.Properties.NullText = "";
            this.editYear.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditYearOpen});
            this.editYear.Properties.ValueMember = "Year";
            this.editYear.Properties.View = this.gvYear;
            this.editYear.Properties.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.editYear_Properties_CloseUp);
            this.editYear.Size = new System.Drawing.Size(100, 20);
            this.editYear.TabIndex = 2;
            this.editYear.EditValueChanged += new System.EventHandler(this.editYear_EditValueChanged);
            this.editYear.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.edits_QueryPopUp);
            // 
            // repositoryItemCheckEditYearOpen
            // 
            this.repositoryItemCheckEditYearOpen.AutoHeight = false;
            this.repositoryItemCheckEditYearOpen.Name = "repositoryItemCheckEditYearOpen";
            this.repositoryItemCheckEditYearOpen.ValueChecked = "T";
            this.repositoryItemCheckEditYearOpen.ValueUnchecked = "F";
            // 
            // gvYear
            // 
            this.gvYear.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYear,
            this.colOpen});
            this.gvYear.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvYear.Name = "gvYear";
            this.gvYear.OptionsBehavior.Editable = false;
            this.gvYear.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvYear.OptionsView.ShowGroupPanel = false;
            // 
            // colYear
            // 
            this.colYear.Caption = "Year";
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 0;
            // 
            // colOpen
            // 
            this.colOpen.Caption = "Open";
            this.colOpen.ColumnEdit = this.repositoryItemCheckEditYearOpen;
            this.colOpen.FieldName = "Open";
            this.colOpen.Name = "colOpen";
            this.colOpen.Visible = true;
            this.colOpen.VisibleIndex = 1;
            // 
            // pnlPeriod
            // 
            this.pnlPeriod.Controls.Add(this.editPeriod);
            this.pnlPeriod.Controls.Add(this.btnPeriodLookup);
            this.pnlPeriod.Controls.Add(this.lblPeriod);
            this.pnlPeriod.Location = new System.Drawing.Point(8, 32);
            this.pnlPeriod.Name = "pnlPeriod";
            this.pnlPeriod.Size = new System.Drawing.Size(168, 32);
            this.pnlPeriod.TabIndex = 3;
            // 
            // editPeriod
            // 
            this.editPeriod.EditValue = 0;
            this.editPeriod.Location = new System.Drawing.Point(65, 5);
            this.editPeriod.Name = "editPeriod";
            this.editPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editPeriod.Properties.NullText = "";
            this.editPeriod.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkPeriodOpen});
            this.editPeriod.Properties.View = this.gridLookUpEdit1View;
            this.editPeriod.Properties.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.editPeriod_Properties_CloseUp);
            this.editPeriod.Size = new System.Drawing.Size(75, 20);
            this.editPeriod.TabIndex = 3;
            this.editPeriod.EditValueChanged += new System.EventHandler(this.editPeriod_EditValueChanged);
            this.editPeriod.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.edits_QueryPopUp);
            // 
            // chkPeriodOpen
            // 
            this.chkPeriodOpen.AutoHeight = false;
            this.chkPeriodOpen.Name = "chkPeriodOpen";
            this.chkPeriodOpen.ValueChecked = "T";
            this.chkPeriodOpen.ValueUnchecked = "F";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPeriod,
            this.colEndDate,
            this.colPeriodOpen});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colPeriod
            // 
            this.colPeriod.Caption = "Period";
            this.colPeriod.FieldName = "PERIOD";
            this.colPeriod.MinWidth = 10;
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.OptionsColumn.AllowEdit = false;
            this.colPeriod.Visible = true;
            this.colPeriod.VisibleIndex = 0;
            this.colPeriod.Width = 21;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "Month";
            this.colEndDate.FieldName = "END_DATE";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.OptionsColumn.AllowEdit = false;
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 1;
            this.colEndDate.Width = 50;
            // 
            // colPeriodOpen
            // 
            this.colPeriodOpen.Caption = "Open";
            this.colPeriodOpen.ColumnEdit = this.chkPeriodOpen;
            this.colPeriodOpen.FieldName = "PERIOD_OPEN";
            this.colPeriodOpen.MinWidth = 10;
            this.colPeriodOpen.Name = "colPeriodOpen";
            this.colPeriodOpen.OptionsColumn.AllowEdit = false;
            this.colPeriodOpen.Visible = true;
            this.colPeriodOpen.VisibleIndex = 2;
            this.colPeriodOpen.Width = 20;
            // 
            // btnPeriodLookup
            // 
            this.btnPeriodLookup.Location = new System.Drawing.Point(145, 5);
            this.btnPeriodLookup.Name = "btnPeriodLookup";
            this.btnPeriodLookup.Size = new System.Drawing.Size(20, 20);
            this.btnPeriodLookup.TabIndex = 2;
            this.btnPeriodLookup.Text = "...";
            this.btnPeriodLookup.Click += new System.EventHandler(this.btnPeriodLookup_Click);
            // 
            // lblPeriod
            // 
            this.lblPeriod.Location = new System.Drawing.Point(5, 8);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(57, 16);
            this.lblPeriod.TabIndex = 1;
            this.lblPeriod.Text = "Period";
            // 
            // pnlEntryDate
            // 
            this.pnlEntryDate.Controls.Add(this.editEntryDate);
            this.pnlEntryDate.Controls.Add(this.lblEntryDate);
            this.pnlEntryDate.Location = new System.Drawing.Point(8, 66);
            this.pnlEntryDate.Name = "pnlEntryDate";
            this.pnlEntryDate.Size = new System.Drawing.Size(168, 32);
            this.pnlEntryDate.TabIndex = 4;
            // 
            // editEntryDate
            // 
            this.editEntryDate.EditValue = null;
            this.editEntryDate.Location = new System.Drawing.Point(65, 5);
            this.editEntryDate.Name = "editEntryDate";
            this.editEntryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editEntryDate.Properties.Mask.EditMask = "";
            this.editEntryDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.editEntryDate.Size = new System.Drawing.Size(100, 20);
            this.editEntryDate.TabIndex = 2;
            this.editEntryDate.EditValueChanged += new System.EventHandler(this.editEntryDate_EditValueChanged);
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.Location = new System.Drawing.Point(5, 8);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(67, 17);
            this.lblEntryDate.TabIndex = 1;
            this.lblEntryDate.Text = "Entry Date";
            // 
            // ucAccountingPicker
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Controls.Add(this.pnlEntryDate);
            this.Controls.Add(this.pnlYear);
            this.Controls.Add(this.pnlPeriod);
            this.Name = "ucAccountingPicker";
            this.Size = new System.Drawing.Size(184, 112);
            this.Load += new System.EventHandler(this.ucAccountingPicker_Load);
            this.pnlYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditYearOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvYear)).EndInit();
            this.pnlPeriod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPeriodOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.pnlEntryDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editEntryDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editEntryDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
	
		public ucAccountingPicker()
		{
			this.InitializeComponent();//initalizes component during design time
			ds_years = new DataSet();
			ds_periods = new DataSet();
		}
		//----------------------------------------------------------------------------------
		#region ---Properties--- 
		//----------------------------------------------------------------------------------
		private bool _isDataBound = false;
		[Browsable(true),DefaultValue(false)]
		public bool DataBound
		{
			set
			{
				_isDataBound = value;
			}
			get
			{
				return _isDataBound;
			}
		}

		private bool _AllowClosedSelection = false;
		[Browsable(true),DefaultValue(false)]
		public bool AllowClosedSelection
		{
			set
			{
				_AllowClosedSelection = value;
			}
			get
			{
				return _AllowClosedSelection;
			}
		}



		[Browsable(false),DefaultValue(null)]
		[Bindable(true)]
		public int SelectedYear
		{
			set
			{
                this.editYear.EditValue = (object)value;
				this.FillPeriodsComboBox();
			}
			get
			{
				if(this.editYear.EditValue == null)return 0;
				if(this.editYear.EditValue == DBNull.Value)return 0;
				return Convert.ToInt32(this.editYear.EditValue);
			}
		}

		//[Bindable(System.ComponentModel.BindableSupport.Yes)]
		[Browsable(false),DefaultValue(null)]
		[Bindable(true)]
		public int SelectedPeriod
		{
			set{this.editPeriod.EditValue = (object)value;}
			get{if(this.editPeriod.EditValue == null)return 0;
				if(this.editPeriod.EditValue == DBNull.Value)return 0;
				return Convert.ToInt32(this.editPeriod.EditValue);}
		}

		[Browsable(false)]
		[Bindable(true),DefaultValue(null)]
		public object SelectedEntryDate
		{			
			set{this.editEntryDate.EditValue = value;}
			get{return this.editEntryDate.EditValue;}
		}

        [Browsable(false)]
        public object SelectedPeriodName
        {
           get { return this.editPeriod.Text; }
        }
       
	
		//-------------------------------PUBLIC---------------------------------------------
		
		private string m_user = "";
		[Category("HM_Properties")]
		[Description("The \"Name\" column in the ml_users table")]
		public string UserName
		{
			get{return m_user;}
			set
			{
				m_user = value;
				if(!DesignMode)
					this.setSecurity();
			}
		}


		private string m_conString = "";
		[Category("HM_Properties")]
		[Description("Connection string to a TR database")]	
		[Browsable(true),DefaultValue("")]
		public string ConnectionString
		{
			get{return m_conString;}
			set
			{
                m_conString = value;
				try
				{
					if(value != "")
					{
						SqlCommand cmd = new SqlCommand();
						cmd.Connection = new SqlConnection(value);
						cmd.Connection.Open();
						cmd.Connection.Close();
						this.Enabled = true;
						
					}
				}
				catch
				{
					System.Windows.Forms.MessageBox.Show("Unable to establish a connection to Treasury Database","Invalid Connection String",
						System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
					value = "";
				}
				if(!DesignMode)
				{
					this.setDefaults();
					this.setSecurity();
				}
				
			}
		}

		
		private enmType m_type;
		[Category("HM_Properties")]
		[Description("Allows you to choose weather this is for the General Ledger(GL) or Subledger")]	
		[Browsable(true),DefaultValue(enmType.Subledger)]
		public enmType Type
		{
			get{return m_type;}
			set
			{
				m_type = value;
				this.setDefaults();
			}
		}


		private enmLayout m_layout;
		[Category("HM_Properties")]
		[Description("Allows you to choose how the control is displayed")]	
		[Browsable(true),DefaultValue(enmLayout.Vertical)]
		public enmLayout LLayout
		{
			get{return m_layout;}
			set{m_layout = value;
				switch(value)
				{
					case enmLayout.Vertical:
						if(m_hasEntryDate)
							this.Size = new System.Drawing.Size(184, 112);
						else
							this.Size = new System.Drawing.Size(184,80);
						this.pnlYear.Location = new System.Drawing.Point(8, 0);
						this.pnlPeriod.Location = new System.Drawing.Point(8, 32);
						this.pnlEntryDate.Location = new System.Drawing.Point(8, 66);
						break;
					case enmLayout.Horizontal:
						if(m_hasEntryDate)
							this.Size = new System.Drawing.Size(520, 48);
						else
							this.Size = new System.Drawing.Size(352,48);
						this.pnlYear.Location = new System.Drawing.Point(8, 0);
						this.pnlPeriod.Location = new System.Drawing.Point(176, 0);
						this.pnlEntryDate.Location = new System.Drawing.Point(344, 0);
						break;
					
				}
				
			}
		}

	
		private bool m_hasEntryDate = true;
		[Category("HM_Properties")]
		[Description("Allows you to choose weather EntryDate is visible within the control")]	
		[Browsable(true),DefaultValue(true)]
		public bool HasEntryDate
		{
			get{return m_hasEntryDate;}
			set
			{
				m_hasEntryDate = value;
				this.pnlEntryDate.Visible = value;
				if(value)
				{
					if(this.m_layout == enmLayout.Horizontal)
						this.Size = new System.Drawing.Size(520,48);
					else if(this.m_layout == enmLayout.Vertical)
						this.Size = new System.Drawing.Size(184,112);	

				}
				else
				{
					if(this.m_layout == enmLayout.Horizontal)
						this.Size = new System.Drawing.Size(352,48);
					else if(this.m_layout == enmLayout.Vertical)
						this.Size = new System.Drawing.Size(184,80);

				}
				
			
			}
		}


		private bool m_readOnly = false;
		[Category("HM_Properties")]
		[Description("Removes the buttons from the comboboxes when set to true")]	
		[Browsable(true),DefaultValue(false)]
		public bool ReadOnly
		{
			get{return m_readOnly;}
			set
			{
				m_readOnly = value;
				this.editYear.Properties.Buttons[0].Visible = (!value);
				this.editYear.Properties.ReadOnly = value;

				this.editPeriod.Properties.Buttons[0].Visible = (!value);
				this.editPeriod.Properties.ReadOnly = value;

				this.editEntryDate.Properties.Buttons[0].Visible = (!value);
				this.editEntryDate.Properties.ReadOnly = value;

				this.btnPeriodLookup.Enabled = (!value);
			}
		}




		#endregion ---Properties---
		//----------------------------------------------------------------------------------
	
		#region ---Functions & Methods---
		internal bool FillPeriodsComboBox()
		{
			bool returnValue = false;
			string dataFeild = "";
			string dataTable = "";
			if(this.m_conString == "")return returnValue;
			if(this.editYear.EditValue.ToString() == "")return returnValue;
			//if(this.DataSource == null)return;
			//if(this.DataMember == null)return;
			switch(this.Type)
			{
				case enmType.GL:
					dataFeild = "GL_Year";
					dataTable = "GL_Periods";
					break;
				case enmType.Subledger:
					dataFeild = "AR_Year";
					dataTable = "AR_Periods";
					break;
			}
			
			try
			{
				SqlDataAdapter da = new SqlDataAdapter();
				SqlConnection conn = new SqlConnection(this.ConnectionString);
				
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandText = "select PERIOD,DATENAME(mm,END_DATE) as END_DATE,PERIOD_OPEN from "+ dataTable +" where "+dataFeild+" = "+ this.SelectedYear;//+
				da.SelectCommand = cmd;
				ds_periods.Clear();
				da.Fill(ds_periods);
			}
			catch(SqlException ex)
			{
				System.Windows.Forms.MessageBox.Show("Error in FillPeriodsComboBox : " + ex.Message);
			}
		

		
			this.editPeriod.Properties.DataSource = ds_periods.Tables[0];
			this.editPeriod.Properties.DisplayMember = "END_DATE";
			this.editPeriod.Properties.ValueMember = "PERIOD";
			
			if(_isDataBound)return true;

            if (this.editPeriod.EditValue != null)
            {

                DataRow[] rows;
                rows = ds_periods.Tables[0].Select("PERIOD =" + this.editPeriod.EditValue);
                if (rows.Length > 0)
                    if (rows[0]["PERIOD_OPEN"].ToString() == "F")
                    {
                        this.SelectedPeriod = 0;
                        foreach (DataRow row in ds_periods.Tables[0].Rows)
                        {
                            if (row["PERIOD_OPEN"].ToString() == "T")
                            {
                                this.SelectedPeriod = (int)row["PERIOD"];
                                break;
                            }
                        }
                        if (this.SelectedPeriod == 0 && !_AllowClosedSelection)
                        {
                            System.Windows.Forms.MessageBox.Show("There are no periods open in this year");
                            returnValue = false;
                            this.setDefaults();

                        }
                        else
                            returnValue = true;

                    }

            }
            else
            {

                this.SelectedPeriod = 0;
                foreach (DataRow row in ds_periods.Tables[0].Rows)
                {
                    if (row["PERIOD_OPEN"].ToString() == "T")
                    {
                        this.SelectedPeriod = (int)row["PERIOD"];
                        break;
                    }
                }
                if (this.SelectedPeriod == 0 && !_AllowClosedSelection)
                {
                    System.Windows.Forms.MessageBox.Show("There are no periods open in this year");
                    returnValue = false;
                    this.setDefaults();
                }
                else
                    returnValue = true;

            }

			return returnValue;
			

		}

		internal void FillYearsComboBox()
		{	
			string dataFeild = "";
			string dataTable = "";
			if(this.m_conString == "")return;

			switch(this.Type)
			{
				case enmType.GL:
					dataFeild = "GL_Year";
					dataTable = "GL_Periods";
					break;
				case enmType.Subledger:
					dataFeild = "AR_Year";
					dataTable = "AR_Periods";
					break;
			}
			
			try
			{
				SqlDataAdapter da = new SqlDataAdapter();
				SqlConnection conn = new SqlConnection(this.ConnectionString);
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandText = "select distinct "+dataFeild +"[Year] , case when " +
				"(select distinct GL_Year from gl_year_end_jnl_headers where gl_year = dt."+dataFeild +") is null "+
				"then 'T' else 'F'end[Open] from "+ dataTable + " dt order by dt."+dataFeild +" desc";
				da.SelectCommand = cmd;
				ds_years.Clear();
				da.Fill(ds_years);
				if(ds_years.Tables[0].Rows.Count > 0)
				{
					this.editYear.Properties.DataSource = ds_years.Tables[0];
				}
			}
			catch(SqlException ex)
			{
				System.Windows.Forms.MessageBox.Show("Fill Years Error" + ex.Message);
			}
			

		}


		//-------------------------------PUBLIC---------------------------------------------

		[Description("sets default settings in periods and year dropdown box\r\nREQUIRES: Connectionstring property to be set")]
		public void setDefaults()
		{
			
			string setupTable = "";
			if(this.m_conString == "")return;
			this.FillYearsComboBox();
			switch(this.Type)
			{
				case enmType.GL:
					setupTable = "GL_Setup";
					break;
				case enmType.Subledger:
					setupTable = "AR_Setup";
					break;
			}
			

			
			if(_isDataBound)return;
			int period = 0;
			int year = 0;
			SqlDataAdapter da = new SqlDataAdapter();
			DataSet ds = new DataSet();
			SqlConnection conn = new SqlConnection(this.ConnectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = conn;
			cmd.CommandText = "select CURRENT_YEAR,CURRENT_PERIOD from "+ setupTable;
			da.SelectCommand = cmd;
			try
			{
				da.Fill(ds);
			}
			catch(SqlException ex)
			{
				System.Windows.Forms.MessageBox.Show("Unable to get the default Period\r\n\r\n"+ ex.Message+ "\r\n " +ex.StackTrace);
			}

			if(ds.Tables.Count > 0)
				if(ds.Tables[0].Rows.Count > 0)
				{	
					try
					{
								
						year = Convert.ToInt32(ds.Tables[0].Rows[0]["CURRENT_YEAR"].ToString());
						this.SelectedYear = year;
						//this.FillPeriodsComboBox();
						period = Convert.ToInt32(ds.Tables[0].Rows[0]["CURRENT_PERIOD"].ToString());
						this.SelectedPeriod = period;
					}
					catch(InvalidCastException ex)
					{
						if(ds.Tables[0].Rows[0]["CURRENT_YEAR"] == DBNull.Value || ds.Tables[0].Rows[0]["CURRENT_PERIOD"] == DBNull.Value)
							System.Windows.Forms.MessageBox.Show("Default "+Type.ToString()+" Period not setup");
						else
							System.Windows.Forms.MessageBox.Show("Unable to get the default Period\r\nValue returned is:\r\nYear = "+ds.Tables[0].Rows[0]["CURRENT_YEAR"].ToString()+"\r\nPeriod ="+ds.Tables[0].Rows[0]["CURRENT_PERIOD"].ToString()+"\r\n\r\n"+ ex.Message+ "\r\n " +ex.StackTrace);
					}
					catch(System.FormatException ex)
					{
						if(ds.Tables[0].Rows[0]["CURRENT_YEAR"] == DBNull.Value || ds.Tables[0].Rows[0]["CURRENT_PERIOD"] == DBNull.Value)
							System.Windows.Forms.MessageBox.Show("Default "+Type.ToString()+" Period not setup");
						else
							System.Windows.Forms.MessageBox.Show("Unable to get the default Period\r\nValue returned is:\r\nYear = "+ds.Tables[0].Rows[0]["CURRENT_YEAR"].ToString()+"\r\nPeriod ="+ds.Tables[0].Rows[0]["CURRENT_PERIOD"].ToString()+"\r\n\r\n"+ ex.Message+ "\r\n " +ex.StackTrace);
					}
							
				}
			this.editEntryDate.EditValue = DateTime.Now;
		

		}

		[Description("sets the visibility of the periods lookup button\r\nREQUIRES: ConnectionString and User properties to be set")]
		public void setSecurity()
		{
			this.btnPeriodLookup.Visible = true;


			if(m_user == "")
				this.btnPeriodLookup.Visible = false;
			else
				this.btnPeriodLookup.Visible = File.Exists(filePathName);
			System.Windows.Forms.Application.DoEvents();

			if(this.btnPeriodLookup.Visible && this.ConnectionString != "" && this.dxmgr != null)
			{//if it is still visible check to see if they have security rights to it
				//select department from mluser where name = 'greg'
				
				try
				{

					SqlCommand cmd = new SqlCommand();
					cmd.Connection = new SqlConnection(this.ConnectionString);
					cmd.CommandText = "select department from MlUser where Name='"+ m_user +"'";
					cmd.Connection.Open();
					string department = "";
					if(cmd.ExecuteScalar() != null)
					{
						department = cmd.ExecuteScalar().ToString();
					}
					cmd.Connection.Close();

					if(department != "")
					{
						string returnValue;
						//used to check for security( what user has access to see and edit)
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.CommandText = "sp_UserLedgerAccess";
						cmd.Parameters.Add("@User",typeof(string));
						cmd.Parameters["@User"].Value = m_user; 
						
				

						cmd.Connection.Open();

						returnValue = (string)cmd.ExecuteScalar();

						if(returnValue == "GL")
							this.btnPeriodLookup.Visible = true;
						else if(returnValue == "SL")
							this.btnPeriodLookup.Visible = true;
						else
							this.btnPeriodLookup.Visible = false;
					}


				}
				catch(SqlException ex)
				{
					System.Windows.Forms.MessageBox.Show("Error Checking Security" + ex.Message);
					this.btnPeriodLookup.Visible = false; //make button not visible if an error occures

				}
			}
			else
				this.btnPeriodLookup.Visible = false;

		}


		private bool setDevXmanager()
		{
			bool FoundAndSet = false;
			System.Windows.Forms.Control ctrl = this;
			
			while(ctrl.Parent != null)
			{
				if(ctrl.Parent is System.Windows.Forms.UserControl)
				{
					FoundAndSet = findDevXManager(ctrl.Parent);
				}
				else if(ctrl.Parent is System.Windows.Forms.Form)
				{
					FoundAndSet = findDevXManager(ctrl.Parent);
				}
				if(FoundAndSet)
					break;
				ctrl = ctrl.Parent;
			}


			return FoundAndSet;
		}
		private bool findDevXManager(System.Windows.Forms.Control FormOrUserControl)
		{
			
			bool found = false;
			object tucMgrObj = null;
			//searches for the TUC_HMDevXManager and sets its value
			foreach (FieldInfo myFieldInfo in 
				FormOrUserControl.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance ))
			{
				if (myFieldInfo.FieldType.ToString() == "TUC_HMDevXManager.TUC_HMDevXManager")  
				{//finds and sets the TUC manager
					tucMgrObj = myFieldInfo.GetValue(FormOrUserControl);
					break;
				}
				
			}

			if(tucMgrObj != null)
			{
				this.dxmgr = (TUC_HMDevXManager.TUC_HMDevXManager)tucMgrObj;
				found = true;
			}
			
			return found;

		}

		
		#endregion
		//----------------------------------------------------------------------------------
		
		#region---Events Used---
	
		private void btnPeriodLookup_Click(object sender, System.EventArgs e)
		{
			if(this.ConnectionString != "")
			{
				//  WebConnection.txt
				StreamReader sReader = File.OpenText(filePathName);
				string webServer = "";
				string webDBName = "";
				int companyID = 0;
				
				
				
				try
				{
					webServer = sReader.ReadLine();
					webDBName = sReader.ReadLine();
					sReader.Close();
					int trIndex = this.ConnectionString.ToUpper().IndexOf("TR_");
					int trEndIndex = this.ConnectionString.IndexOf(";",trIndex);
					string trDBName = this.ConnectionString.Substring(trIndex,(trEndIndex-trIndex));
                    HMConnection.HMCon con = new HMConnection.HMCon();
                    SqlConnection conn = new SqlConnection(con.GetConnectionString(webServer,webDBName));
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = conn;
					cmd.CommandText = "select AutoID from COMPANIES where TreasuryDBName = '"+ trDBName +"'";
					cmd.Connection.Open();
					if(cmd.ExecuteScalar() != null)
					{
						companyID = (int)cmd.ExecuteScalar();
					}
					cmd.Connection.Close();
				}
				catch(SqlException ex)
				{
					System.Windows.Forms.MessageBox.Show(ex.Message);
				}
					
					
				HMConnection.HMCon conObject = new HMConnection.HMCon(webDBName,webServer,companyID,m_user);
				using(PeriodsAdmin pdsAdmin = new PeriodsAdmin(conObject,dxmgr))
				{
					pdsAdmin.ShowDialog();
				}
				this.setDefaults();


				

			}
			
		}

		private void edits_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = this.ReadOnly;
		}
		
		private void editPeriod_Properties_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
		{
			if(ds_periods.Tables.Count > 0)
			{
				DataRow[] dr =  ds_periods.Tables[0].Select("PERIOD = " + e.Value +" and PERIOD_OPEN = 'T' ");
				if(dr.Length == 0 && !_AllowClosedSelection)
				{
					System.Windows.Forms.MessageBox.Show("Please select an open period");
					e.AcceptValue = false;
					
				}
				else
				{
					if(this.editPeriod.EditValue != null)
						this.SelectedPeriod = Convert.ToInt32(e.Value.ToString());
				}
			}
		
		}
		
		private void editYear_Properties_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
		{
			
			if(ds_years.Tables.Count > 0)
			{
				DataRow[] dr =  ds_years.Tables[0].Select("Year = " + e.Value +" and Open = 'T' ");
				if(dr.Length == 0 && !_AllowClosedSelection)
				{
					System.Windows.Forms.MessageBox.Show("Please select an open year");
					e.AcceptValue = false;
				}
				else
				{
					if(this.editYear.EditValue != null)
						this.SelectedYear = Convert.ToInt32(e.Value.ToString());
					e.AcceptValue = this.FillPeriodsComboBox();
				}
			}
			
			
		}

		private void ucAccountingPicker_Load(object sender, System.EventArgs e)
		{
			if(!DesignMode)
			{
				this.btnPeriodLookup.Visible = false;//make button not visible 
				if(setDevXmanager())
				{
					this.setSecurity();	//this will set buttons visibility
					dxmgr.FormInit(this);
				}
				if(this.ConnectionString == "")
					this.Enabled = false;
				this.setDefaults();
			}
		}
		
//		private void ucAccountingPicker_VisibleChanged(object sender, System.EventArgs e)
//		{
//			if(this.Visible)
//				this.setSecurity();
//		}

		#endregion---Events Used---

		#region eventsAdded

		public delegate void SelectedYearChangedDelegate(object sender,System.EventArgs e);
		[Description("Thrown on editvalue changed for the year editbox")]
		public event SelectedYearChangedDelegate SelectedYearChanged;
		private void editYear_EditValueChanged(object sender, System.EventArgs e)
		{
			if(SelectedYearChanged != null)
				SelectedYearChanged(sender,e);
		}

		public delegate void SelectedPeriodChangedDelegate(object sender,System.EventArgs e);
		[Description("Thrown on editvalue changed for the Period editbox")]
		public event SelectedPeriodChangedDelegate SelectedPeriodChanged;
		private void editPeriod_EditValueChanged(object sender, System.EventArgs e)
		{
			if(SelectedPeriodChanged != null)
				SelectedPeriodChanged(sender,e);
		}

		public delegate void SelectedEntryDateChangedDelegate(object sender,System.EventArgs e);
		[Description("Thrown on editvalue changed for the EntryDate editbox")]
		public event SelectedEntryDateChangedDelegate SelectedEntryDateChanged;
		private void editEntryDate_EditValueChanged(object sender, System.EventArgs e)
		{
			if(SelectedEntryDateChanged != null)
				SelectedEntryDateChanged(sender,e);
		}

		#endregion eventsAdded
		
		
	

	

		
		//----------------------------------------------------------------------------------
		}
}
