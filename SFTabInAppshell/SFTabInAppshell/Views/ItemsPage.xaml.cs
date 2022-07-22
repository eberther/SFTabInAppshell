using SFTabInAppshell.Models;
using SFTabInAppshell.ViewModels;
using SFTabInAppshell.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFTabInAppshell.Views
{
    public partial class ItemsPage : ContentPage
    {
        TabHolderViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new TabHolderViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}