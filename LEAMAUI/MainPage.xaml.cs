using Microcharts;
using SkiaSharp;

namespace LEAMAUI
{
    public partial class MainPage : ContentPage
    {
        ChartEntry[] entries = new[]
        {
            new ChartEntry(212)
            {
                
                
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(248)
            {
                
                
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(128)
            {
                
                
                Color = SKColor.Parse("#b455b6")
            },
        };

        public MainPage()
        {
            InitializeComponent();

            chartView.Chart = new LineChart
            {
                Entries = entries,
                BackgroundColor = SKColors.Transparent,
               
                
            };

        }

    }

}
