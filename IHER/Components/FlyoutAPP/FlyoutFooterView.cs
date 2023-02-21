using System.Reflection;

namespace IHER.Components.FlyoutAPP;

public class FlyoutFooterView : ContentView
{
    private string _derechos = $"{DateTime.Now.Year} © {Assembly.GetExecutingAssembly().GetName().Name}";
    private string _versionAPP = $"Versión {Assembly.GetExecutingAssembly().GetName().Version}";
    private ImageButton WhatsAppButton;
    private ImageButton FacebookButton;
    private ImageButton InstagramButton;
    private ImageButton GmailButton;
    private ImageButton TwitterButton;
    private ImageButton YoutubeButton;
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
                Margin = new Thickness(0,10,0,0),
                BackgroundColor = (Color)App.Current.Resources.MergedDictionaries.First()["Primary"],
                Children =
                {
                    WhatsApp(),
                    Facebook(),
                    Instagram(),
                    Gmail(),
                    Twitter(),
                    Youtube()
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
                FontFamily = "WebFonts",
                Glyph = "\U000F05A3",
                Size = 25
            },
            VerticalOptions=LayoutOptions.CenterAndExpand,
            HorizontalOptions=LayoutOptions.CenterAndExpand,
            Padding=new Thickness(0,6,0,6),
        };
        return WhatsAppButton;
    }
    private ImageButton Facebook()
    {
        FacebookButton = new ImageButton
        {
            Source = new FontImageSource
            {
                FontFamily = "WebFonts",
                Glyph = "\U000F020C",
                Size = 30
            },
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            Padding = new Thickness(0, 6, 0, 6),
        };
        return FacebookButton;
    }
    private ImageButton Instagram()
    {
        InstagramButton = new ImageButton
        {
            Source = new FontImageSource
            {
                FontFamily = "WebFonts",
                Glyph = "\U000F02FE",
                Size = 30
            },
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            Padding = new Thickness(0, 6, 0, 6),
        };
        return InstagramButton;
    }
    private ImageButton Gmail()
    {
        GmailButton = new ImageButton
        {
            Source = new FontImageSource
            {
                FontFamily = "WebFonts",
                Glyph = "\U000F02AB",
                Size = 30
            },
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            Padding = new Thickness(0, 6, 0, 6),
        };
        return GmailButton;
    }
    private ImageButton Twitter()
    {
        TwitterButton = new ImageButton
        {
            Source = new FontImageSource
            {
                FontFamily = "WebFonts",
                Glyph = "\U000F0544",
                Size = 30
            },
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            Padding = new Thickness(0, 6, 0, 6),
        };
        return TwitterButton;
    }
    private ImageButton Youtube()
    {
        YoutubeButton = new ImageButton
        {
            Source = new FontImageSource
            {
                FontFamily = "WebFonts",
                Glyph = "\U000F05C3",
                Size = 30
            },
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            Padding = new Thickness(0, 6, 0, 6),
        };
        return YoutubeButton;
    }
}