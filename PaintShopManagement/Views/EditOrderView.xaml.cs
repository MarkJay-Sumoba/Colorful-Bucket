﻿using PaintShopManagement.Models;
using PaintShopManagement.ViewModels;
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

namespace PaintShopManagement.Views
{
    /// <summary>
    /// Interaction logic for EditOrderView.xaml
    /// </summary>
    public partial class EditOrderView : Window
    {
        public EditOrderView(Orders order, OrderViewModel parentViewModel)
        {
            InitializeComponent();

            var currentWindow = this;

            var viewModel = new EditOrderViewModel(order, parentViewModel, currentWindow);

            DataContext = viewModel;
        }
    }
}
