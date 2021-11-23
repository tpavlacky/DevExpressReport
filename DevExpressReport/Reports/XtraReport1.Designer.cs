
namespace DevExpressReport
{
	partial class XtraReport1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrCheckBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
			this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.objectDataSource2 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 31F;
			this.TopMargin.Name = "TopMargin";
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 441F;
			this.BottomMargin.Name = "BottomMargin";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCheckBox1,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2});
			this.Detail.DrillDownControl = this.xrCheckBox1;
			this.Detail.HeightF = 17.13687F;
			this.Detail.HierarchyPrintOptions.KeyFieldName = "ID";
			this.Detail.HierarchyPrintOptions.ParentFieldName = "ParentID";
			this.Detail.Name = "Detail";
			this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Caption", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(657F, 100F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "Demo report";
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// xrLabel2
			// 
			this.xrLabel2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
			this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Caption]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Font.Bold", "Iif([SourceValue] == \'\', true , false)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([SourceValue] == \'\',  \'HotPink\', \'Black\')")});
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(19.92188F, 0F);
			this.xrLabel2.Multiline = true;
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(230.2269F, 17.08332F);
			this.xrLabel2.Text = "xrLabel2";
			// 
			// xrLabel3
			// 
			this.xrLabel3.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
			this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SourceValue]")});
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(250.1488F, 0F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(198.0655F, 17.08332F);
			this.xrLabel3.StylePriority.UsePadding = false;
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "xrLabel3";
			this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			// 
			// xrLabel4
			// 
			this.xrLabel4.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
			this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TargetValue]")});
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(448.2143F, 0F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(208.7857F, 17.08332F);
			this.xrLabel4.StylePriority.UsePadding = false;
			this.xrLabel4.StylePriority.UseTextAlignment = false;
			this.xrLabel4.Text = "xrLabel4";
			this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
			this.PageHeader.HeightF = 37.5F;
			this.PageHeader.Name = "PageHeader";
			// 
			// xrTable1
			// 
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(657F, 37.5F);
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.xrTableCell1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.xrTableCell1.Multiline = true;
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.StylePriority.UseBackColor = false;
			this.xrTableCell1.StylePriority.UseFont = false;
			this.xrTableCell1.StylePriority.UseTextAlignment = false;
			this.xrTableCell1.Text = "Caption";
			this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.xrTableCell1.Weight = 1.1545329167292668D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.xrTableCell2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.xrTableCell2.Multiline = true;
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
			this.xrTableCell2.StylePriority.UseBackColor = false;
			this.xrTableCell2.StylePriority.UseFont = false;
			this.xrTableCell2.StylePriority.UsePadding = false;
			this.xrTableCell2.StylePriority.UseTextAlignment = false;
			this.xrTableCell2.Text = "Source";
			this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell2.Weight = 0.91414853937023932D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.xrTableCell3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.xrTableCell3.Multiline = true;
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F);
			this.xrTableCell3.StylePriority.UseBackColor = false;
			this.xrTableCell3.StylePriority.UseFont = false;
			this.xrTableCell3.StylePriority.UsePadding = false;
			this.xrTableCell3.StylePriority.UseTextAlignment = false;
			this.xrTableCell3.Text = "Target";
			this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell3.Weight = 0.96362638079988439D;
			// 
			// xrCheckBox1
			// 
			this.xrCheckBox1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[ReportItems].[Detail].[DrillDownExpanded]")});
			this.xrCheckBox1.GlyphOptions.CustomGlyphs.Checked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrCheckBox1.GlyphOptions.CustomGlyphs.Checked"));
			this.xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked = new DevExpress.XtraPrinting.Drawing.ImageSource("svg", resources.GetString("xrCheckBox1.GlyphOptions.CustomGlyphs.Unchecked"));
			this.xrCheckBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrCheckBox1.Name = "xrCheckBox1";
			this.xrCheckBox1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrCheckBox1.SizeF = new System.Drawing.SizeF(19.92188F, 17.08332F);
			// 
			// objectDataSource1
			// 
			this.objectDataSource1.DataMember = "Create";
			this.objectDataSource1.DataSource = typeof(DevExpressReport.DataSources.ReportDataSetFactory);
			this.objectDataSource1.Name = "objectDataSource1";
			// 
			// objectDataSource2
			// 
			this.objectDataSource2.DataMember = "Create";
			this.objectDataSource2.DataSource = typeof(DevExpressReport.DataSources.ReportDataSetFactory);
			this.objectDataSource2.Name = "objectDataSource2";
			// 
			// XtraReport1
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1,
            this.objectDataSource2});
			this.DataSource = this.objectDataSource2;
			this.Font = new System.Drawing.Font("Arial", 9.75F);
			this.Margins = new System.Drawing.Printing.Margins(100, 93, 31, 441);
			this.Version = "21.2";
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.XRCheckBox xrCheckBox1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		private DevExpress.XtraReports.UI.XRTable xrTable1;
		private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
		private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
		private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource2;
	}
}
