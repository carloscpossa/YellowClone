﻿using System;
using Microsoft.Maui.Maps.Handlers;
using YellowClone.Controls;

namespace YellowClone
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiMaps()
                .UseMauiApp<App>()
                .ConfigureMauiHandlers(h =>
                {
#if ANDROID
                    h.AddHandler<CustomMap, Platforms.Android.CustomMapHandler>();
#endif
                });
            //Controls.PlatformCustomMap.CreateCustomMap();
            return builder.Build();
        }
    }
}

