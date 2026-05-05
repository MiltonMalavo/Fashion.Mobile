using Microsoft.Extensions.Logging;
using Fashion.Mobile.Helpers;
namespace Fashion.Mobile;

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
				fonts.AddFont("Poppins-Regular.ttf", FontsSettigns.POPPINS_REGULAR);
				fonts.AddFont("Poppins-Medium.ttf", FontsSettigns.POPPINS_MEDIUM);
				fonts.AddFont("Poppins-Bold.ttf", FontsSettigns.POPPINS_BOLD);

			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

builder.ConfigureMauiHandlers(handlers =>
{
    Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
    {
        #if ANDROID
            handler.PlatformView.Background = null; // Remove a linha no Android
        #elif IOS || MACCATALYST
                            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None; // Remove borda no iOS
        #endif
    });
});
		return builder.Build();
	}
}
