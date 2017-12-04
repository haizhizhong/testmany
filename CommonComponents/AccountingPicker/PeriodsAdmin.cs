using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AccountingPicker
{
	/// <summary>
	/// Summary description for PeriodsAdmin.
	/// </summary>
	public class PeriodsAdmin : DevExpress.XtraEditors.XtraForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private TUC_HMDevXManager.TUC_HMDevXManager dxManager;
		private GL_Periods.UserControl1 periods;
		private System.ComponentModel.Container components = null;

		public PeriodsAdmin(HMConnection.HMCon hmConObject, TUC_HMDevXManager.TUC_HMDevXManager dxMgr)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			periods = new GL_Periods.UserControl1(hmConObject);
			dxManager = dxMgr;
			periods.Style = dxMgr; 
			periods.Parent = this;
			periods.Dock = DockStyle.Fill;
		
			foreach(DevExpress.XtraLayout.BaseLayoutItem itm in periods.loControl.Items)
			{//first remove the layout controlItem
				if(itm.Name == "layoutControlItem4")
				{
					  itm.Dispose();
					  break;
					  
				}
			}
			foreach(Control ctrl in periods.loControl.Controls)
			{//then remove the control in the item
				if(ctrl.Name == "btnUpdate")
				{
					ctrl.Visible = false;
					ctrl.Enabled = false;
					periods.loControl.Controls.Remove(ctrl);
					break;
				}
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PeriodsAdmin));
			// 
			// PeriodsAdmin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(720, 510);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PeriodsAdmin";
			this.Text = "All Period Setup";
			this.Load += new System.EventHandler(this.PeriodsAdmin_Load);

		}
		#endregion

		private void PeriodsAdmin_Load(object sender, System.EventArgs e)
		{
			dxManager.FormInit(this);
			dxManager.FormInit(periods);
			
		}
	}
}

