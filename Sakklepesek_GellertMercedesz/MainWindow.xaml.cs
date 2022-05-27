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

namespace Sakklepesek_GellertMercedesz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] mezok;

        public MainWindow()
        {
            InitializeComponent();
            TenylegesTabla();
        }

        private void TenylegesTabla()
        {
            mezok = new Button[8, 8];
            for (int i = 0; i < 10; i++)
            {
                tabla.RowDefinitions.Add(new RowDefinition());
                tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }
            char c = 'A';
            for (int i = 1; i < 9; i++)
            {
                Label cimke = new Label();
                cimke.Content = c;
                cimke.HorizontalAlignment = HorizontalAlignment.Center;
                cimke.VerticalAlignment = VerticalAlignment.Bottom;
                tabla.Children.Add(cimke);
                Grid.SetRow(cimke, 0);
                Grid.SetColumn(cimke, i);

                cimke = new Label();
                cimke.Content = c++;
                cimke.HorizontalAlignment = HorizontalAlignment.Center;
                tabla.Children.Add(cimke);
                Grid.SetRow(cimke, 9);
                Grid.SetColumn(cimke, i);

                cimke = new Label();
                cimke.Content = 9 - i;
                cimke.HorizontalAlignment = HorizontalAlignment.Right;
                cimke.VerticalAlignment = VerticalAlignment.Center;
                tabla.Children.Add(cimke);
                Grid.SetRow(cimke, i);
                Grid.SetColumn(cimke, 0);
                cimke = new Label();
                cimke.Content = 9 - i;
                cimke.HorizontalAlignment = HorizontalAlignment.Left;
                cimke.VerticalAlignment = VerticalAlignment.Center;
                tabla.Children.Add(cimke);
                Grid.SetRow(cimke, i);
                Grid.SetColumn(cimke, 9);
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    mezok[i, j] = new Button(); 
                    tabla.Children.Add(mezok[i, j]);
                    mezok[i, j].MouseUp += Kattintas;
                    Grid.SetRow(mezok[i, j], i + 1);
                    Grid.SetColumn(mezok[i, j], j + 1);
                }
            }
        }

        private void Kattintas(object sender, MouseButtonEventArgs e)
        {
            Button babu = sender as Button;
            babu.Content = menu.SelectedItem;
         
        }
    }
}
