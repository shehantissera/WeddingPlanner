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
using MahApps.Metro.Controls;
using CommonLib;
using WeddingPlanner.ViewModel;


namespace WeddingPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        WebInvoker Invoker { get; set; }
        LocalSecurity Security { get; set; }
        App_ViewModel ViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            InitializeSystem();
        }

        private void InitializeSystem()
        {
            this.Invoker = new WebInvoker();
            this.Security = new LocalSecurity();
            this.ViewModel = new App_ViewModel(Invoker, Security);
            LayoutRoot.DataContext = ViewModel;
        }
    }
}
