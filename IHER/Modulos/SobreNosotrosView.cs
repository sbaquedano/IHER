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
				ui.Title("IHER (Instituto Hondureño de Educación Por Radio)")
			}
		};
	}
}