﻿#if IOS || MACCATALYST
global using Foundation;
global using ObjCRuntime;
global using WebKit;
#endif

using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiApp1.Data;



namespace MauiApp1;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
