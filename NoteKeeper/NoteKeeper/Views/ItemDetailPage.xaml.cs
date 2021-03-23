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
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();
            BindingContext = Note;
            NoteCourse.BindingContext = this;
        }
        public ItemDetailPage()
        {
            InitializeComponent();
            //this.NoteHeading=
            InitializeData();
            //BindingContext = new ItemDetailViewModel();
            BindingContext = Note;
            NoteCourse.BindingContext = this;
        }
        async void InitializeData()
        {
            var pluralsightDataStore = new MockPluralsightDataStore();
            CourseList = await pluralsightDataStore.GetCoursesAsync();
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