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

namespace Dashboard.EmployeeStatistics
{
    /// <summary>
    /// Interaction logic for EmployeesStat.xaml
    /// </summary>
    public partial class EmployeeStatsView : UserControl
    {
        public EmployeeStatsView(IUnityContainer unityContainer)
        {
            InitializeComponent();
            this.DataContext = unityContainer.Resolve<EmployeeStatsViewModel>();

        }
    }
}
