using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _146_WPF_ListBox_Current_Matches
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>();
            /// this is a basic class with basic properties created here for this class
            matches.Add(new Match() { Team1= "Bayern Munich", Team2 = "Real Madrid", Score1=3, Score2=2, Completion = 85});

            /// this is a basic class with basic properties created here for this class
            matches.Add(new Match() { Team1 = "PSG", Team2 = "Barca", Score1 = 6, Score2 = 1, Completion = 85 });
            lbMatches.ItemsSource = matches;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbMatches.SelectedItem != null)
            {

                MessageBox.Show("Selected Match: " 
                    + (lbMatches.SelectedItem as Match).Team1 + "" 
                    + (lbMatches.SelectedItem as Match).Score1 + "" 
                    + (lbMatches.SelectedItem as Match).Score2 + "" 
                    + (lbMatches.SelectedItem as Match).Team2 + "");
            }
        }
    }
}
