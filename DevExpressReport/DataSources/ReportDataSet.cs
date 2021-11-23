using System;
using System.Collections.Generic;

namespace DevExpressReport.DataSources
{
	public class ReportDataSet
	{
		public int ID { get; set; }
		public int ParentID { get; set; }
		public string Caption { get; set; }
		public string SourceValue { get; set; }
		public string TargetValue { get; set; }
	}

	public class ReportRow
	{
		public string Caption { get; set; }
		public string Source { get; set; }
		public string Target { get; set; }
		public List<ReportRow> Rows { get; set; }
	}

	public static class ReportDataSetFactory
	{
		public static List<ReportDataSet> Create()
		{
			return new List<ReportDataSet>()
			{
				new ReportDataSet
				{
					ID = 0,
					ParentID = -1,
					Caption = "Header 1",
					SourceValue = "",
					TargetValue = ""
				},
				new ReportDataSet
				{
					ID = 1,
					ParentID = 0,
					Caption = "Category 1",
					SourceValue = "",
					TargetValue = ""
				},
				new ReportDataSet
				{
					ID = 2,
					ParentID = 1,
					Caption = "Signal group 1",
					SourceValue = "aaa",
					TargetValue = "bbb"
				},
				new ReportDataSet
				{
					ID = 3,
					ParentID = 1,
					Caption = "Signal group 2",
					SourceValue = "",
					TargetValue = ""
				},
				new ReportDataSet
				{
					ID = 4,
					ParentID = -1,
					Caption = "Header 2",
					SourceValue = "",
					TargetValue = ""
				},
				new ReportDataSet
				{
					ID = 5,
					ParentID = 4,
					Caption = "Category 2",
					SourceValue = "",
					TargetValue = ""
				},
			};
		}

		public static List<ReportRow> CreateRows()
		{
			var randomValue = 1;
			return new List<ReportRow>()
			{
				new ReportRow()
				{
					Caption = "Category 1",
					Rows = new List<ReportRow>()
					{
						new ReportRow()
						{
							Caption = "SubCategory 1",
							Rows = new List<ReportRow>()
							{
								new ReportRow()
								{
									Caption = "Diff caption",
									Source = "Source change",
									Target = "Target change"
								}
							}
						}
					}},
				new ReportRow()
				{
					Caption = "Category 2",
					Rows = new List<ReportRow>()
					{
						new ReportRow()
						{
							Caption = "SubCategory 2",
							Rows = new List<ReportRow>()
							{
								new ReportRow()
								{
									Caption = "SubCategory 3",
									Rows = new List<ReportRow>()
									{
										new ReportRow()
										{
											Caption = "Diff caption " + randomValue++,
											Source = Guid.NewGuid().ToString(),
											Target = Guid.NewGuid().ToString()
										},
										new ReportRow()
										{
											Caption = "Diff caption " + randomValue++,
											Source = Guid.NewGuid().ToString(),
											Target = Guid.NewGuid().ToString()
										},
										new ReportRow()
										{
											Caption = "Diff caption " + randomValue++,
											Source = Guid.NewGuid().ToString(),
											Target = Guid.NewGuid().ToString()
										},
										new ReportRow()
										{
											Caption = "Diff caption " + randomValue++,
											Source = Guid.NewGuid().ToString(),
											Target = Guid.NewGuid().ToString()
										},
										new ReportRow()
										{
											Caption = "Diff caption " + randomValue++,
											Source = Guid.NewGuid().ToString(),
											Target = Guid.NewGuid().ToString()
										},
									}
								}
							}
						}
					}},
			};
		}
	}

}
