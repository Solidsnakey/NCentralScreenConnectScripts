using System;
using System.Web;
using System.Net;
using ScreenConnect;

namespace NCentral
{
    public partial class TellMeMyKey : ScreenConnect.ThemeablePage
    {
        protected override void OnLoad(EventArgs e)
        {
            String serverKey = HttpServerUtility.UrlTokenEncode(ServerCryptoManager.Instance.PublicKey);
            Response.Write(serverKey.Substring(0, 10));
        }
    }
}
