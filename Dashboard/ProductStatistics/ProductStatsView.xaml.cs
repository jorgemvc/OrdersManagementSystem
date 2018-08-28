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
using Microsoft.Practices.Unity;

namespace Dashboard.ProductStatistics
{
    /// <summary>
    /// Interaction logic for ProductsStat.xaml
    /// </summary>
    public partial class ProductStatsView : UserControl
    {
        public ProductStatsView(IUnityContainer unityContainer)
        {
            InitializeComponent();
            this.DataContext = unityContainer.Resolve<ProductsStatViewModel>();
        }
    }
}
