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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            int rowvalue;
            int colvalue;

            if (int.TryParse(rowTxt.Text, out rowvalue) && int.TryParse(columnTxt.Text, out colvalue))
            {
                if (rowvalue >= 0 && rowvalue < 4 && colvalue >= 0 && colvalue < 4)
                {
                    Button btn = new Button();
                    
                        btn.Content = $"Row {rowvalue}, Column {colvalue}";
                        btn.Background = new SolidColorBrush(Colors.LightGreen);

                        Grid.SetRow(btn, rowvalue);
                        Grid.SetColumn(btn, colvalue);

                        netGrid.Children.Add(btn);
                    
                    
                }
                else
                {
                    MessageBox.Show("Rad och Kolumn nummer måste vara mellan 0 och 3. Vänligen välj ett annat nummer.");

                }
            }
            else 
            {
                MessageBox.Show("Värdena du matar in måste vara heltal mellan 0 och 3");
            }
        }
    }
}
