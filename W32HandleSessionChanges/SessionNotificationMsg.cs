/// <summary>Tipo de notificacion recibida</summary>
public enum SessionNotificationMsg
{
    /// <summary>Una sesión se ha conectado por terminal de consola.</summary>
    WTS_CONSOLE_CONNECT = 0x1,
    /// <summary>Una sesión se ha desconectado por terminal de consola.</summary>
    WTS_CONSOLE_DISCONNECT = 0x2,
    /// <summary>Una sesión se ha conectado por una terminal remota.</summary>
    WTS_REMOTE_CONNECT = 0x3,
    /// <summary>Una sesión de terminal remota se ha desconectado.</summary>
    WTS_REMOTE_DISCONNECT = 0x4,
    /// <summary>Un usuario se ha logueado en la sesión.</summary>
    WTS_SESSION_LOGON = 0x5,
    /// <summary>Un usuario se ha deslogueado de la sesión.</summary>
    WTS_SESSION_LOGOFF = 0x6,
    /// <summary>Una sesión se ha bloqueado.</summary>
    WTS_SESSION_LOCK = 0x7,
    /// <summary>Una sesión se ha desbloqueado.</summary>
    WTS_SESSION_UNLOCK = 0x8,
    /// <summary>Una sesión ha cambiado su estado de control remoto. Par determinar el estado se debe hacer uso de GetSystemMetrics y revisar la métrica SM_REMOTECONTROL.</summary>
    WTS_SESSION_REMOTE_CONTROL = 0x9
}
