namespace IHER.Components.HeaderAPP;

public class HeaderAPPView : ContentView
{
    [Obsolete]
    public HeaderAPPView()
	{
        Content = new StackLayout
        {
            Children =
            {
                new Image
                {
                    Source="logo.png",
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    VerticalOptions  = LayoutOptions.CenterAndExpand,
                    HeightRequest = 30
                }
            }
        };
    }
}