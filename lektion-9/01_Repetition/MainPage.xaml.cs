using _01_Repetition.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _01_Repetition
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static List<ContactPerson> contacts = new List<ContactPerson>();

        public MainPage()
        {
            this.InitializeComponent();

            if (contacts.Count > 0)
                lvContacts.ItemsSource = contacts;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(tbFirstName.Text) && !string.IsNullOrEmpty(tbLastName.Text) && !string.IsNullOrEmpty(tbEmail.Text))
            {
                contacts.Add(new ContactPerson
                {
                    Id = Guid.NewGuid(),
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Email = tbEmail.Text,
                    AddressLine = tbAddressLine.Text ?? "",
                    ZipCode = tbZipCode.Text ?? "",
                    City = tbCity.Text ?? ""
                });

                lvContacts.ItemsSource = contacts;
            }
        }
    }
}
