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
using System.Windows.Threading;
using SollyTracker;

namespace SollyTracker
{
    /// <summary>
    /// Interaction logic for Timer.xaml
    /// </summary>
    public partial class Timer : Page
    {
        DispatcherTimer timer;
        User user;
        UserControl1 userControl1;
        string filterCheckedItem = string.Empty;


        public Timer()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            user = new User("Admin", "Admin@123");
        }

        private void AddControl()
        {
            userControl1 = new UserControl1( user);
            MainGrid.RowDefinitions.Add(new RowDefinition()
            {
                Height = GridLength.Auto,
            });
            MainGrid.Children.Add(userControl1);
            Grid.SetRow(userControl1, MainGrid.RowDefinitions.Count - 1);
        }
        /* private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
         {
             PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
             e.Column.Header = propertyDescriptor.DisplayName;
             if (propertyDescriptor.DisplayName == "date")
             {
                 e.Cancel = true;
             }
         }*/
        /*private List<Task> LoadCollectionData()
        {
            List<Task> parameters = new List<Task>();
            parameters.Add(new Task(new DateOnly(2022, 1, 1), new TimeOnly(10, 1), "FirstNote", "Solin", "ListOfTask", "TaskName", SollyTracker.BillStatus.Billable, new TimeOnly(11, 0), new TimeOnly(12, 0), SollyTracker.States.Start));
            parameters.Add(new Task(new DateOnly(2022, 1, 1), new TimeOnly(10, 1), "FirstNote", "Solin", "ListOfTask", "TaskName", SollyTracker.BillStatus.Billable, new TimeOnly(11, 0), new TimeOnly(12, 0), SollyTracker.States.Start));

            return parameters;
        }*/

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
           // FilterPopup.IsOpen = true;
            /*if (CheckBox1.IsChecked == true)
            {
                filterCheckedItem = CheckBox1.Content.ToString();
            }
            else
            {
                filterCheckedItem = CheckBox2.Content.ToString();
            }*/
            // MessageBox.Show("You Clicked filter");
        }


        private void mouse_DownHandled(object sender, MouseEventArgs e)
        {
           /* FilterPopup.IsOpen = false;
            bool option1 = CheckBox1.IsChecked == true;
            bool option2 = CheckBox2.IsChecked == true;
            Filter_Value(option1, option2);*/
        }

        private void Filter_Value(bool option1, bool option2)
        {
            if (option1)
            {
                filterCheckedItem = "Billable";
            }
            else
            {
                filterCheckedItem = "Non_Billable";
            }
        }

        private void Add_New_Click(object sender, RoutedEventArgs e)
        {
            AddControl();
        }

    }
}

