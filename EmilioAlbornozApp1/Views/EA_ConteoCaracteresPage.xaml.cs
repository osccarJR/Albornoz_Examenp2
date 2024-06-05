using System;
using System.Linq;
using Microsoft.Maui.Controls;

namespace EmilioAlbornozApp1.Views
{
    public partial class EA_ConteoCaracteresPage : ContentPage
    {
        public EA_ConteoCaracteresPage()
        {
            InitializeComponent();
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            var text = inputText.Text ?? string.Empty;
            var letters = text.Count(char.IsLetter);
            var numbers = text.Count(char.IsDigit);
            var uppercase = text.Count(char.IsUpper);
            var lowercase = text.Count(char.IsLower);
            var vowels = text.Count(c => "AEIOUaeiou".Contains(c));
            var total = text.Length;

            labelLetters.Text = $"Letras: {letters}";
            labelNumbers.Text = $"Números: {numbers}";
            labelUppercase.Text = $"Mayúsculas: {uppercase}";
            labelLowercase.Text = $"Minúsculas: {lowercase}";
            labelVowels.Text = $"Vocales: {vowels}";
            labelTotal.Text = $"Total: {total}";
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            inputText.Text = string.Empty;
            labelLetters.Text = "Letras: 0";
            labelNumbers.Text = "Números: 0";
            labelUppercase.Text = "Mayúsculas: 0";
            labelLowercase.Text = "Minúsculas: 0";
            labelVowels.Text = "Vocales: 0";
            labelTotal.Text = "Total: 0";
        }
    }
}
