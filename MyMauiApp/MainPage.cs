using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace MyMauiApp {public class MainPage :ContentPage {
public MainPage() {
    Title="MAUI minus XAML";
    BackgroundColor=Color.FromHex("000000");
    Label TopLabel=new Label{
        HorizontalTextAlignment=Microsoft.Maui.TextAlignment.Center,
        VerticalTextAlignment=Microsoft.Maui.TextAlignment.Center,
        };
    TopLabel.TextColor=Color.FromHex("009933");
    TopLabel.Text="Welcome to MAUI minus XAML!";
    Content=TopLabel;
    }

}}