
namespace MVCH_ReportViewer
{
    partial class frmReportViewer
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rptRoomUtilization = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rptPhysicianPatient = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rptRoomUtilization);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Room Utilization Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rptRoomUtilization
            // 
            this.rptRoomUtilization.ActiveViewIndex = -1;
            this.rptRoomUtilization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptRoomUtilization.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptRoomUtilization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptRoomUtilization.Location = new System.Drawing.Point(3, 3);
            this.rptRoomUtilization.Name = "rptRoomUtilization";
            this.rptRoomUtilization.ShowCloseButton = false;
            this.rptRoomUtilization.Size = new System.Drawing.Size(786, 415);
            this.rptRoomUtilization.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rptPhysicianPatient);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Physician-Patient Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rptPhysicianPatient
            // 
            this.rptPhysicianPatient.ActiveViewIndex = -1;
            this.rptPhysicianPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptPhysicianPatient.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptPhysicianPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptPhysicianPatient.Location = new System.Drawing.Point(3, 3);
            this.rptPhysicianPatient.Name = "rptPhysicianPatient";
            this.rptPhysicianPatient.ShowCloseButton = false;
            this.rptPhysicianPatient.Size = new System.Drawing.Size(786, 415);
            this.rptPhysicianPatient.TabIndex = 0;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "frmReportViewer";
            this.Text = "MVCH Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptRoomUtilization;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptPhysicianPatient;
    }
}

