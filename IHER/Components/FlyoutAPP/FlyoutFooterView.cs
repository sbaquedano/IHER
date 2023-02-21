using System.Reflection;

namespace IHER.Components.FlyoutAPP;

public class FlyoutFooterView : ContentView
{
    private string _derechos = $"{DateTime.Now.Year} © {Assembly.GetExecutingAssembly().GetName().Name}";
    private string _versionAPP = $"Versión {Assembly.GetExecutingAssembly().GetName().Version}";
    private ImageButton WhatsAppButton;
    public FlyoutFooterView()
	{
        Content = new StackLayout
        {
             new Label
            {
                Text=_derechos,
                HorizontalOptions = LayoutOptions.Center
            },
            new Label
            {
                Text = _versionAPP,
                HorizontalOptions = LayoutOptions.Center
            },
             new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Padding = new Thickness(10),
                BackgroundColor = (Color)App.Current.Resources.MergedDictionaries.First()["Primary"],
                Children =
                {
                    WhatsApp()
                }
            },
        };
    }
    private ImageButton WhatsApp()
    {
        WhatsAppButton = new ImageButton
        {
            Source = new FontImageSource 
                { 
                    FontFamily= "ionicons",
                    Glyph = "\uF05A3"
            },
        };
        
        return WhatsAppButton;
    }
}