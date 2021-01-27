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

namespace _140_Routed_Events_DirectBubblingTunneling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Was Clicked - Direct Event");
        }

        private void MouseUp(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Mouse went up / was released - Bubbling Event");
        }

        private void PreviewMouseUp(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Mouse went up / was released - Tunneling Event");
        }
    }
}
