using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid ;
namespace AccessSecurity
{
	/// <summary>
	/// Summary description for frmSecurity.
	/// </summary>
	public class frmSecurity : System.Windows.Forms.Form
	{
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.Bar bar1;
		private System.Data.SqlClient.SqlConnection sqlConnWeb;
		private System.Data.SqlClient.SqlDataAdapter daInstance;
		private DevExpress.XtraGrid.Columns.GridColumn colActive;
		private DevExpress.XtraGrid.Columns.GridColumn colTargetType;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnModify;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cbWidget;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cbActive;
		private DevExpress.XtraGrid.GridControl gcInstance;
		private DevExpress.XtraGrid.Views.Grid.GridView gvInstance;
		private DevExpress.XtraEditors.PanelControl pcInstance;
		private DevExpress.XtraGrid.Columns.GridColumn colCompany_Name;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private AccessSecurity.dsInstance dsInstance1;
		private DevExpress.XtraGrid.Columns.GridColumn colTargetName;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private bool securityEnabled = true;
		private DataTable DataSource;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSecurity( HMConnection.HMCon  conn ,  TUC_HMDevXManager.TUC_HMDevXManager tuc_HMDevXManager,int sq_id,bool _securityEnabled,DataTable _datasource )
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.DataSource = _datasource;
			this.securityEnabled = _securityEnabled;
			this.hmConn = conn;
			this.HMDevXManager1 = tuc_HMDevXManager ;
			this.sQueryID = sq_id;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSecurity));
			this.dsInstance1 = new AccessSecurity.dsInstance();
			this.gvInstance = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cbActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colTargetType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnModify = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.colCompany_Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTargetName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcInstance = new DevExpress.XtraGrid.GridControl();
			this.cbWidget = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.barManager1 = new DevExpress.XtraBars.BarManager();
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.sqlConnWeb = new System.Data.SqlClient.SqlConnection();
			this.daInstance = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.pcInstance = new DevExpress.XtraEditors.PanelControl();
			((System.ComponentModel.ISupportInitialize)(this.dsInstance1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvInstance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbActive)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnModify)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcInstance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbWidget)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcInstance)).BeginInit();
			this.pcInstance.SuspendLayout();
			this.SuspendLayout();
			// 
			// dsInstance1
			// 
			this.dsInstance1.DataSetName = "dsInstance";
			this.dsInstance1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// gvInstance
			// 
			this.gvInstance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
																							  this.colActive,
																							  this.colTargetType,
																							  this.gridColumn1,
																							  this.colCompany_Name,
																							  this.colTargetName});
			this.gvInstance.GridControl = this.gcInstance;
			this.gvInstance.GroupCount = 1;
			this.gvInstance.Name = "gvInstance";
			this.gvInstance.OptionsBehavior.AutoExpandAllGroups = true;
			this.gvInstance.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
																									   new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCompany_Name, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// colActive
			// 
			this.colActive.Caption = "Active";
			this.colActive.ColumnEdit = this.cbActive;
			this.colActive.FieldName = "Active";
			this.colActive.Name = "colActive";
			this.colActive.Visible = true;
			this.colActive.VisibleIndex = 2;
			this.colActive.Width = 182;
			// 
			// cbActive
			// 
			this.cbActive.AutoHeight = false;
			this.cbActive.Name = "cbActive";
			this.cbActive.ValueGrayed = false;
			this.cbActive.EditValueChanged += new System.EventHandler(this.cbActive_EditValueChanged);
			// 
			// colTargetType
			// 
			this.colTargetType.Caption = "Target Type";
			this.colTargetType.FieldName = "TargetType";
			this.colTargetType.Name = "colTargetType";
			this.colTargetType.OptionsColumn.ReadOnly = true;
			this.colTargetType.Visible = true;
			this.colTargetType.VisibleIndex = 0;
			this.colTargetType.Width = 241;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Modify";
			this.gridColumn1.ColumnEdit = this.btnModify;
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.OptionsColumn.ShowCaption = false;
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 3;
			this.gridColumn1.Width = 191;
			// 
			// btnModify
			// 
			this.btnModify.AutoHeight = false;
			this.btnModify.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
																								   new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Modify", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null)});
			this.btnModify.Name = "btnModify";
			this.btnModify.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// colCompany_Name
			// 
			this.colCompany_Name.Caption = "Company";
			this.colCompany_Name.FieldName = "Company_Name";
			this.colCompany_Name.Name = "colCompany_Name";
			this.colCompany_Name.OptionsColumn.ReadOnly = true;
			// 
			// colTargetName
			// 
			this.colTargetName.Caption = "Target";
			this.colTargetName.FieldName = "TargetName";
			this.colTargetName.Name = "colTargetName";
			this.colTargetName.OptionsColumn.ReadOnly = true;
			this.colTargetName.Visible = true;
			this.colTargetName.VisibleIndex = 1;
			this.colTargetName.Width = 265;
			// 
			// gcInstance
			// 
			this.gcInstance.DataMember = "Security_Instance";
			this.gcInstance.DataSource = this.dsInstance1;
			this.gcInstance.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// gcInstance.EmbeddedNavigator
			// 
			this.gcInstance.EmbeddedNavigator.Name = "";
			this.gcInstance.Location = new System.Drawing.Point(2, 2);
			this.gcInstance.MainView = this.gvInstance;
			this.gcInstance.Name = "gcInstance";
			this.gcInstance.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
																												this.btnModify,
																												this.cbWidget,
																												this.cbActive});
			this.gcInstance.Size = new System.Drawing.Size(900, 556);
			this.gcInstance.TabIndex = 0;
			this.gcInstance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
																									  this.gvInstance});
			// 
			// cbWidget
			// 
			this.cbWidget.AutoHeight = false;
			this.cbWidget.Name = "cbWidget";
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
																			 this.bar1});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
																				  this.barButtonItem1,
																				  this.barButtonItem2});
			this.barManager1.MainMenu = this.bar1;
			this.barManager1.MaxItemId = 2;
			// 
			// bar1
			// 
			this.bar1.BarName = "Custom 1";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 0;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
																							  new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
																							  new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
			this.bar1.OptionsBar.MultiLine = true;
			this.bar1.OptionsBar.UseWholeRow = true;
			this.bar1.Text = "Custom 1";
			this.bar1.VisibleChanged += new System.EventHandler(this.bar1_VisibleChanged);
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "New Security";
			this.barButtonItem1.Id = 0;
			this.barButtonItem1.Name = "barButtonItem1";
			this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "Exit";
			this.barButtonItem2.Id = 1;
			this.barButtonItem2.Name = "barButtonItem2";
			this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
			// 
			// sqlConnWeb
			// 
			this.sqlConnWeb.ConnectionString = "workstation id=YING;packet size=4096;user id=hmsqlsa;data source=YING;persist sec" +
				"urity info=True;initial catalog=Web_WS;password=hmsqlsa";
			// 
			// daInstance
			// 
			this.daInstance.SelectCommand = this.sqlSelectCommand1;
			this.daInstance.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								 new System.Data.Common.DataTableMapping("Table", "Security_Instance", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("id", "id"),
																																																					  new System.Data.Common.DataColumnMapping("SQ_ID", "SQ_ID"),
																																																					  new System.Data.Common.DataColumnMapping("Target", "Target"),
																																																					  new System.Data.Common.DataColumnMapping("Source", "Source"),
																																																					  new System.Data.Common.DataColumnMapping("CompanyID", "CompanyID"),
																																																					  new System.Data.Common.DataColumnMapping("Active", "Active"),
																																																					  new System.Data.Common.DataColumnMapping("TargetType", "TargetType"),
																																																					  new System.Data.Common.DataColumnMapping("isWidget", "isWidget"),
																																																					  new System.Data.Common.DataColumnMapping("Company_Name", "Company_Name"),
																																																					  new System.Data.Common.DataColumnMapping("TargetDesc", "TargetDesc"),
																																																					  new System.Data.Common.DataColumnMapping("WidgetName", "WidgetName"),
																																																					  new System.Data.Common.DataColumnMapping("TargetName", "TargetName")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = @"SELECT i.id, i.SQ_ID, i.Target, i.Source, i.CompanyID, i.Active, i.TargetType, i.isWidget, c.Company_Name, i.TargetDesc, w.WidgetName, CASE WHEN isnull(iswidget , 0) = 1 THEN widgetName ELSE targetDesc END AS TargetName FROM Security_Instance i INNER JOIN COMPANIES c ON i.CompanyID = c.AutoID LEFT OUTER JOIN Security_Widget w ON i.Target = CONVERT (varchar(20), w.id) WHERE (i.Source = @source) AND (ISNULL(i.isWidget, 0) = @isWidget) AND (i.SQ_ID = @SQ_ID) ORDER BY i.TargetType, CASE WHEN isnull(iswidget , 0) = 1 THEN widgetName ELSE targetDesc END";
			this.sqlSelectCommand1.Connection = this.sqlConnWeb;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@source", System.Data.SqlDbType.VarChar, 100, "Source"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SQ_ID", System.Data.SqlDbType.Int, 4, "SQ_ID"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@isWidget", System.Data.SqlDbType.Variant));
			// 
			// pcInstance
			// 
			this.pcInstance.Controls.Add(this.gcInstance);
			this.pcInstance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pcInstance.Location = new System.Drawing.Point(0, 22);
			this.pcInstance.Name = "pcInstance";
			this.pcInstance.Size = new System.Drawing.Size(904, 560);
			this.pcInstance.TabIndex = 4;
			this.pcInstance.Text = "panelControl1";
			// 
			// frmSecurity
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(904, 582);
			this.Controls.Add(this.pcInstance);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSecurity";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard Security";
			this.Load += new System.EventHandler(this.frmSecurity_Load);
			this.Closed += new System.EventHandler(this.frmSecurity_Closed);
			this.VisibleChanged += new System.EventHandler(this.frmSecurity_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.dsInstance1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvInstance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbActive)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnModify)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcInstance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbWidget)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcInstance)).EndInit();
			this.pcInstance.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		#region  Variables declared here

		public DevExpress.XtraGrid.GridControl  gcSelected;
		private DevExpress.XtraGrid.Views.Grid.GridView  gvSelected;
		private string LoginName;			
	

		private string webDB   = "";
		private string webServer ="";
	
		
		public int sQueryID = 0;
        public Control OriginalParent;
       
	
		private HMConnection.HMCon  hmConn ;
		private TUC_HMDevXManager.TUC_HMDevXManager HMDevXManager1 ;

		private int InstanceID   = -1 ;

		public bool iswidget   = false ;

		// Popups
		public WS_Popups.frmPopup  Popups ; 
		private int iMsgScreen_Width = 210 ;
		private int iMsgScreen_Height = 136;
       
		// Popups 


		
		#endregion

		

		private void frmSecurity_Load(object sender, System.EventArgs e)
        {
			this.webDB = this.hmConn.WebDB ;
			this.webServer = this.hmConn.WebServer; 
			this.LoginName = this.hmConn.MLUser ;
			this.gvSelected = (GridView)this.gcSelected.MainView;
			this.sqlConnWeb.ConnectionString = this.hmConn.WebConnection ;

            this.OriginalParent = this.gcSelected.Parent;
			this.Popups = new WS_Popups.frmPopup(this.HMDevXManager1);
			this.Popups.PopupSize = new Size ( this.iMsgScreen_Width, this.iMsgScreen_Height );
            ActivateSecInstance ();  
			
		}

		private void btnModify_Click(object sender, System.EventArgs e)
		{
			if  (this.gvInstance.GetDataRow(this.gvInstance.FocusedRowHandle)["active"].ToString() != "True")
			{
				this.Popups.ShowPopup(this,"Inactive security instance cannot be modified.", "Infomation",WS_Popups.frmPopup.PopupType.OK);
				return;
			}

			if  (this.gvInstance.GetDataRow(this.gvInstance.FocusedRowHandle)["active"].ToString() == "True")
			{
				InstanceID = Convert.ToInt32(this.gvInstance.GetDataRow(this.gvInstance.FocusedRowHandle)["id"].ToString());
			
				ManageSecurity (InstanceID);
			}
		}

		private void ManageSecurity (int  si_id )
		{
									
			DashboardSecurity.ucMain dashSecurity= new DashboardSecurity.ucMain();
			dashSecurity.Parent = this;
			dashSecurity.Dock =System.Windows.Forms.DockStyle.Fill;
			dashSecurity.Visible = true;
			dashSecurity.BringToFront();
			
			dashSecurity.WebConnectionString = this.hmConn.WebConnection ;
			dashSecurity.webDB = this.hmConn.WebDB ;
			dashSecurity.webServer= this.hmConn.WebServer ;
			dashSecurity.companyID = this.hmConn.CompanyID;
			dashSecurity.LoginName = this.hmConn.MLUser ;
			dashSecurity.Popups = new WS_Popups.frmPopup(this.HMDevXManager1);

			dashSecurity.gcSelected = this.gcSelected;
			dashSecurity.gvSelected = this.gvSelected;
			dashSecurity.OriginalParent = this.gcSelected.Parent  ;
            dashSecurity.barManager = this.barManager1;

			if  (si_id != -1 )
			   dashSecurity.InstanceID = si_id ;
			else
				dashSecurity.sQueryID = this.sQueryID;

			
		
            this.barManager1.Bars[0].Visible= false;
		  	dashSecurity.LoadSecurityPA(this.hmConn,securityEnabled,DataSource);
		}

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
				
			ManageSecurity ( -1) ;

		}

		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
			this.gcSelected.Parent = this.OriginalParent;
			
		}

		public void ActivateSecInstance ()
		{
			if  (this.barManager1.Bars[0].Visible)
			{
				this.dsInstance1.Clear();
				this.daInstance.SelectCommand.Parameters["@source"].Value = this.LoginName ;
				this.daInstance.SelectCommand.Parameters["@iswidget"].Value = this.iswidget ;
				this.daInstance.SelectCommand.Parameters["@SQ_ID"].Value = this.sQueryID ;
				this.daInstance.Fill(this.dsInstance1);
			}
		}

		private void frmSecurity_VisibleChanged(object sender, System.EventArgs e)
		{
			
		}

		private void bar1_VisibleChanged(object sender, System.EventArgs e)
		{
			ActivateSecInstance ();
		}

		private void cbActive_EditValueChanged(object sender, System.EventArgs e)
		{
			string active  = "0" ;
			if  (this.gvInstance.ActiveEditor.EditValue.ToString() == "True")
				active = "1";

			string sql = "update security_instance set active = " + active + 
				         " where id = " + this.gvInstance.GetDataRow(this.gvInstance.FocusedRowHandle)["id"].ToString();
			FADO.DB.Global.RunSql(this.webServer, this.webDB, sql,"470");
		    ActivateSecInstance ();

		}

		private void frmSecurity_Closed(object sender, System.EventArgs e)
		{
				this.gcSelected.Parent = this.OriginalParent;
		
		}
	}
}
