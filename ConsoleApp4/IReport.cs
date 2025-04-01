using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface IReport
    {
        void DownloadReport();
        void UploadReport();
    }
    public interface IExcelReport
    {
        void DownloadReport();
        void UploadReport();
    }
    public interface IWordReport
    {
        void DownloadReport();
        void UploadReport();
    }
    public class ExcelDoc : IReport
    {
        public void DownloadReport() { }
        public void UploadReport() { }
        
    }
    public class WordDoc : IReport
    {
        public void DownloadReport() { }
        public void UploadReport() { }
    }
    public class Documents
    {
        private IReport _report;
        //private ExcelDoc _excelDoc;
        //private WordDoc _wordDoc;
        public Documents(IReport report)
        {
            _report = report;
            //_excelDoc = excelDoc;
            //_wordDoc = wordDoc;
        }
        public Documents(IExcelReport report,IWordReport wordReport)
        {

        }
        public Documents(IReport report,ICustomer)
        {
            _report = report;
            //_excelDoc = excelDoc;
            //_wordDoc = wordDoc;
        }
        public void Airtel()
        {
            _report.DownloadReport();
            _report.UploadReport();
        }
        public void Jio()
        {
            _report.DownloadReport();
            _report.UploadReport();
        }
    }
}


/*
 * DeliverySystem/Cargo Management
 * 
 * Vehicle
 * Ship
 * Flight  -> 1000 rs per kg, distance - 100rs per km
 * Truck
 * 
 */
