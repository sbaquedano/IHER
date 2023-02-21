using IHER.Helper;

namespace IHER.Modulos;

public class SobreNosotrosView : ContentView
{
    private readonly IHelperInterface ui;
    public SobreNosotrosView()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				ui.Title("IHER (Instituto Hondure�o de Educaci�n Por Radio)")
			}
		};
	}
}