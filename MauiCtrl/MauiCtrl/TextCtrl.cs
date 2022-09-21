
using System.Text.RegularExpressions;

namespace MauiCtrl
{
    public class TextCtrl
    {
        //**********************************************************************************
        /// <summary>
        /// テキストから数字を抽出
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public int extractNum(string val)
        {
            return int.Parse(Regex.Replace(val, @"[^0-9]", ""));
        }
    }
}
