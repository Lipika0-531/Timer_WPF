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

namespace SollyTracker
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        DispatcherTimer timer;
        private DateTime startTime;
        private TimeSpan stopTime;
        private TimeSpan elapsedTime;
        private bool isStopRequested = false;

        User user;

        public UserControl1(User user)
        {
            InitializeComponent();
            DataContext = this;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            this.user = user;
        }

        /// <summary>
        /// Starts the timer and stops the timer.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">RoutedEventArgs</param>
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (!isStopRequested)
            {
                if (elapsedTime.TotalSeconds > 0)
                {
                    startTime = DateTime.Now - elapsedTime;
                }
                else
                {
                    startTime = DateTime.Now;

                }
                timer.Tick += Timer_Tick;
                timer.Start();
                StartBtn.Content = new Image
                {
                    Source = new BitmapImage(new Uri(@"D:\CSharp\TIMER_APPLICATION\TIMER_APPLICATION\Images\Pause.jpg", UriKind.RelativeOrAbsolute)),
                    Width = 20,
                    Height = 20,
                };
                isStopRequested = true;
            }
            else
            {
                timer.Stop();
                elapsedTime = DateTime.Now - startTime;
                StartBtn.Content = new Image
                {
                    Source = new BitmapImage(new Uri(@"D:\CSharp\TIMER_APPLICATION\TIMER_APPLICATION\Images\Start.jpg", UriKind.RelativeOrAbsolute)),
                    Width = 20,
                    Height = 20,
                };
                isStopRequested = false;
                stopTime = elapsedTime;
            }
        }

        /// <summary>
        /// Timer to display.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">EventArgs</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            Timer.Content = elapsed.ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// Update the specific entry.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">RoutedEventArgs</param>
        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            Window MainWindow = Window.GetWindow(this);
            MainWindow.Content = new UpdateMenu(user);

        }

        /// <summary>
        /// Delete the timer entry.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">RoutedEventArgs</param>
        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int indexToDelete;
            if (clickedButton != null)
            {
                indexToDelete = (int)clickedButton.GetValue(Grid.RowProperty);

                if (MessageBox.Show("Do you want to delete this entry", "Delete Entry", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    DeleteRow(indexToDelete);
                   // user.Task.RemoveAt(indexToDelete);
                }
            }
        }

        public void DeleteRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex <= UserControlGrid.RowDefinitions.Count)
            {
                for (int i = 0; i < UserControlGrid.ColumnDefinitions.Count; i++)
                {
                    UIElement element = UserControlGrid.Children.Cast<UIElement>()
                        .FirstOrDefault(e => Grid.GetRow(e) == rowIndex && Grid.GetColumn(e) == i);

                    if (element != null)
                    {
                        UserControlGrid.Children.Remove(element);
                    }
                }
            }
        }

    }
}
