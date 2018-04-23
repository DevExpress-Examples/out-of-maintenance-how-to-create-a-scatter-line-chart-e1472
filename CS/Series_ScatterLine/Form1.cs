using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_ScatterLine {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl scatterLineChart = new ChartControl();

            // Create a scatter line series.
            Series series1 = new Series("Series 1", ViewType.ScatterLine);

            // Add points to it.
            series1.Points.Add(new SeriesPoint(1, 2));
            series1.Points.Add(new SeriesPoint(2, 10));
            series1.Points.Add(new SeriesPoint(3, 4));
            series1.Points.Add(new SeriesPoint(4, 12));
            series1.Points.Add(new SeriesPoint(1.5, 17));
            series1.Points.Add(new SeriesPoint(2.5, 3));
            series1.Points.Add(new SeriesPoint(3.5, 14));
            series1.Points.Add(new SeriesPoint(2, 6));

            // Add the series to the chart.
            scatterLineChart.Series.Add(series1);

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((ScatterLineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Dash;

            // Access the type-specific options of the diagram.
            ((XYDiagram)scatterLineChart.Diagram).Rotated = true;

            // Hide the legend (if necessary).
            scatterLineChart.Legend.Visible = false;

            // Add a title to the chart (if necessary).
            scatterLineChart.Titles.Add(new ChartTitle());
            scatterLineChart.Titles[0].Text = "A Scatter Line Chart";

            // Add the chart to the form.
            scatterLineChart.Dock = DockStyle.Fill;
            this.Controls.Add(scatterLineChart);
        }
    }
}