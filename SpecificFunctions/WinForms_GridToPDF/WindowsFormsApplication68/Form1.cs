using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infragistics.Documents.Reports.Report.Section;
using Infragistics.Documents.Reports.Report;
using System.Diagnostics;
using Infragistics.Documents.Reports.Report.Text;
using Infragistics.Documents.Reports.Report.Grid;

namespace WindowsFormsApplication68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                ultraDataSource1.Band.Columns.Add("Column "+i.ToString());
            }

            for (int i = 0; i < 200; i++)
            {
                ultraDataSource1.Rows.Add();
            }
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            var exportedFilePath = "..//..//report.pdf";

            var report = new Report();

            ISection gridSection = this.ultraGridDocumentExporter1.Export(ultraGrid1, report);
            gridSection.PageNumbering.SkipFirst = false;
            gridSection.PageNumbering.Template = "Page [Page #] of [TotalPages]";

            ISectionHeader headerSection = gridSection.AddHeader();
            IText headerText = headerSection.AddText(0, 0);
            headerText.Alignment = TextAlignment.Center;
            headerText.AddContent("TEST REPORT HEADER");

            ISectionFooter footerSection = gridSection.AddFooter();

            IText footerText = footerSection.AddText(0, -20);
            footerText.Alignment = TextAlignment.Center;
            footerText.AddContent("TEST REPORT FOOTER");
            footerSection.Repeat = true;
            footerText.Margins.Top = 20;
            footerText.Alignment.Vertical = Alignment.Bottom;
            report.Publish(exportedFilePath, FileFormat.PDF);

            Process.Start("..\\..\\report.pdf");

            this.Close();
        }

        private void ultraGridDocumentExporter1_BeginExport(object sender, Infragistics.Win.UltraWinGrid.DocumentExport.BeginExportEventArgs e)
        {
            IText text = e.Section.AddText();
            text.AddContent(" ");
        }
    }
}
