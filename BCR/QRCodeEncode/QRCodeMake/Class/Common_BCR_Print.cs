using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using QRCodeMake.BCR;
using QRCodeMake.BCR.Skelp;
using QRCodeMake.BCR.Cutting;
using QRCodeMake.BCR.Export;
using QRCodeMake.BCR.Bevel;
using DevExpress.Xpf.Printing;
using DevExpress.XtraPrinting;

namespace QRCodeMake.Class
{        
    class Common_BCR_Print
    {
        short copies = 1;

        public string initPrint(Dictionary<string,string> dic)
        {
            string result = string.Empty;

            XtraReport report = new XtraReport();

            switch(dic["Bcr_DocType"])
            {
                //스릿다
                case "100":
                    Re_Slitting re_slitting = new Re_Slitting(dic);
                    report = re_slitting;
                    break;
                //절단(당진,대불)
                case "104":
                    Re_Cutting re_cutting_pk = new Re_Cutting(dic);
                    report = re_cutting_pk;
                    break;
                //관단
                case "105":
                    Re_Bevel re_bevel = new Re_Bevel(dic);
                    report = re_bevel;
                    break;
                //Export(낱본,번들)
                case "900":
                    Re_Canada re_canada = new Re_Canada(dic);
                    report = re_canada;
                    break;
                //흑관하조, 백관하조 동일 사용
                default:   
                    Re_White_PK re_white_pk = new Re_White_PK(dic);
                    report = re_white_pk;
                    break;
            }

            copies = Int16.Parse(dic["Bcr_Cnt"]);
            copies = 1;

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                printTool.PrinterSettings.Copies = copies;
                report.ShowPrintMarginsWarning = false;
                //printTool.ShowRibbonPreviewDialog();
                printTool.Print();
            }

            result = "Print Okey!";
            return result;
        }
    }
}
