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

namespace AlphaParWindows
{
    /// <summary>
    /// Logique d'interaction pour Employees.xaml
    /// </summary>
    public partial class Employees : Page
    {
        public Employees()
        {
            InitializeComponent();
        }
        private void Searchbar_KeyUp(object sender, KeyEventArgs e)
        {
            //var filtered = _clients.Where(client => client.Name.StartsWith(searchbar.Text));

            //datagrid.ItemsSource = filtered;
        }
    }
}
