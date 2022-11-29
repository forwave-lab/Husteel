using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

namespace QRCodeMake.BCR.Bevel
{
    public partial class Re_Bevel : DevExpress.XtraReports.UI.XtraReport
    {
        public Re_Bevel(Dictionary<string, string> dic)
        {
            InitializeComponent();

            xrBcr_Id.Text = dic["Bcr_LotNo"].ToString();
            xrBcr_Id1.Text = dic["Bcr_LotNo"].ToString();
            Bcr_LotNo.Text = dic["Bcr_LotNo"].ToString();                   //Pipe No
            Bcr_BP.Text = dic["Bcr_BP"].ToString();
            Bcr_Kind.Text = dic["Bcr_Kind"].ToString();
            Bcr_Spec.Text = dic["Bcr_Spec"].ToString();
            Bcr_HeatNo.Text = dic["Bcr_HeatNo"].ToString();
            //Bcr_CoilNo.Text = dic["Bcr_CoilNo"].ToString();
            Bcr_Date.Text = dic["Bcr_Date"].ToString();
            Bcr_Qty.Text = dic["Bcr_Qty"].ToString();
        }

    }
}
