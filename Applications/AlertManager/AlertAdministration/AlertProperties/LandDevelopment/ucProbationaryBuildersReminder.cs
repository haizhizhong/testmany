using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AlertProperties.LandDevelopment
{
    public partial class ucProbationaryBuildersReminder : ucPropertyInterface
    {
        private ucCommPurDocMerge CommPurDocMerge;

        public ucProbationaryBuildersReminder()
        {
            InitializeComponent();
        }

        private void LoadUserControls()
        {
            CommPurDocMerge = new ucCommPurDocMerge(Connection, DevXMgr, AlertPointID);
            CommPurDocMerge.Dock = DockStyle.Fill;
            CommPurDocMerge.Parent = pcGrid;
            CommPurDocMerge.tpTolerance.PageVisible = false;
        }


        private void ucProbationaryBuildersReminder_Load(object sender, EventArgs e)
        {
            LoadUserControls();

            DevXMgr.FormInit(this);
            string sSelect = "select count(*) from alert_land_reminder_setup where AlertID=" + AlertPointID;
            if (Convert.ToInt32(Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection)) == 0)
            {
                string sInsert = "insert into alert_land_reminder_setup (AlertID, X_Days) values (" + AlertPointID + ", 0)";
                Connection.SQLExecutor.ExecuteNonQuery(sInsert, Connection.TRConnection);
            }

            sSelect = "select isnull(X_Days,0) from alert_land_reminder_setup where AlertID=" + AlertPointID;
            txtDays.EditValue = Connection.SQLExecutor.ExecuteScalar(sSelect, Connection.TRConnection);
            labelControl1.Focus();
        }

        

        private void txtDays_EditValueChanged(object sender, EventArgs e)
        {
            string sUpdate = "update alert_land_reminder_setup set X_Days=" + txtDays.EditValue + " where AlertID=" + AlertPointID;
            Connection.SQLExecutor.ExecuteNonQuery(sUpdate, Connection.TRConnection);
        }

        private void txtDays_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (Convert.ToInt32(e.NewValue) < 0)
            {
                e.Cancel = true;
            }
        }
    }
}
