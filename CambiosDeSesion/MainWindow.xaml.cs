using System;
using System.Windows;
using System.Windows.Interop;

namespace CambiosDeSesion
{
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
    }

WindowInteropHelper interopHelper;
private void Window_Loaded(object sender, RoutedEventArgs e)
{
    //Conseguir el Handle de la ventana
    interopHelper = new WindowInteropHelper(this);

    //Crear un hook al WndProc
    HwndSource sourceWindow = HwndSource.FromHwnd(interopHelper.Handle);
    sourceWindow.AddHook(WndProc);
}

    private void Window_Unloaded(object sender, RoutedEventArgs e)
    {
        if (interopHelper != null)
        {
            W32HandleSessionChanges.WTSUnRegisterSessionNotification(interopHelper.Handle);
        }
    }

private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
{
    if (msg == W32HandleSessionChanges.WM_WTSSESSION_CHANGE)
    {
        var name = Enum.GetName(typeof(SessionNotificationMsg), (SessionNotificationMsg)wParam);
        this.listBoxOne.Items.Add(name);
        handled = true;
        return (IntPtr)1;
    }
            
    return IntPtr.Zero;
}
}
}
