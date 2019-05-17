using GameOfThrones.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameOfThrones
{
    public partial class MainWindow : Window
    {
        Actor actors;
        ObservableCollection<CharacterFilter> lstActors = new ObservableCollection<CharacterFilter>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            string url = "https://api.got.show/api/general/characters";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            actors = JsonConvert.DeserializeObject<Actor>(response);

            foreach (var actor in actors.Show)
            {
                lstActors.Add(new CharacterFilter() {Name=actor.Name});
            }
            actorsListBox.ItemsSource = lstActors;
        }

        private void SearchTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            string txtOrig = searchTextBox.Text;
            string upper = txtOrig.ToUpper();
            string lower = txtOrig.ToLower();

            var actorFiltered = from actor in lstActors
                                let aName = actor.Name
                                where aName.StartsWith(lower) || aName.StartsWith(upper) || aName.Contains(txtOrig)
                                select actor;
            actorsListBox.ItemsSource = actorFiltered;
        }

        CharacterFilter character;
        private void ActorsListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                character = (CharacterFilter)actorsListBox.SelectedItem;
                CharacterDescriptionWindow characterDescriptionWindow = new CharacterDescriptionWindow(character.Name, actors);
                characterDescriptionWindow.Show();
            }
        }
        private void ActorsListBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            character = (CharacterFilter)actorsListBox.SelectedItem;
            CharacterDescriptionWindow characterDescriptionWindow = new CharacterDescriptionWindow(character.Name, actors);
            characterDescriptionWindow.Show();
        }
    }
}
