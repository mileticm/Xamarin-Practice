using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView
{
    public partial class MainPage : ContentPage
    {
        private async void OnItemTapped (object sender, ItemTappedEventArgs args)
        {
            Character character = args.Item as Character;
            await Navigation.PushAsync(new CharacterPage(character));
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
