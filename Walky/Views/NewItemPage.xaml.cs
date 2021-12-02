using System;
using System.Collections.Generic;
using System.ComponentModel;
using Walky.Models;
using Walky.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Walky.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}