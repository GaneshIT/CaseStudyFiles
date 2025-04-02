using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // It makes sense to use the Builder Design Pattern only 
    // when your products are quite complex 
    // and require extensive configuration.
    // Using the following Report Product class, we can configure different types of Product
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }

        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Content :" + ReportContent);
            Console.WriteLine("Footer :" + ReportFooter);
        }
    }

    // The Builder Abstract Class specifies methods for creating the different parts
    // of the Product objects.
    public abstract class ReportBuilder
    {
        protected Report reportObject;

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            reportObject = new Report();
        }

        public Report GetReport()
        {
            return reportObject;
        }
    }

    // The Following Concrete Builder Implementd the ReportBuilder Abstract Class and 
    // provide specific implementations of the steps for Creating ExcelReport. 
    public class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
    // The Following Concrete Builder Implementd the ReportBuilder Abstract Class and 
    // provide specific implementations of the steps for Creating PDFReport. 
    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }

        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }
    // The Director is only responsible for executing the building steps in a particular order. 
    // It is helpful when producing products according to a specific order or configuration. 
    public class ReportDirector
    {
        //ref pdf or excel report 
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}
