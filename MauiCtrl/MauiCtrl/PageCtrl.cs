using Microsoft.Maui.Controls;
using System;

namespace MauiCtrl
{
    public class PageCtrl
    {
	    //**********************************************************************************
        //NewPage pg = new NewPage();
        public bool openPageNavi(NavigableElement navigable_element, Page pg, bool bl_animation)
        {
            try
            {
                navigable_element.Navigation.PushAsync(pg, bl_animation);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void test(Func<Page, bool, Task> push_async, Page pg, bool bl_animation)
        {
            push_async(pg, bl_animation);
        }
    }
}
