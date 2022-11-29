
namespace QRCodeMake.BCR.Cutting
{
    partial class Re_Cutting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.Bcr_Date = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_Diameter = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_ProductName = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_Length = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_Thickness = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_HeatNo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBcr_Id = new DevExpress.XtraReports.UI.XRBarCode();
            this.Bcr_Note = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_Note1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 2F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 2F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Bcr_Note1,
            this.Bcr_Note,
            this.Bcr_Date,
            this.Bcr_Diameter,
            this.Bcr_ProductName,
            this.Bcr_Length,
            this.Bcr_Thickness,
            this.Bcr_HeatNo,
            this.xrBcr_Id});
            this.Detail.HeightF = 93.79164F;
            this.Detail.Name = "Detail";
            // 
            // Bcr_Date
            // 
            this.Bcr_Date.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bcr_Date.LocationFloat = new DevExpress.Utils.PointFloat(139.5833F, 0F);
            this.Bcr_Date.Name = "Bcr_Date";
            this.Bcr_Date.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Bcr_Date.SizeF = new System.Drawing.SizeF(64.4167F, 23F);
            this.Bcr_Date.StylePriority.UseFont = false;
            this.Bcr_Date.Text = "Bcr_Date";
            this.Bcr_Date.WordWrap = false;
            // 
            // Bcr_Diameter
            // 
            this.Bcr_Diameter.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bcr_Diameter.LocationFloat = new DevExpress.Utils.PointFloat(70.41664F, 0F);
            this.Bcr_Diameter.Name = "Bcr_Diameter";
            this.Bcr_Diameter.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Bcr_Diameter.SizeF = new System.Drawing.SizeF(60.41667F, 23F);
            this.Bcr_Diameter.StylePriority.UseFont = false;
            this.Bcr_Diameter.Text = "Bcr_Diameter";
            this.Bcr_Diameter.WordWrap = false;
            // 
            // Bcr_ProductName
            // 
            this.Bcr_ProductName.CanGrow = false;
            this.Bcr_ProductName.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bcr_ProductName.LocationFloat = new DevExpress.Utils.PointFloat(2F, 0F);
            this.Bcr_ProductName.Name = "Bcr_ProductName";
            this.Bcr_ProductName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Bcr_ProductName.SizeF = new System.Drawing.SizeF(60.41667F, 23F);
            this.Bcr_ProductName.StylePriority.UseFont = false;
            this.Bcr_ProductName.Text = "Bcr_ProductName";
            this.Bcr_ProductName.WordWrap = false;
            // 
            // Bcr_Length
            // 
            this.Bcr_Length.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bcr_Length.LocationFloat = new DevExpress.Utils.PointFloat(70.41664F, 70.79163F);
            this.Bcr_Length.Multiline = true;
            this.Bcr_Length.Name = "Bcr_Length";
            this.Bcr_Length.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Bcr_Length.SizeF = new System.Drawing.SizeF(60.41667F, 23F);
            this.Bcr_Length.StylePriority.UseFont = false;
            this.Bcr_Length.Text = "Bcr_Length";
            // 
            // Bcr_Thickness
            // 
            this.Bcr_Thickness.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bcr_Thickness.LocationFloat = new DevExpress.Utils.PointFloat(2F, 70.79163F);
            this.Bcr_Thickness.Multiline = true;
            this.Bcr_Thickness.Name = "Bcr_Thickness";
            this.Bcr_Thickness.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Bcr_Thickness.SizeF = new System.Drawing.SizeF(60.41667F, 23F);
            this.Bcr_Thickness.StylePriority.UseFont = false;
            this.Bcr_Thickness.Text = "Bcr_Thickness";
            // 
            // Bcr_HeatNo
            // 
            this.Bcr_HeatNo.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bcr_HeatNo.LocationFloat = new DevExpress.Utils.PointFloat(139.5833F, 70.79164F);
            this.Bcr_HeatNo.Multiline = true;
            this.Bcr_HeatNo.Name = "Bcr_HeatNo";
            this.Bcr_HeatNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Bcr_HeatNo.SizeF = new System.Drawing.SizeF(64.4167F, 23F);
            this.Bcr_HeatNo.StylePriority.UseFont = false;
            this.Bcr_HeatNo.Text = "Bcr_HeatNo";
            // 
            // xrBcr_Id
            // 
            this.xrBcr_Id.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBcr_Id.AutoModule = true;
            this.xrBcr_Id.LocationFloat = new DevExpress.Utils.PointFloat(1.999982F, 23F);
            this.xrBcr_Id.Name = "xrBcr_Id";
            this.xrBcr_Id.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xrBcr_Id.SizeF = new System.Drawing.SizeF(202F, 47.79164F);
            this.xrBcr_Id.StylePriority.UseTextAlignment = false;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.xrBcr_Id.Symbology = qrCodeGenerator1;
            this.xrBcr_Id.Text = "123456";
            this.xrBcr_Id.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // Bcr_Note
            // 
            this.Bcr_Note.CanGrow = false;
            this.Bcr_Note.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bcr_Note.LocationFloat = new DevExpress.Utils.PointFloat(1.999982F, 34.99999F);
            this.Bcr_Note.Name = "Bcr_Note";
            this.Bcr_Note.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Bcr_Note.SizeF = new System.Drawing.SizeF(60.41667F, 23F);
            this.Bcr_Note.StylePriority.UseFont = false;
            this.Bcr_Note.StylePriority.UseTextAlignment = false;
            this.Bcr_Note.Text = "Bcr_Note";
            this.Bcr_Note.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Bcr_Note.WordWrap = false;
            // 
            // Bcr_Note1
            // 
            this.Bcr_Note1.CanGrow = false;
            this.Bcr_Note1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bcr_Note1.LocationFloat = new DevExpress.Utils.PointFloat(139.5833F, 34.99999F);
            this.Bcr_Note1.Name = "Bcr_Note1";
            this.Bcr_Note1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Bcr_Note1.SizeF = new System.Drawing.SizeF(60.41667F, 23F);
            this.Bcr_Note1.StylePriority.UseFont = false;
            this.Bcr_Note1.StylePriority.UseTextAlignment = false;
            this.Bcr_Note1.Text = "Bcr_Note";
            this.Bcr_Note1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Bcr_Note1.WordWrap = false;
            // 
            // Re_Cutting
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(2, 2, 2, 2);
            this.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.PageHeight = 100;
            this.PageWidth = 208;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "21.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRBarCode xrBcr_Id;
        private DevExpress.XtraReports.UI.XRLabel Bcr_HeatNo;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Date;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Diameter;
        private DevExpress.XtraReports.UI.XRLabel Bcr_ProductName;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Length;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Thickness;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Note1;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Note;
    }
}
