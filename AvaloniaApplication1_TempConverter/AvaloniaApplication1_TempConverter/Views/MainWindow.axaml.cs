using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Diagnostics;
using Avalonia.Metadata;
using System.Diagnostics;

namespace AvaloniaApplication1_TempConverter.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate(object? sender, RoutedEventArgs e)
        {
            if (double.TryParse(Celsius.Text, out double C))
            {
                var F = C * (9d / 5d) + 32;

                Fahrenheit.Text = F.ToString("0.0");
            }
            else
            {
                Celsius.Text = "0";
                Fahrenheit.Text = "0";

                Debug.WriteLine("Invalid input for Celsius temperature.");
            }
        }

        private void Celsius_TextChanged(object? sender, TextChangedEventArgs e)
        {
            Calculate(sender, e);
        }
    }
}