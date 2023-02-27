namespace IHER.Components.FlyoutAPP;

public class FlyoutHeaderView : ContentView
{
	public FlyoutHeaderView()
	{
        Content = new StackLayout
        {
            Margin = new Thickness(0, 0, 0, 10),
            Children =
            {
                new Image
                    {
                        Source="bg.png",
                        HorizontalOptions = LayoutOptions.Center,
                        Shadow = new Shadow{Radius=20},
                    }                                
            }
        };
    }
}