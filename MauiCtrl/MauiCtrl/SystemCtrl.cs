namespace MauiCtrl
{
    //参考：https://docs.microsoft.com/ja-jp/dotnet/maui/platform-integration/device/information?tabs=windows
    public class SystemCtrl
    {

        //**********************************************************************************
        //デバイス情報プロパティの読み取り
        public void ReadDeviceInfo()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine($"Model: {DeviceInfo.Current.Model}");
            sb.AppendLine($"Manufacturer: {DeviceInfo.Current.Manufacturer}");
            sb.AppendLine($"Name: {DeviceInfo.Name}");
            sb.AppendLine($"OS Version: {DeviceInfo.VersionString}");
            sb.AppendLine($"Refresh Rate: {DeviceInfo.Current}");
            sb.AppendLine($"Idiom: {DeviceInfo.Current.Idiom}");
            sb.AppendLine($"Platform: {DeviceInfo.Current.Platform}");

            bool isVirtual = DeviceInfo.Current.DeviceType switch
            {
                DeviceType.Physical => false,
                DeviceType.Virtual => true,
                _ => false
            };

            sb.AppendLine($"Virtual device? {isVirtual}");
        }

        //**********************************************************************************
        //プロパティがオペレーティング システムと一致するかどうかを確認
        public bool IsAndroid() =>
            DeviceInfo.Current.Platform == DevicePlatform.Android;

        //**********************************************************************************
        //デバイスの種類を取得
        public DeviceIdiom PrintIdiom()
        {
            if (DeviceInfo.Current.Idiom == DeviceIdiom.Desktop)        //DeviceIdiom.Phone
                Console.WriteLine("The current device is a desktop");   //DeviceIdiom.Tablet
            else if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)     //DeviceIdiom.Desktop
                Console.WriteLine("The current device is a phone");     //DeviceIdiom.TV
            else if (DeviceInfo.Current.Idiom == DeviceIdiom.Tablet)    //DeviceIdiom.Watch
                Console.WriteLine("The current device is a Tablet");    //DeviceIdiom.Unknown

            return DeviceInfo.Current.Idiom;

            
            
            
            
            
            
        }
    }
}
