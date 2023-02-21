using IHER.Helper;

namespace IHER.Pages;
public class ValoresPage : ContentPage
{
    private readonly IHelperInterface ui;

    [Obsolete]
    public ValoresPage()
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
                                ui.SubTitle("Solidaridad"),
                                ui.BodyText("Representa para el IHER el sentido existencial. La solidaridad se vive, como el sentimiento y la actitud de unidad y apoyo incondicional hacia las personas que est�n en circunstancias de dificultad, manteniendo con ellas un nexo estrecho con el objetivo de lograr un fin com�n."),
                                ui.SubTitle("Responsabilidad"),
                                ui.BodyText("Vivido desde el IHER, como el valor que, en un v�nculo con el pr�jimo, garantiza el cumplimiento de los compromisos con diligencia, seriedad y prudencia, generando confianza y tranquilidad, haciendo las cosas correctas en todo momento y respondiendo por cada una de nuestras acciones."),
                                ui.SubTitle("Honestidad"),
                                ui.BodyText("Institucionalmente representa el valor que desde la moralidad insta, bajo cualquier circunstancia, a decir y promover la verdad, actuando de forma transparente en nuestras relaciones con los dem�s en cada una de las acciones que promovemos."),
                                ui.SubTitle("Audacia"),
                                ui.BodyText("En el IHER estamos convencidos de que, pese a las posibilidades y riegos que nos rodean en todos los contextos, podremos alcanzar nuestra meta, siempre con calidad, esmero y con la entrega al pr�jimo que nos caracteriza"),

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