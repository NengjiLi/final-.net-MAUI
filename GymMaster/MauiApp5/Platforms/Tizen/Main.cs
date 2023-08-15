using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MauiApp5;

class Program : MauiApplication
{
    protected override MauiApp CreateMauiApp() => MauiProgram.GetCreateMauiApp();

    static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}
