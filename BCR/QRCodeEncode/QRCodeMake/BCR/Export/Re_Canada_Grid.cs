using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

namespace QRCodeMake.BCR.Export
{
    public partial class Re_Canada_Grid : DevExpress.XtraReports.UI.XtraReport
    {
        public Re_Canada_Grid(Dictionary<string, string> dic)
        {
            InitializeComponent();

            xrBcr_Id.Text = dic["Bcr_Id"].ToString();                   //Bundle No
            xrBcr_Id1.Text = dic["Bcr_Id"].ToString();                   //Bundle No
            xrBcr_Id2.Text = dic["Bcr_Id"].ToString();                   //Bundle No
            Bcr_Id.Text = dic["Bcr_Id"].ToString();
            Bcr_PoNo.Text = dic["Bcr_PoNo"].ToString();                   //PO No
            Bcr_BP.Text = dic["Bcr_BP"].ToString();                   //도착지
            Bcr_ProductName.Text = dic["Bcr_ProductName"].ToString();
            Bcr_Spec.Text = dic["Bcr_Spec"].ToString();
            Bcr_PCSLIFT.Text = dic["Bcr_PCSLIFT"].ToString();
            Bcr_SoNo.Text = dic["Bcr_SoNo"].ToString();
            Bcr_LotNo.Text = dic["Bcr_LotNo"].ToString();
            Bcr_HeatNo.Text = dic["Bcr_HeatNo"].ToString();
            Bcr_Inspector.Text = dic["Bcr_Inspector"].ToString();
            Bcr_BundleNo.Text = dic["Bcr_BundleNo"].ToString();
        }

    }
}
