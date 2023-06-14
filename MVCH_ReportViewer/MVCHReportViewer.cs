//Program:      MVCH_REPORTS
//Date:         April 3, 2021
//Author(s):    Ahmed Butt, Fluer Blankaert, Yustina Bouls
//Description:  This C# program allows a user to view two MVCH reports.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCH_ReportViewer
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        //DataSet object
        private MVCH_DatabaseDataSet reportsDataSet;

        //Table Adaptors
        private MVCH_DatabaseDataSetTableAdapters.PATIENTTableAdapter patientTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.STAFFTableAdapter staffTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.PATIENT_INTAKETableAdapter patientIntakeTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.ROOMTableAdapter roomTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.PHYSICIANTableAdapter physicianTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.APPOINTMENTTableAdapter appointmentTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.COST_CENTERTableAdapter costCenterTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.DIAGNOSTIC_REQUESTTableAdapter diagnosticRequestTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.DIAGNOSTIC_TESTTableAdapter diagnosticTestTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.EXAMINATIONTableAdapter examinationTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.FINANCIAL_STATUSTableAdapter financialStatusTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.INVOICETableAdapter invoiceTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.ITEMTableAdapter itemTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.LINEITEMTableAdapter lineitemTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.ROOM_TYPETableAdapter roomTypeTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.SPECIALTYTableAdapter specialtyTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.SUPPLYTableAdapter supplyTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.SUPPLY_TYPETableAdapter supplyTypeTableAdapter;
        private MVCH_DatabaseDataSetTableAdapters.TREATMENTSTableAdapter treatmentsTableAdapter;

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            //Room Utilization Report
            //Instantiating RoomUtilization_Rep
            RoomUtilization_Rep roomUtilizationReport;
            roomUtilizationReport = new RoomUtilization_Rep();

            //Physician-Patient Report
            //Instantiating PhysicianPatient_Rep
            PhysicianPatient_Rep physicianPatientReport;
            physicianPatientReport = new PhysicianPatient_Rep();

            try
            {
                //Instantiating the dataset and table adapters
                reportsDataSet = new MVCH_DatabaseDataSet();
                patientTableAdapter = new MVCH_DatabaseDataSetTableAdapters.PATIENTTableAdapter();
                staffTableAdapter = new MVCH_DatabaseDataSetTableAdapters.STAFFTableAdapter();
                patientIntakeTableAdapter = new MVCH_DatabaseDataSetTableAdapters.PATIENT_INTAKETableAdapter();
                roomTableAdapter = new MVCH_DatabaseDataSetTableAdapters.ROOMTableAdapter();
                physicianTableAdapter = new MVCH_DatabaseDataSetTableAdapters.PHYSICIANTableAdapter();
                appointmentTableAdapter = new MVCH_DatabaseDataSetTableAdapters.APPOINTMENTTableAdapter();
                costCenterTableAdapter = new MVCH_DatabaseDataSetTableAdapters.COST_CENTERTableAdapter();
                diagnosticRequestTableAdapter = new MVCH_DatabaseDataSetTableAdapters.DIAGNOSTIC_REQUESTTableAdapter();
                diagnosticTestTableAdapter = new MVCH_DatabaseDataSetTableAdapters.DIAGNOSTIC_TESTTableAdapter();
                examinationTableAdapter = new MVCH_DatabaseDataSetTableAdapters.EXAMINATIONTableAdapter();
                financialStatusTableAdapter = new MVCH_DatabaseDataSetTableAdapters.FINANCIAL_STATUSTableAdapter();
                invoiceTableAdapter = new MVCH_DatabaseDataSetTableAdapters.INVOICETableAdapter();
                itemTableAdapter = new MVCH_DatabaseDataSetTableAdapters.ITEMTableAdapter();
                lineitemTableAdapter = new MVCH_DatabaseDataSetTableAdapters.LINEITEMTableAdapter();
                roomTypeTableAdapter = new MVCH_DatabaseDataSetTableAdapters.ROOM_TYPETableAdapter();
                specialtyTableAdapter = new MVCH_DatabaseDataSetTableAdapters.SPECIALTYTableAdapter();
                supplyTableAdapter = new MVCH_DatabaseDataSetTableAdapters.SUPPLYTableAdapter();
                supplyTypeTableAdapter = new MVCH_DatabaseDataSetTableAdapters.SUPPLY_TYPETableAdapter();
                treatmentsTableAdapter = new MVCH_DatabaseDataSetTableAdapters.TREATMENTSTableAdapter();


                 //Filling DataSet
                patientTableAdapter.Fill(reportsDataSet.PATIENT);
                staffTableAdapter.Fill(reportsDataSet.STAFF);
                patientIntakeTableAdapter.Fill(reportsDataSet.PATIENT_INTAKE);
                roomTableAdapter.Fill(reportsDataSet.ROOM);
                physicianTableAdapter.Fill(reportsDataSet.PHYSICIAN);
                appointmentTableAdapter.Fill(reportsDataSet.APPOINTMENT);
                costCenterTableAdapter.Fill(reportsDataSet.COST_CENTER);
                diagnosticRequestTableAdapter.Fill(reportsDataSet.DIAGNOSTIC_REQUEST);
                diagnosticTestTableAdapter.Fill(reportsDataSet.DIAGNOSTIC_TEST);
                examinationTableAdapter.Fill(reportsDataSet.EXAMINATION);
                financialStatusTableAdapter.Fill(reportsDataSet.FINANCIAL_STATUS);
                invoiceTableAdapter.Fill(reportsDataSet.INVOICE);
                itemTableAdapter.Fill(reportsDataSet.ITEM);
                lineitemTableAdapter.Fill(reportsDataSet.LINEITEM);
                roomTypeTableAdapter.Fill(reportsDataSet.ROOM_TYPE);
                specialtyTableAdapter.Fill(reportsDataSet.SPECIALTY);
                supplyTableAdapter.Fill(reportsDataSet.SUPPLY);
                supplyTypeTableAdapter.Fill(reportsDataSet.SUPPLY_TYPE);
                treatmentsTableAdapter.Fill(reportsDataSet.TREATMENTS);


                //Assigning the filled DataSet as the report source
                roomUtilizationReport.SetDataSource(reportsDataSet);
                physicianPatientReport.SetDataSource(reportsDataSet);

                //Assigning the report as the report viewer source
                rptRoomUtilization.ReportSource = roomUtilizationReport;
                rptPhysicianPatient.ReportSource = physicianPatientReport;
            }
            catch (Exception dataException)
            {
                //Catch any errors, display errors
                MessageBox.Show("Data Error Encountered: " + dataException.Message);
            }
        }
    }
}
