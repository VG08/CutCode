﻿using Stylet;
using StyletIoC;

namespace CutCode
{
    public class Bootstrapper : Bootstrapper<MainViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            builder.Bind<IThemeService>().To<ThemeService>(); 
            builder.Bind<IPageService>().To<PageService>();
        }
    }
}
