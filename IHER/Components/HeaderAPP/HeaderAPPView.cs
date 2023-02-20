namespace IHER.Components.HeaderAPP;

public class HeaderAPPView : ContentView
{
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