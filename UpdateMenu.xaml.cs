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

namespace SollyTracker
{
    /// <summary>
    /// Interaction logic for UpdateMenu.xaml
    /// </summary>
    public partial class UpdateMenu : Page
    {
        User user;
        public UpdateMenu(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        
        string selectedOptionForProjectName;
        string selectedOptionForStatus;
        BillStatus selectedOptionForStatusInEnum;
        string selectedOptionForTaskName;
        string selectedOptionForTaskList;

        public void AddUpdatedValuesToList()
        {
            foreach(var values in user.Parameters)
            {
                values.ProjectName = selectedOptionForProjectName;
                values.BillStatus = selectedOptionForStatusInEnum;
                values.TaskList = selectedOptionForTaskList;
                values.TaskName = selectedOptionForTaskName;
            }
        }
        private void ProjectName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProjectNameMenu.SelectedItem != null)
            {
                selectedOptionForProjectName = ((ComboBoxItem)ProjectNameMenu.SelectedItem).Content.ToString();
            }
        }

        private void BillStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BillStatusMenu.SelectedItem != null)
            {
                selectedOptionForStatus = ((ComboBoxItem)BillStatusMenu.SelectedItem).Content.ToString();
                if(selectedOptionForStatus == "Billable")
                {
                    selectedOptionForStatusInEnum = BillStatus.Billable;
                }
                else
                {
                    selectedOptionForStatusInEnum = BillStatus.Non_Billable;
                }

            }
        }
        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {

            if (selectedOptionForProjectName != null && selectedOptionForStatus != null && selectedOptionForTaskList != null && selectedOptionForTaskName != null)
            {
                AddUpdatedValuesToList();
                MessageBox.Show("Update success");
            }
            else
            {
                MessageBox.Show("Enter all values !!");
            }
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            Window MainWindow = Window.GetWindow(this);
            MainWindow.Content = new UserControl1(user);
        }

        private void TaskName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TaskNameMenu.SelectedItem != null)
            {
                selectedOptionForTaskName = ((ComboBoxItem)TaskNameMenu.SelectedItem).Content.ToString();
            }
        }

        private void TaskList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TaskListMenu.SelectedItem != null)
            {
                selectedOptionForTaskList = ((ComboBoxItem)TaskListMenu.SelectedItem).Content.ToString();
            }

        }

    }
}
