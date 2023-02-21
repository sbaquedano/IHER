using System.Reflection;
using WhtasAppOpen.Net.Maui;

namespace IHER.Components.FlyoutAPP;

public class FlyoutFooterView : ContentView
{
    private string _derechos = $"{DateTime.Now.Year} © {Assembly.GetExecutingAssembly().GetName().Name}";
    private string _versionAPP = $"Versión {Assembly.GetExecutingAssembly().GetName().Version}";
    private bool EnAccion;
    private ImageButton WhatsAppButton;
    private ImageButton FacebookButton;
    private ImageButton InstagramButton;
    private ImageButton GmailButton;
    private ImageButton TwitterButton;
    private ImageButton YoutubeButton;

    [Obsolete]
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
                BackgroundColor = (Color)App.Current.Resources.MergedDictionaries.First()["Tertiary"],
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

    [Obsolete]
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
        WhatsAppButton.Clicked += LlamarWhatsApp;
        return WhatsAppButton;
    }

    [Obsolete]
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
        FacebookButton.Clicked += LlamarFacebook;
        return FacebookButton;
    }

    [Obsolete]
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
        InstagramButton.Clicked += LlamarInstagram;
        return InstagramButton;
    }

    [Obsolete]
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
        GmailButton.Clicked += LlamarGmail;
        return GmailButton;
    }

    [Obsolete]
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
        TwitterButton.Clicked += LlamarTwitter;
        return TwitterButton;
    }

    [Obsolete]
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
        YoutubeButton.Clicked += LlamarYouTube;
        return YoutubeButton;
    }
    void LlamarWhatsApp(object sender, EventArgs e)
    {
        if (EnAccion)
            return;
        EnAccion = true;

        string _saludo;
        var hora = DateTime.Now.Hour;
        if (hora > 17) { _saludo = "Buenas noches"; } else if (hora > 11) { _saludo = "Buenas tardes"; } else { _saludo = "Buen día"; }

        WhtasAppOpen.Net.Maui.WhatsApp.OpenWithMessage("+50496253694", $"{_saludo}, soy un usuario de la aplicación de IHER, quiero consultar algo.");
      

        EnAccion = false;
    }
    async void LlamarFacebook(object sender, EventArgs e)
    {
        if (EnAccion)
            return;

        EnAccion = true;

        //var result = await DependencyService.Get<IAppHandler>().LaunchApp("com.companyname.app3");
        await Launcher.OpenAsync(new Uri("https://www.facebook.com/Iher.hn"));

        EnAccion = false;
    }

    async void LlamarInstagram(object sender, EventArgs e)
    {
        if (EnAccion)
            return;

        EnAccion = true;

        await Launcher.OpenAsync(new Uri("https://instagram.com/iher_central?igshid=YmMyMTA2M2Y="));

        EnAccion = false;
    }

    async void LlamarYouTube(object sender, EventArgs e)
    {
        if (EnAccion)
            return;

        EnAccion = true;

        await Launcher.OpenAsync(new Uri("https://youtube.com/@ihercentral5739"));

        EnAccion = false;
    }
    async void LlamarTwitter(object sender, EventArgs e)
    {
        if (EnAccion)
            return;

        EnAccion = true;

        await Launcher.OpenAsync(new Uri("https://twitter.com/IHER_Central?t=3c748iYUmE0fGA4OQ5ntdw&s=09"));

        EnAccion = false;
    }
    async void LlamarGmail(object sender, EventArgs e)
    {
        if (EnAccion)
            return;

        EnAccion = true;
        string _saludo;
        var hora = DateTime.Now.Hour;
        if (hora > 17) { _saludo = "Buenas noches"; } else if (hora > 11) { _saludo = "Buenas tardes"; } else { _saludo = "Buen día"; }

        if (Email.Default.IsComposeSupported)
        {
            var message = new EmailMessage
            {
                Subject = "Consulta usuario IHER APP",
                Body = $"{_saludo}, soy un usuario de la aplicación de IHER, quiero consultar algo.",
                BodyFormat = EmailBodyFormat.PlainText,
                To = new List<string> { "iher90@hotmail.com" }
            };
            await Email.Default.ComposeAsync(message);
        }
        EnAccion = false;
    }
}