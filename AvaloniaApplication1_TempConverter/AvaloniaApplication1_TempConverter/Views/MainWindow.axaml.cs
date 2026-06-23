using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Diagnostics;
using Avalonia.Metadata;
using System.Diagnostics;

namespace AvaloniaApplication1_TempConverter.Views
{
    public partial class MainWindow : Window
    {
        private string unit = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Celsius_TextChanged(object? sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Celsius.Text) || Celsius.Text == "-")
            {
                Fahrenheit.Text = "";
            }
            else if (double.TryParse(Celsius.Text, out double C))
            {
                var F = C * (9d / 5d) + 32;

                Fahrenheit.Text = F.ToString("0.0");
            }
            else
            {
                unit = "Celsius";
                Handling_incorrectInput();
            }
        }

        private void Fahrenheit_TextChanged(object? sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Fahrenheit.Text) || Fahrenheit.Text == "-")
            {
                Celsius.Text = "";
            }
            else if (double.TryParse(Fahrenheit.Text, out double F))
            {
                var C = (F - 32) * 5d / 9d;

                Celsius.Text = C.ToString("0.0");
            }
            else
            {
                unit = "Fahrenheit";
                Handling_incorrectInput();
            }
        }

        private void Handling_incorrectInput()
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";

            Debug.WriteLine($"Invalid input for {unit} temperature.");
        }
    }
}