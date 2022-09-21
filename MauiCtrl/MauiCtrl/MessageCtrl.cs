
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Threading;

namespace MauiCtrl
{
    public class MessageCtrl
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public async void MessageAlert(string str_title, string str_message, string str_btn)
        {
        }

        //public async void MessageToast()
        //{
        //    using CommunityToolkit.Maui.Alerts;

        //    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        //    string text = "This is a Toast";
        //    ToastDuration duration = ToastDuration.Short;
        //    double fontSize = 14;

        //    var toast = Toast.Make(text, duration, fontSize);

        //    await toast.Show(cancellationTokenSource.Token);
        //}
    }
}
