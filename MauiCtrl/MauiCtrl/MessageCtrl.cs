
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Threading;


namespace MauiCtrl
{
    public class MessageCtrl
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public async Task MessageAlert(Page pg, string str_title, string str_message, string str_btn)
        {
            await pg.DisplayAlert(str_title, str_message, str_btn);
        }

        //仕様例) var answer_ = await MC.MessageAlert_yn(this, "test", "test", "yes", "no");
        public Task<bool> MessageAlert_yn(Page pg, string str_title, string str_message, string str_btn_yes, string str_btn_no)
        {
            var answer = pg.DisplayAlert(str_title, str_message, str_btn_yes, str_btn_no);
            return answer;
        }

        public Task<string> MessageAlert_select(Page pg, string title, string cancel, string destruction, params string[] buttons)
        {
            var ans = pg.DisplayActionSheet(title, cancel, destruction, buttons);
            return ans;
        }
    }
}
