using PLII.cv2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PLII.cv5.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IStack stack;
        private IQueue queue;

        public MainWindow()
        {
            InitializeComponent();

            stack = new MyStack(30);
            queue = new MyQueue(30);

            QueueListControl.AddClick += QueueListControl_AddClick;
            QueueListControl.RemoveClick += QueueListControl_RemoveClick;
            QueueListControl.ItemSource = FillCollection(queue.Elements);

            StackListControl.AddClick += StackListControl_AddClick;
            StackListControl.RemoveClick += StackListControl_RemoveClick;
            StackListControl.ItemSource = FillCollection(stack.Elements);
        }

        private ICollection<string> FillCollection(int?[] elements)
        {
            ICollection<string> collection = new List<string>();
            foreach(int? element in elements)
            {
                if (element.HasValue)
                {
                    collection.Add(element.ToString());
                }
                else
                {
                    collection.Add("Non value");
                }
            }
            return collection;
        }

        private void StackListControl_RemoveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                stack.Pop();
                StackListControl.ItemSource = FillCollection(stack.Elements);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void StackListControl_AddClick(object sender, RoutedEventArgs e)
        {
            try
            {
                stack.Push(StackListControl.Number);
                StackListControl.ItemSource = FillCollection(stack.Elements);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void QueueListControl_RemoveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                queue.Get();
                QueueListControl.ItemSource = FillCollection(queue.Elements);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void QueueListControl_AddClick(object sender, RoutedEventArgs e)
        {
            try
            {
                queue.Add(QueueListControl.Number);
                QueueListControl.ItemSource = FillCollection(queue.Elements);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
