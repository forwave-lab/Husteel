using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

namespace QRCodeMake.BCR.Skelp
{
    public partial class Re_Slitting : DevExpress.XtraReports.UI.XtraReport
    {
        public Re_Slitting(Dictionary<string, string> dic)
        {
            InitializeComponent();

            xrBcr_Id.Text = dic["Bcr_Id"].ToString();                   //제조오더
            Bcr_BP.Text = dic["Bcr_BP"].ToString();                     //구입선
            Bcr_Kind.Text = dic["Bcr_Kind"].ToString();                     //재질
            Bcr_Spec.Text = dic["Bcr_Spec"].ToString();                     //규격
            Bcr_Weight.Text = dic["Bcr_Weight"].ToString();                     //중량
            Bcr_LotNo.Text = dic["Bcr_LotNo"].ToString();                     //Skelp NO
            Bcr_CoilNo.Text = dic["Bcr_CoilNo"].ToString();                     //Coil No
            Bcr_HeatNo.Text = dic["Bcr_HeatNo"].ToString();                     //Heat No
            Bcr_Inspector.Text = dic["Bcr_Inspector"].ToString();                     //책임검사자
            Bcr_Note.Text = dic["Bcr_Note"].ToString();                     //비고
            Bcr_Desc.Text = dic["Bcr_Desc"].ToString();                     //특이사항
        }

    }
}
