using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.ServiceBus.Notifications;

namespace ASP_Material
{
    public partial class Notifications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
        }
        protected void Button_Guardar_Click(object sender, EventArgs e)
        {
            string mensaje = TextBoxMensaje.Text;
            SendNotificationAsync(mensaje);
            LabelAviso.Visible = true;
            TextBoxMensaje.Text = "";
        }

        private async void SendNotificationAsync(string mensaje)
        {
            //Windows (Aun con claves del Pulso)
            //NotificationHubClient hub = NotificationHubClient
            //    .CreateClientFromConnectionString("Endpoint=sb://elpulsohub-ns.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=7SnsXH9sMoXhy45mW9CYCz6aGXUb0EtIn7DULrHn4s4=", "elpulsohub");
            //var toast = @"<toast><visual><binding template=""ToastText01""><text id=""1"">" + mensaje + "</text></binding></visual></toast>";
            //await hub.SendWindowsNativeNotificationAsync(toast);

            NotificationHubClient hub = NotificationHubClient
                .CreateClientFromConnectionString("Endpoint=sb://mtenmexicohub-ns.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=YWNWJooYPX4Jb7oJArq8KYYtMTo+pEagxy6FR9O0Vvc=", "mtenmexicohub");
            //Windows
            var toastWindows = @"<toast><visual><binding template=""ToastText01""><text id=""1"">" + mensaje + "</text></binding></visual></toast>";
            await hub.SendWindowsNativeNotificationAsync(toastWindows);

            //Android
            var toastAndroid = "{ \"data\" : {\"message\":\"" + mensaje + "\", \"section\":\"ninguna\",}}";
            await hub.SendGcmNativeNotificationAsync(toastAndroid);

            //iOS
            var toastiOS = "{\"aps\":{\"alert\":\"" + mensaje + "\"}, \"section\":\"ninguna\"}";
            await hub.SendAppleNativeNotificationAsync(toastiOS);
        }
    }
}