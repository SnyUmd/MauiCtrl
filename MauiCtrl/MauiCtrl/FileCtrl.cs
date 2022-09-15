namespace MauiCtrl
{
    // All the code in this file is included in all platforms.
    public class FileCtrl
    {
        public async Task<FileResult> ReadFile(PickOptions options)
        {
            try
            {
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null)
                {
                    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                        result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                    {
                        using var stream = await result.OpenReadAsync();
                        var image = ImageSource.FromStream(() => stream);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                // The user canceled or something went wrong
            }

            return null;
        }
        //■↑使い方例
        //var select_file = await FC.ReadFile(null);
        //if(select_file != null)
        //    await DisplayAlert("Select file", select_file.FullPath, "OK");

        //■↑使用時のカスタム方法
        //var customFileType = new FilePickerFileType(
        //        new Dictionary<DevicePlatform, IEnumerable<string>>
        //        {
        //            { DevicePlatform.iOS, new[] { "public.my.comic.extension" } }, // or general UTType values
        //            { DevicePlatform.Android, new[] { "application/comics" } },
        //            { DevicePlatform.WinUI, new[] { ".cbr", ".cbz" } },
        //            { DevicePlatform.Tizen, new[] { "*/*" } },
        //            { DevicePlatform.macOS, new[] { "cbr", "cbz" } }, // or general UTType values
        //        });

        //PickOptions options = new()
        //{
        //    PickerTitle = "Please select a comic file",
        //    FileTypes = customFileType,
        //};
    }
}