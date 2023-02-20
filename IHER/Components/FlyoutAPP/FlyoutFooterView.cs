using System.Reflection;

namespace IHER.Components.FlyoutAPP;

public class FlyoutFooterView : ContentView
{
    private string _derechos = $"{DateTime.Now.Year} © {Assembly.GetExecutingAssembly().GetName().Name}";
    private string _versionAPP = $"Versión {Assembly.GetExecutingAssembly().GetName().Version}";
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
                }
        };
    }
}