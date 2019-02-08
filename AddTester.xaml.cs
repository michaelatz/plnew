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
using BE;
using BL;

namespace PLForms
{
    /// <summary>
    /// Interaction logic for AddBranch.xaml
    /// </summary>
    public partial class AddBranch : Window
    {
        BE.Branch branch;
        BL.IBL bl;
        public AddBranch()
        {
            InitializeComponent();
            branch = new BE.Branch();
            this.gridAddBranch.DataContext = branch;
            bl = BL.FactoryBL.getBL();
            this.hechsherComboBox.ItemsSource = Enum.GetValues(typeof(BE.kosherLevel));
        }

        private void addBranchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addBranch(branch);
                MessageBox.Show("the branch \"" + branch.branchName + "\" added to the list", "");
                branch = new BE.Branch();
                this.gridAddBranch.DataContext = branch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}