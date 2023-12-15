using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using mvvmDBpractice.Models;
using mvvmDBpractice.Services;
namespace mvvmDBpractice.ViewModels
{
    public class FormViewModel : BaseViewModel
    {
        private string firstName;
        public string FirstName
        {
            get { return this.firstName; }
            set { SetValue(ref this.firstName, value); }
        }

        private string lastName;
        public string LastName
        {
            get { return this.lastName; }
            set { SetValue(ref this.lastName, value); }
        }

        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Form> people;
        public List<Form> People
        {
            get { return this.people; }
            set { SetValue(ref this.people, value); }
        }

        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }


        public FormViewModel()
        {
            SearchCommand = new Command(() =>
            {
                FormService service = new FormService();
                People = service.GetByText(Filter);
            });

            InsertCommand = new Command(() =>
            {
                FormService service = new FormService();
                int newPersonId = service.Get().Count + 1;
                service.Create(new Form { FirstName = FirstName, LastName = LastName });

                App.Current.MainPage.DisplayAlert("Success", "Your data are saved", "Ok");
            });
        }

    }
}
