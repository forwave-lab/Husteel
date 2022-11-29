using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

namespace QRCodeMake.BCR.Cutting
{
    public partial class Re_Cutting : DevExpress.XtraReports.UI.XtraReport
    {
        public Re_Cutting(Dictionary<string, string> dic)
        {
            InitializeComponent();

            xrBcr_Id.Text = dic["Bcr_Id"].ToString();                   //Pipe No
            Bcr_ProductName.Text = dic["Bcr_ProductName"].ToString();                   //품종
            Bcr_Diameter.Text = dic["Bcr_Diameter"].ToString();                   //외경
            Bcr_Date.Text = dic["Bcr_Date"].ToString();                   //생산일자
            Bcr_Thickness.Text = dic["Bcr_Thickness"].ToString();                   //두께
            Bcr_Length.Text = dic["Bcr_Length"].ToString();                   //길이
            Bcr_HeatNo.Text = dic["Bcr_HeatNo"].ToString();                   //HeatNo

            Bcr_Note.Text = dic["Bcr_Note"].ToString();                   //HeatNo
            Bcr_Note1.Text = dic["Bcr_Note"].ToString();                   //HeatNo
        }

    }
}
