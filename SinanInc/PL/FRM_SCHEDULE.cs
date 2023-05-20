using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace SinanInc.PL
{
    public partial class FRM_SCHEDULE : Form
    {
        BL.CLS_STUDENTS student = new BL.CLS_STUDENTS();
        BL.CLS_CLASSES clas = new BL.CLS_CLASSES();
        public FRM_SCHEDULE()
        {
            InitializeComponent();
            dgv_Schedule.DataSource = clas.GET_ALL_SCEDULES();

        }

     

        private void dgv_Schedule_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }


        private void btnNewSch_Click(object sender, EventArgs e)
        {
            FRM_ADD_SCHEDULE frm = new FRM_ADD_SCHEDULE();
            frm.ShowDialog();
        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.rpt_schedule myReport = new RPT.rpt_schedule();
                ExportOptions export = new ExportOptions();
                DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
                PdfFormatOptions pdfFormat = new PdfFormatOptions();

                dfoptions.DiskFileName = @"D:\Pdf\Schedule.pdf";
                export = myReport.ExportOptions;
                export.ExportDestinationType = ExportDestinationType.DiskFile;
                export.ExportFormatType = ExportFormatType.PortableDocFormat;
                export.ExportFormatOptions = pdfFormat;
                export.ExportDestinationOptions = dfoptions;
                myReport.Export();
                MessageBox.Show("تم حفظ الملف");
            }
            catch (Exception)
            {
                MessageBox.Show("خطأ غير معلوم");
            }
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("سوف يتم حذف البرنامج الحالي", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes)
            {
                clas.DELETE_SCHEDULE();
                dgv_Schedule.DataSource = clas.GET_ALL_SCEDULES();
                MessageBox.Show("تم حذف البرنامج بنجاح");
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف");
            }
        }

   
    }
}
