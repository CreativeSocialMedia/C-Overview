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

namespace _142_WPF_DEpendancy_Properties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // how to build your own dependacny property line 23-30
        public int MyProperty
        {
            get { return (int)GetValue(myDependancyProperty); }
            set { SetValue(myDependancyProperty, value); }
        }

        public static readonly DependencyProperty myDependancyProperty = DependencyProperty.Register("MyProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();

            
        }
    }
}
