using System;
using System.Runtime.InteropServices;

public static class W32HandleSessionChanges
{
    /// <summary>
    /// Registra una ventana para recibir notificaciones de cambios en las sesiones
    /// </summary>
    /// <param name="hWnd">Manejador de la ventana</param>
    /// <param name="dwFlags">Modificadores 
    /// <remarks>NOTIFY_FOR_THIS_SESSION, NOTIFY_FOR_ALL_SESSIONS</remarks>
    /// </param>
    /// <returns></returns>
    [DllImport("wtsapi32.dll", SetLastError = true)]
    public static extern bool WTSRegisterSessionNotification(IntPtr hWnd, NotifyType dwFlags);

    /// <summary>
    /// Des Registra una ventana que recibe notificaciones de cambios en las sesiones
    /// </summary>
    /// <param name="hWnd">Manejador de la ventana</param>
    /// <returns></returns>
    [DllImport("wtsapi32.dll", SetLastError = true)]
    public static extern bool WTSUnRegisterSessionNotification(IntPtr hWnd);

    /// <summary>Mensaje recibido cuando hay cambios en las sesiones</summary>
    public const int WM_WTSSESSION_CHANGE = 0x2b1;

}
