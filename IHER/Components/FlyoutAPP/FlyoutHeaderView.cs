namespace IHER.Components.FlyoutAPP;

public class FlyoutHeaderView : ContentView
{
	public FlyoutHeaderView()
	{
        Content = new StackLayout
        {
            Children =
            {
                new Image
                    {
                        Source="bg.png",
                        HorizontalOptions = LayoutOptions.Center
                    }                                
            }
        };
    }
}