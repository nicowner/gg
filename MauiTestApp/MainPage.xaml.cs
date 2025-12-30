using System;

namespace MauiTestApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        // Use packaged image directly
        LogoImage.Source = "logo.jpg";
    }

    private async void OnTestClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Test", "Düğmeye basıldı!", "Tamam");
    }
}
