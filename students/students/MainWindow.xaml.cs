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
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace students
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //rankingEntities dataEntities = new rankingEntities();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            WindowHome home = new WindowHome();
            home.Show();
            this.Close();
        }
          private void Window_Loaded(object sender, RoutedEventArgs e)
          {
            /* var users = dataEntities.Users;

             var query =
             from Users in users
             where Users.ID_Roles == 1
             orderby Users.Last_name
             select new { Users.First_name, Users.Last_name, Users.Login};

             dataGrid1.ItemsSource = query.ToList();*/
        }
    }
    }
