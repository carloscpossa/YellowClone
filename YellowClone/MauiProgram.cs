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
                    h.AddHandler<CustomMap, MapHandler>();
#if ANDROID
                    h.AddHandler<CustomPin, MapPinHandler>();
#endif
                });
            Controls.PlatformCustomMap.CreateCustomMap();
            return builder.Build();
        }
    }
}

