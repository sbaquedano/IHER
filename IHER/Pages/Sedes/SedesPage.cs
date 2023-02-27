using IHER.Helper;

namespace IHER.Pages.Sedes;
public class SedesPage : ContentPage
{
    private readonly IHelperInterface ui;
    private string _selectDepartament;
    private Picker DepartamentListPicker;
    private StackLayout _infoSedes;

    [Obsolete]
    public SedesPage()
    {
        ui = DependencyService.Get<IHelperInterface>();
        BackgroundColor = (Color)Application.Current.Resources.MergedDictionaries.First()["BackgroundColor"];
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
                            BackgroundColor = (Color)Application.Current.Resources.MergedDictionaries.First()["White"],
                            Children = {
                            ui.Title("Sedes"),
                            ui.SubTitle("Departamento:"),
                            SedesList(),
                            InfoSedes(),
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
    public Picker SedesList()
    {
        var ListaDepartamentos = new List<string>();
        ListaDepartamentos.Add("Atlántida");
        ListaDepartamentos.Add("Colón");
        ListaDepartamentos.Add("Comayagua");
        ListaDepartamentos.Add("Copán");
        ListaDepartamentos.Add("Cortés");
        ListaDepartamentos.Add("Choluteca");
        ListaDepartamentos.Add("Francisco Morazán");
        ListaDepartamentos.Add("Gracias a Dios");
        ListaDepartamentos.Add("Intibucá");
        ListaDepartamentos.Add("Islas de la Bahía");
        ListaDepartamentos.Add("La Paz");
        ListaDepartamentos.Add("Lempira");
        ListaDepartamentos.Add("Ocotepeque");
        ListaDepartamentos.Add("Olancho");
        ListaDepartamentos.Add("Santa Bárbara");
        ListaDepartamentos.Add("Valle");
        ListaDepartamentos.Add("Yoro");

        DepartamentListPicker = new Picker
        {
            Title = "Seleccione un departamento",
            HorizontalTextAlignment = TextAlignment.Center
        };
        DepartamentListPicker.ItemsSource = ListaDepartamentos;
        DepartamentListPicker.SelectedIndexChanged += MostrarSedes;
        return DepartamentListPicker;
    }
    public StackLayout InfoSedes()
    {
        if (!string.IsNullOrWhiteSpace(_selectDepartament))
        {
            if (_selectDepartament is "Atlántida")
            {
                _infoSedes = new StackLayout
                {
                    ui.SubTitle("Arizona:"),
                    ui.BodyText("3140-3290"),
                    ui.BodyText("2448-2349"),
                    ui.BodyText("3339-2130"),
                    ui.SubTitle("La Ceiba:"),
                    ui.BodyText("9879-8686"),
                    ui.BodyText("2441-0986")
                };
            }
            if (_selectDepartament is "Colón")
            {
                _infoSedes = new StackLayout
                {
                    ui.SubTitle("Trujillo:"),
                    ui.BodyText("9859-9391"),
                    ui.BodyText("9690-8970")
                };
            }
        }
        return _infoSedes;
    }
    void MostrarSedes(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            _selectDepartament = picker.Items[selectedIndex];
        }
        InfoSedes();
    }
}