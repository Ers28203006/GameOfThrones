using GameOfThrones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameOfThrones
{
    /// <summary>
    /// Логика взаимодействия для CharacterDescriptionWindow.xaml
    /// </summary>
    public partial class CharacterDescriptionWindow : Window
    {
        Show show = new Show();
        Book book = new Book();

        public CharacterDescriptionWindow(string character, Actor actors)
        {
            InitializeComponent();

            Title = $"Персонаж: {character}";
            foreach (var actor in actors.Show)
            {
                if (character==actor.Name)
                {
                    show = actor;
                    break;
                }
            }

            foreach (var actor in actors.Book)
            {
                if (character == actor.Name)
                {
                    book = actor;
                    break;
                }
            }
        }

        private void CharacterWindowLoaded(object sender, RoutedEventArgs e)
        {
            characterPhoto.Source = new BitmapImage(new Uri(show.Image));
            characterText.Text = show.Name;
            foreach (var title in show.Titles)
                titlesList.Items.Add(title);
            fatherText.Text = $"Father: {show.Father}";
            motherText.Text = $"Mother: {show.Mother}";
            houseText.Text = show.House;
            actorText.Text = $"Actor: {show.Actor}";
        }
    }
}
