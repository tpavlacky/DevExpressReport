using DevExpress.Xpf.Core;
using System.Windows;
using DevExpress.Xpf.Printing;
using DevExpressReport.Reports;

namespace DevExpressReport
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : ThemedWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			// Invoke the Ribbon Print Preview window 
			// and load the report document into it.
			PrintHelper.ShowRibbonPrintPreview(this, new XtraReport1());
			PrintHelper.ShowRibbonPrintPreview(this, new XtraReport2());

			//// Invoke the Ribbon Print Preview window modally.
			//PrintHelper.ShowRibbonPrintPreviewDialog(this, new XtraReport1());

			//// Invoke the standard Print Preview window 
			//// and load the report document into it.
			//PrintHelper.ShowPrintPreview(this, new XtraReport1());

			//// Invoke the standard Print Preview window modally.
			//PrintHelper.ShowPrintPreviewDialog(this, new XtraReport1());
		}
	}
}
