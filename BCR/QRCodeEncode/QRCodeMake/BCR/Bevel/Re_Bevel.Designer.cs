
namespace QRCodeMake.BCR.Bevel
{
    partial class Re_Bevel
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
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator2 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrBcr_Id1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBcr_Id = new DevExpress.XtraReports.UI.XRBarCode();
            this.Bcr_Qty = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_Date = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_HeatNo = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_Spec = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_Kind = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_BP = new DevExpress.XtraReports.UI.XRLabel();
            this.Bcr_LotNo = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 10F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 10F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBcr_Id1,
            this.xrBcr_Id,
            this.Bcr_Qty,
            this.Bcr_Date,
            this.Bcr_HeatNo,
            this.Bcr_Spec,
            this.Bcr_Kind,
            this.Bcr_BP,
            this.Bcr_LotNo});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 1450F;
            this.Detail.HierarchyPrintOptions.Indent = 50.8F;
            this.Detail.Name = "Detail";
            // 
            // xrBcr_Id1
            // 
            this.xrBcr_Id1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrBcr_Id1.AutoModule = true;
            this.xrBcr_Id1.Dpi = 254F;
            this.xrBcr_Id1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.xrBcr_Id1.LocationFloat = new DevExpress.Utils.PointFloat(475.8752F, 591.0416F);
            this.xrBcr_Id1.Module = 5.08F;
            this.xrBcr_Id1.Name = "xrBcr_Id1";
            this.xrBcr_Id1.Padding = new DevExpress.XtraPrinting.PaddingInfo(26, 26, 0, 0, 254F);
            this.xrBcr_Id1.ShowText = false;
            this.xrBcr_Id1.SizeF = new System.Drawing.SizeF(121.7083F, 97.89587F);
            this.xrBcr_Id1.StylePriority.UseFont = false;
            this.xrBcr_Id1.StylePriority.UseTextAlignment = false;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.xrBcr_Id1.Symbology = qrCodeGenerator1;
            this.xrBcr_Id1.Text = "1234";
            this.xrBcr_Id1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrBcr_Id
            // 
            this.xrBcr_Id.AutoModule = true;
            this.xrBcr_Id.Dpi = 254F;
            this.xrBcr_Id.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.xrBcr_Id.LocationFloat = new DevExpress.Utils.PointFloat(38.29159F, 1259.5F);
            this.xrBcr_Id.Module = 5.08F;
            this.xrBcr_Id.Name = "xrBcr_Id";
            this.xrBcr_Id.Padding = new DevExpress.XtraPrinting.PaddingInfo(26, 26, 0, 0, 254F);
            this.xrBcr_Id.SizeF = new System.Drawing.SizeF(857.3129F, 190.5F);
            this.xrBcr_Id.StylePriority.UseFont = false;
            this.xrBcr_Id.StylePriority.UseTextAlignment = false;
            qrCodeGenerator2.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.xrBcr_Id.Symbology = qrCodeGenerator2;
            this.xrBcr_Id.Text = "1234";
            // 
            // Bcr_Qty
            // 
            this.Bcr_Qty.Dpi = 254F;
            this.Bcr_Qty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcr_Qty.LocationFloat = new DevExpress.Utils.PointFloat(383.0662F, 944.1709F);
            this.Bcr_Qty.Multiline = true;
            this.Bcr_Qty.Name = "Bcr_Qty";
            this.Bcr_Qty.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.Bcr_Qty.SizeF = new System.Drawing.SizeF(208.5173F, 68.79175F);
            this.Bcr_Qty.StylePriority.UseFont = false;
            this.Bcr_Qty.Text = "Bcr_Qty";
            // 
            // Bcr_Date
            // 
            this.Bcr_Date.Dpi = 254F;
            this.Bcr_Date.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcr_Date.LocationFloat = new DevExpress.Utils.PointFloat(383.0662F, 830.6917F);
            this.Bcr_Date.Multiline = true;
            this.Bcr_Date.Name = "Bcr_Date";
            this.Bcr_Date.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.Bcr_Date.SizeF = new System.Drawing.SizeF(208.5173F, 68.79175F);
            this.Bcr_Date.StylePriority.UseFont = false;
            this.Bcr_Date.Text = "Bcr_Date";
            // 
            // Bcr_HeatNo
            // 
            this.Bcr_HeatNo.Dpi = 254F;
            this.Bcr_HeatNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcr_HeatNo.LocationFloat = new DevExpress.Utils.PointFloat(492.8541F, 497.8542F);
            this.Bcr_HeatNo.Multiline = true;
            this.Bcr_HeatNo.Name = "Bcr_HeatNo";
            this.Bcr_HeatNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.Bcr_HeatNo.SizeF = new System.Drawing.SizeF(418.9164F, 68.79169F);
            this.Bcr_HeatNo.StylePriority.UseFont = false;
            this.Bcr_HeatNo.Text = "Bcr_HeatNo";
            // 
            // Bcr_Spec
            // 
            this.Bcr_Spec.Dpi = 254F;
            this.Bcr_Spec.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcr_Spec.LocationFloat = new DevExpress.Utils.PointFloat(264.775F, 387.8334F);
            this.Bcr_Spec.Multiline = true;
            this.Bcr_Spec.Name = "Bcr_Spec";
            this.Bcr_Spec.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.Bcr_Spec.SizeF = new System.Drawing.SizeF(646.9955F, 68.79169F);
            this.Bcr_Spec.StylePriority.UseFont = false;
            this.Bcr_Spec.Text = "Bcr_Spec";
            // 
            // Bcr_Kind
            // 
            this.Bcr_Kind.Dpi = 254F;
            this.Bcr_Kind.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcr_Kind.LocationFloat = new DevExpress.Utils.PointFloat(717.2293F, 276.8333F);
            this.Bcr_Kind.Multiline = true;
            this.Bcr_Kind.Name = "Bcr_Kind";
            this.Bcr_Kind.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.Bcr_Kind.SizeF = new System.Drawing.SizeF(194.5413F, 68.79164F);
            this.Bcr_Kind.StylePriority.UseFont = false;
            this.Bcr_Kind.Text = "Bcr_Kind";
            // 
            // Bcr_BP
            // 
            this.Bcr_BP.CanGrow = false;
            this.Bcr_BP.Dpi = 254F;
            this.Bcr_BP.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcr_BP.LocationFloat = new DevExpress.Utils.PointFloat(492.8541F, 276.8333F);
            this.Bcr_BP.Name = "Bcr_BP";
            this.Bcr_BP.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.Bcr_BP.SizeF = new System.Drawing.SizeF(224.3755F, 68.79164F);
            this.Bcr_BP.StylePriority.UseFont = false;
            this.Bcr_BP.Text = "Bcr_BP";
            this.Bcr_BP.WordWrap = false;
            // 
            // Bcr_LotNo
            // 
            this.Bcr_LotNo.Dpi = 254F;
            this.Bcr_LotNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcr_LotNo.LocationFloat = new DevExpress.Utils.PointFloat(38.2916F, 276.8333F);
            this.Bcr_LotNo.Multiline = true;
            this.Bcr_LotNo.Name = "Bcr_LotNo";
            this.Bcr_LotNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.Bcr_LotNo.SizeF = new System.Drawing.SizeF(454.5625F, 68.79164F);
            this.Bcr_LotNo.StylePriority.UseFont = false;
            this.Bcr_LotNo.Text = "Bcr_LotNo";
            // 
            // Re_Bevel
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.DefaultPrinterSettingsUsing.UsePaperKind = true;
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            this.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 254F);
            this.PageHeight = 1450;
            this.PageWidth = 950;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "21.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Qty;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Date;
        private DevExpress.XtraReports.UI.XRLabel Bcr_HeatNo;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Spec;
        private DevExpress.XtraReports.UI.XRLabel Bcr_Kind;
        private DevExpress.XtraReports.UI.XRLabel Bcr_BP;
        private DevExpress.XtraReports.UI.XRLabel Bcr_LotNo;
        private DevExpress.XtraReports.UI.XRBarCode xrBcr_Id;
        private DevExpress.XtraReports.UI.XRBarCode xrBcr_Id1;
    }
}
