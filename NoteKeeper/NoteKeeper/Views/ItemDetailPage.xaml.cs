using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoteKeeper.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public Note Note { get; set; }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();
            BindingContext = Note;
        }
        public ItemDetailPage()
        {
            InitializeComponent();
            //this.NoteHeading=
            InitializeData();
            //BindingContext = new ItemDetailViewModel();
            BindingContext = Note;
        }
        void InitializeData()
        {
            Note = new Note { Heading="Test Note", Text="Text for test note"};
        }
        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Cancel option", "Cancel was selected", "Button 2", "Button 1");
        }

        public void Save_Clicked(object sender, EventArgs eventArgs)
        {
            DisplayAlert("Save option", "Save was clicked", "Button 2", "Button 1");
        }
    }
}