using Microsoft.Maui.Controls;
using System;

namespace MyMauiApp {public class App :Application {
public App() {
    AppDomain.CurrentDomain.FirstChanceException+=CurrentDomain_FirstChanceException;
    MainPage=new MainPage();
    }

private void CurrentDomain_FirstChanceException(object sender,System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
{
System.Diagnostics.Debug.WriteLine($"********************************** UNHANDLED EXCEPTION! Details: {e.Exception.ToString()}");
}

protected override void OnStart()
{
base.OnStart();
}

protected override void OnSleep()
{
base.OnSleep();
}

protected override void OnResume()
{
base.OnResume();
}

}}
