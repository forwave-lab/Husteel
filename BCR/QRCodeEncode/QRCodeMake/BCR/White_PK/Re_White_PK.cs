using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

namespace QRCodeMake.BCR
{
    public partial class Re_White_PK : DevExpress.XtraReports.UI.XtraReport
    {
        public Re_White_PK(Dictionary<string, string> dic)
        {
            InitializeComponent();

            //xrLabel1.DataBindings.Add("Text",null, dic["Bcr_DocType"].ToString());
            xrBcr_Wo.Text = dic["Bcr_Wo"].ToString();                   //제조오더
            xrBcr_Wo1.Text = dic["Bcr_Wo"].ToString();                  //제조오더
            xrBcr_Wo2.Text = dic["Bcr_Wo"].ToString();                  //제조오더
            xrBcr_Wo3.Text = dic["Bcr_Wo"].ToString();                  //제조오더
            //xrBcr_Wo4.Text = dic["Bcr_Wo"].ToString();                  //제조오더
            Bcr_ProductName.Text = dic["Bcr_ProductName"].ToString();   //품종
            Bcr_Spec.Text = dic["Bcr_Spec"].ToString();                 //치수
            Bcr_Qty.Text = dic["Bcr_Qty"].ToString();                   //본수
            Bcr_LotNo.Text = dic["Bcr_LotNo"].ToString();               //Lot No
            Bcr_TagLotNo.Text = dic["Bcr_TagLotNo"].ToString();         //Tag LotNo
            Bcr_Thickness.Text = dic["Bcr_Thickness"].ToString();         //Tag LotNo
            Bcr_Coating.Text = dic["Bcr_Coating"].ToString();           //코팅    
            Bcr_Inspector.Text = dic["Bcr_Inspector"].ToString();       //책임검사자
            Bcr_Marking.Text = dic["Bcr_Marking"].ToString();           //마킹정보
            Bcr_BP.Text = dic["Bcr_BP"].ToString();                     //주문처
            Bcr_HeatNo.Text = dic["Bcr_HeatNo"].ToString();             //Heat No
            //this.DataSource = dic;
        }
    }
}
