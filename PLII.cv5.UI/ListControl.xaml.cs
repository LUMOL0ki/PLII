using System;
using System.Collections;
using System.Collections.Generic;
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

namespace PLII.cv5.UI
{
    /// <summary>
    /// Interaction logic for ListControl.xaml
    /// </summary>
    public partial class ListControl : UserControl
    {
        public ListControl()
        {
            InitializeComponent();
            
        }

        public IEnumerable ItemSource
        {
            get
            {
                return NumberListBox.ItemsSource;
            }
            set
            {
                NumberListBox.ItemsSource = value;
            }
        }

        public int Number
        {
            get
            {
                if(int.TryParse(NumberTextBox.Text, out int result))
                {
                    NumberTextBox.Text = "";
                    return result;
                }
                else
                {
                    throw new Exception("Invalid input");
                }
            }
        }

        public event RoutedEventHandler AddClick;
        public event RoutedEventHandler RemoveClick;

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddClick?.Invoke(sender, e);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveClick?.Invoke(sender, e);
        }
    }
}
