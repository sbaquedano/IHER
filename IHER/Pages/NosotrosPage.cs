using IHER.Helper;

namespace IHER.Pages;

public class NosotrosPage : ContentPage
{
    private readonly IHelperInterface ui;

    [Obsolete]
    public NosotrosPage()
	{
        ui = DependencyService.Get<IHelperInterface>();
        BackgroundColor = (Color)App.Current.Resources.MergedDictionaries.First()["BackgroundColor"];
        ScrollView scrollView = new ScrollView
        {
            VerticalOptions = LayoutOptions.FillAndExpand,
            Content = new VerticalStackLayout
            {
                Margin = new Thickness(10),
                Children = {
                new StackLayout
                {
                    new StackLayout {
                            Padding = new Thickness(0,10,0,10),
                            BackgroundColor = (Color)App.Current.Resources.MergedDictionaries.First()["White"],
                        Children = {
                            ui.Title("Instituto Hondureño de Educación por Radio IHER"),
                            ui.SubTitle("Misión"),
                            ui.BodyText("Formar personas audaces y solidarias para impulsar el progreso de los hondureños a través de metodologías innovadoras."),
                            ui.SubTitle("Visión"),
                            ui.BodyText("Ser un referente en soluciones de educación alternativa de alta calidad, innovadora e inclusiva, para promover el desarrollo integral de Honduras."),
                            }
                        },
                    }
                }
            }
        };
        Content = new StackLayout
        {
            Children = { scrollView }
        };
    }
}