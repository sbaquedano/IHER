using IHER.Helper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IHER;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("MaterialIcons-Regular.ttf", "Iconos");
				fonts.AddFont("ionicons.ttf", "ionicons");
				fonts.AddFont("materialdesignicons-webfont.ttf", "WebFonts");
			});
        DependencyService.Register<IHelperInterface, HelperInterface>();
        return builder.Build();
	}
}
