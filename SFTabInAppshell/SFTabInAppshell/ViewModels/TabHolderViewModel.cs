using System;
using System.Collections.Generic;
using System.Text;

namespace SFTabInAppshell.ViewModels
{
    public class TabHolderViewModel : BaseViewModel
    {
        public ItemsViewModel Items1 { get; }
        public ItemsViewModel Items2 { get; }
        public TabHolderViewModel()
        {
            Items1 = new ItemsViewModel();
            Items2 = new ItemsViewModel();
        }
        public void OnAppearing()
        {
            Items1.OnAppearing();
            Items2.OnAppearing();
        }
    }
}
