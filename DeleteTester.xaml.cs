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

namespace PLForms
{
    /// <summary>
    /// Interaction logic for DeleteBranch.xaml
    /// </summary>
    public partial class DeleteBranch : Window
    {
        BE.Branch branch;
        BL.IBL bl;
        public DeleteBranch()
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            branch = new BE.Branch();
            branchNameComboBox.ItemsSource = from item in bl.getAllBranch()
                                             select item.branchName;
            this.DataContext = branch;
        }
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BE.Branch br = new BE.Branch();
                br = bl.getAllBranch().FirstOrDefault(b => b.branchName == branch.branchName);
                if (br == null)
                    throw new Exception("the branch dosn't exist");
                else bl.deleteBranch(br.branchNumber);
                MessageBox.Show("the branch \"" + branch.branchName + "\" Deleted from the system", "Deleted successfully!");
                this.DataContext = branch;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}