using EmilioAlbornozApp1.Models;
using Microsoft.Maui.Controls;

namespace EmilioAlbornozApp1.Views
{
    public partial class EA_AllNotesPage : ContentPage
    {
        public EA_AllNotesPage()
        {
            InitializeComponent();
            BindingContext = new EA_AllNotes();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is EA_AllNotes notes)
            {
                notes.LoadNotes();
            }
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(EA_NotePage));
        }

        private void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 
        }
    }
}
