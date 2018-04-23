Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_ScatterLine
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a new chart.
			Dim scatterLineChart As New ChartControl()

			' Create a scatter line series.
			Dim series1 As New Series("Series 1", ViewType.ScatterLine)

			' Add points to it.
			series1.Points.Add(New SeriesPoint(1, 2))
			series1.Points.Add(New SeriesPoint(2, 10))
			series1.Points.Add(New SeriesPoint(3, 4))
			series1.Points.Add(New SeriesPoint(4, 12))
			series1.Points.Add(New SeriesPoint(1.5, 17))
			series1.Points.Add(New SeriesPoint(2.5, 3))
			series1.Points.Add(New SeriesPoint(3.5, 14))
			series1.Points.Add(New SeriesPoint(2, 6))

			' Add the series to the chart.
			scatterLineChart.Series.Add(series1)

			' Set the numerical argument scale types for the series,
			' as it is qualitative, by default.
			series1.ArgumentScaleType = ScaleType.Numerical

			' Access the view-type-specific options of the series.
			CType(series1.View, ScatterLineSeriesView).LineStyle.DashStyle = DashStyle.Dash

			' Access the type-specific options of the diagram.
			CType(scatterLineChart.Diagram, XYDiagram).Rotated = True

			' Hide the legend (if necessary).
			scatterLineChart.Legend.Visible = False

			' Add a title to the chart (if necessary).
			scatterLineChart.Titles.Add(New ChartTitle())
			scatterLineChart.Titles(0).Text = "A Scatter Line Chart"

			' Add the chart to the form.
			scatterLineChart.Dock = DockStyle.Fill
			Me.Controls.Add(scatterLineChart)
		End Sub
	End Class
End Namespace