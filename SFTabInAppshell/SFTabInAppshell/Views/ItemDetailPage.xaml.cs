﻿using SFTabInAppshell.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SFTabInAppshell.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}