using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace MiniBioApp
{
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string message = MessageTextBox.Text;

            string data = $"Name: {name}\nEmail: {email}\nMessage: {message}\n\n";

            string filePath = "ContactFormData.txt";

            try
            {
                File.AppendAllText(filePath, data);
                MessageBox.Show("Your message has been submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                NameTextBox.Clear();
                EmailTextBox.Clear();
                MessageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
