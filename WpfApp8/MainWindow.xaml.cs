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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtbx.Text.Length > 0)
            {
                var txt = new TextBlock();
                txt.Text = txtbx.Text;
                txt.FontSize = 20;
                DateTime dt = DateTime.Now;
                Label lbl = new Label();
                lbl.Content = dt.ToString("HH:mm");
                lbl.FontSize = 20;
                Grid grid = new Grid();

                grid.Children.Add(txt);
                grid.Children.Add(lbl);
                ColumnDefinition colDef1 = new ColumnDefinition();
                ColumnDefinition colDef2 = new ColumnDefinition();
                grid.ColumnDefinitions.Add(colDef1);
                grid.ColumnDefinitions.Add(colDef2);
                txt.HorizontalAlignment = HorizontalAlignment.Right;

                grid.Width = lstbx.ActualWidth-10;

                Grid.SetColumn(lbl, 0);
                Grid.SetColumn(txt, 1);
                grid.HorizontalAlignment = HorizontalAlignment.Center;

                lbl.Content = dt.ToString("HH:mm");
                lstbx.Items.Add(grid);
                txtbx.Text = "";
            }
        }
    }
}
