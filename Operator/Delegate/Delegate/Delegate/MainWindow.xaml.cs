﻿using System;
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

namespace Delegate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //This is the robust way to show words in textbox after click the button.
        /*
        public MainWindow()
        {
            InitializeComponent();

            this.myButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            this.myTextBox.Text = "hello world!";
        }
        */

        //This is using the operator "deligate".
        /*
        public MainWindow()
        {
            InitializeComponent();

            this.myButton.Click += delegate(object sender, RoutedEventArgs e)
            {
                this.myTextBox.Text = "hello world!";
            };
        }
        */

        //This is a more advance way by using Lambda expression.

        public MainWindow()
        {
            InitializeComponent();

            this.myButton.Click += (sender, e)=>
            {
                this.myTextBox.Text = "hello world!";
            };
        }


    }
}
