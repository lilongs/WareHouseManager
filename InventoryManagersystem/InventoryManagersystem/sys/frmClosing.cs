using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagersystem.sys
{
    public partial class frmClosing : Form
    {

        public static bool DirectExit = false;
        private ClassAssist.INIOperator myINIOperator = ClassAssist.CommonOperator.GetSysINI();
        public frmClosing()
        {
            InitializeComponent();
        }

        private void frmClosing_Load(object sender, EventArgs e)
        {
            bool RemberOrNot = myINIOperator.ReadBoolean("AppExit", "Remember");
            if (RemberOrNot == false)
            {
                if (myINIOperator.ReadBoolean("AppExit", "DirectExit") == true)
                {
                    this.rdbHide.Checked = true;
                    this.rdbClose.Checked = false;
                }
                     
                return;
            }
            else
            {
                DirectExit = myINIOperator.ReadBoolean("AppExit", "DirectExit");
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            chkRember_CheckedChanged(sender, e);
            this.DialogResult = DialogResult.Yes;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkRember_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkRember.Checked == true)
            {
                myINIOperator.Write("AppExit", "Remember", true);
                myINIOperator.Write("AppExit", "DirectExit", DirectExit);
            }
            else
            {
                myINIOperator.Write("AppExit", "Remember", false);
                myINIOperator.Write("AppExit", "DirectExit", DirectExit);
            }
        }
    }
}
