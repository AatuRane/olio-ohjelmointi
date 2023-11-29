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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Harjoitus_21
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = checkBox.Content.ToString();
                stockPanel.Children.Add(textBlock);
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                foreach (var item in stockPanel.Children)
                {
                    if (item is TextBlock && ((TextBlock)item).Text == checkBox.Content.ToString())
                    {
                        stockPanel.Children.Remove((UIElement)item);

                       

                        break;
                    }
                }
            }
        }

        private void OstaButton_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;


            foreach (var item in stockPanel.Children)
            {
                if (item is TextBlock)
                {
                    stockPanel.Children.Remove((UIElement)item);

                    if (checkBox1.IsChecked == true)
                    {

                        checkBox1.IsChecked = false;

                    } else if (checkBox2.IsChecked == true)
                    {
                        checkBox2.IsChecked = false;

                    }

                    if (checkBox3.IsChecked == true)
                    {

                        checkBox3.IsChecked = false;

                    }
                    else if (checkBox4.IsChecked == true)
                    {
                        checkBox4.IsChecked = false;

                    }
                    else if (checkBox5.IsChecked == true)
                    {
                        checkBox5.IsChecked = false;

                    }



                    break;  // Break here to avoid modify
                            // ing the collection while iterating
                }
            }
        }
    }
}