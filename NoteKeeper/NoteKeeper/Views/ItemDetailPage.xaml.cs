using NoteKeeper.Models;
using NoteKeeper.Services;
using NoteKeeper.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
        }
        public ItemDetailPage()
        {
            InitializeComponent();
            //this.NoteHeading=
            //BindingContext = new ItemDetailViewModel();
            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }
        
        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PopModalAsync();
            /*viewModel.NoteHeading = "XXXXXXXXXXXX";
            DisplayAlert("Cancel option", 
                "Heading value is " + viewModel.Note.Heading, 
                "Button 2", "Button 1");
            */
        }

        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PopModalAsync();
            /*
            DisplayAlert("Save option", "Save was clicked", "Button 2", "Button 1");
            */
        }
    }
}