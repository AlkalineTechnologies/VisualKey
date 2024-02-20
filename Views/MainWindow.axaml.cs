using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace visualkey.Views;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        var GradientBrush = new RadialGradientBrush {
            GradientStops = new GradientStops {
                new GradientStop(Color.Parse("#0b001f"), 0),
                new GradientStop(Color.Parse("#5600f3"), 1.0),
            },
            // Center = new RelativePoint(1,1, RelativeUnit.Relative),
            GradientOrigin = new RelativePoint(1,1, RelativeUnit.Relative),
            Radius = 1.5
        };
        Background = GradientBrush;
    }
}