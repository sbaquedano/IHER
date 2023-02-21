using IHER.Helper;

namespace IHER.Pages;
public class LogrosPage : ContentPage
{
    private readonly IHelperInterface ui;

    [Obsolete]
    public LogrosPage()
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
                            ui.BodyText("Treinta y dos años de experiencia coordinando acciones con las comunidades urbanos marginales y rurales de Honduras para abrir oportunidades de educación AUTO SOSTENIBLES."),
                            ui.BodyText("Estructura de funcionamiento nacional bajo un mismo paraguas jurídico, pedagogíco y de acuerdos educativos. Con descentralización financiera."),
                            ui.BodyText("184 titulos de libros de autoaprendizaje que sirven de texto y cuaderno de trabajo para cada estudiante desarrollando en curriculo nacional basico actual, desde basica hasta bachilleratos."),
                            ui.BodyText("Material de apoyo y reforzamiento para el aprendizaje como programas radiales, podcast, tutoriales y videos educativos."),
                            ui.BodyText("Bachilleres graduados: 89,321."),
                            ui.BodyText("Cadena de producción de materiales impresos desde redacción, diseño e impresión."),
                            ui.BodyText("Cadena de producción de materiales impresos desde redacción, diseño e impresión.")
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