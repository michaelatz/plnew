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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for AddTrainee.xaml
    /// </summary>
    public partial class AddTrainee : Window
    {
        public AddTrainee()
        {
            InitializeComponent();
        }
         = new BE.Trainee();
            this.gridAddDish.DataContext = dish;
            bl = BL.FactoryBL.getBL();

            dishSizeComboBox.ItemsSource = Enum.GetValues(typeof(BE.Size));
            this.hechsherComboBox.ItemsSource = Enum.GetValues(typeof(BE.kosherLevel));

private void freeDeliverNumTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
