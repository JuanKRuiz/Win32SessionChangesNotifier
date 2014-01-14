using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CambiosDeSesionForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void Form1_Load(object sender, EventArgs e)
{
    //Registramos la forma para recibir notificaciones
    W32HandleSessionChanges.WTSRegisterSessionNotification(this.Handle, NotifyType.NOTIFY_FOR_ALL_SESSIONS);
}

private void Form1_FormClosed(object sender, FormClosedEventArgs e)
{
    //Des Registramos la forma para no recibir notificaciones
    W32HandleSessionChanges.WTSUnRegisterSessionNotification(this.Handle);
}

protected override void WndProc(ref Message m)
{
    //Verificamos cuando el mensaje recibido sea el de cambios en la sesión
    if (m.Msg == W32HandleSessionChanges.WM_WTSSESSION_CHANGE)
    {
        //convertimos el valor de wParam a su equivalente en nombre del enum
        var name = Enum.GetName(typeof(SessionNotificationMsg), (SessionNotificationMsg)m.WParam);
        this.listBox1.Items.Add(name);
    }
    base.WndProc(ref m);
}
    }
}
