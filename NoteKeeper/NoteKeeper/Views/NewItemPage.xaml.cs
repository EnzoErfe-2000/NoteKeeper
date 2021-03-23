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
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }
        public IList<String> CourseList { get; set; }
        public NewItemPage()
        {
            InitializeComponent();
            InitializeData();
            BindingContext = new NewItemViewModel();
            NoteCourse.BindingContext = this;
        }
        async void InitializeData()
        {
            var pluralsightDataStore = new MockPluralsightDataStore();
            CourseList = await pluralsightDataStore.GetCoursesAsync();
        }
    }
}