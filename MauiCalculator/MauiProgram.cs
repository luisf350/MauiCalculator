﻿namespace MauiCalculator;

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
                fonts.AddFont("Sublima-ExtraBold.otf", "SublimaBold");
                fonts.AddFont("Sublima-Light.otf", "SublimaLight");
            });

		return builder.Build();
	}
}
