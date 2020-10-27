using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace ChartsXam
{
    public partial class MainPage : ContentPage
    {

        private readonly ChartEntry[] entries = new[]
       {
            new ChartEntry(212)
            {
                Label = "UWP",
                ValueLabel = "112",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(248)
            {
                Label = "Android",
                ValueLabel = "648",
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(128)
            {
                Label = "iOS",
                ValueLabel = "428",
                Color = SKColor.Parse("#b455b6")
            },
            new ChartEntry(514)
            {
                Label = "Forms",
                ValueLabel = "214",
                Color = SKColor.Parse("#3498db")
            }
        };
        public MainPage()
        {
            InitializeComponent();

            chartViewBar.Chart = new BarChart { Entries = entries,
                ValueLabelOrientation = Orientation.Horizontal,
                LabelTextSize = 30 ,
                LabelOrientation = Orientation.Horizontal
                 
            };
            chartViewPie.Chart = new PieChart { Entries = entries, HoleRadius = 0.3f, LabelTextSize = 30 };
            chartViewLine.Chart = new LineChart
            {
                Entries = entries,
                LineMode = LineMode.Straight,
                LabelTextSize = 30,
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Horizontal
            };
            chartViewPoint.Chart = new PointChart
            {
                Entries = entries,
                PointMode = PointMode.Circle,
                PointSize = 38, LabelTextSize = 30,
                LabelOrientation = Orientation.Horizontal ,
                ValueLabelOrientation = Orientation.Horizontal};
     
            chartViewRadialGauge.Chart = new RadialGaugeChart { Entries = entries, LineSize = -1,LineAreaAlpha = 52,StartAngle = -90, LabelTextSize = 30 };
            chartViewRadar.Chart = new RadarChart { Entries = entries, LineSize = 3, LabelTextSize = 30 };
        }
    }
}
