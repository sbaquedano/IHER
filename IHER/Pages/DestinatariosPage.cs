using IHER.Helper;

namespace IHER.Pages;

public class DestinatariosPage : ContentPage
{
    private readonly IHelperInterface ui;

    [Obsolete]
    public DestinatariosPage()
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
                            ui.Title("Instituto Hondure�o de Educaci�n por Radio IHER"),
                                ui.BodyText("El IHER ofrece a nivel nacional una Educaci�n B�sica y Media Alternativa, bajo Acuerdo Nacional N� 0758-SE-2015 de fecha 02 de junio de 2015."),
                                ui.BodyText("Orientada hacia aquellas personas a partir de 14 a�os que por falta de recursos econ�micos, largas distancias a los centros educativos o  " +
                                "por razones de edad, g�nero u origen �tnico, no han tenido acceso a una educaci�n formal. El IHER les brinda a estas personas la oportunidad de obtener " +
                                "un certificado  de estudios primarios y t�tulo de estudios secundarios mediante la educaci�n a distancia.")
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