using System.Collections.ObjectModel;
using System.Windows;
using Core;

namespace WpfUI
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<BaseTask> TasksList { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            TasksList = new ObservableCollection<BaseTask>
{
    new SimpleTask { Id = 1, Title = "UI Design", Hours = 5 },
    new EpicTask { Id = 2, Title = "Database Integration", ComplexityLevel = 3 }
};

            MainDataGrid.ItemsSource = TasksList;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddDialog dialog = new AddDialog();
            if (dialog.ShowDialog() == true)
            {
                TasksList.Add(dialog.NewTask); 
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Düzenleme paneli daha sonra eklenecek!");
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MainDataGrid.SelectedItem is BaseTask selectedTask)
            {
                TasksList.Remove(selectedTask);
            }
            else
            {
                MessageBox.Show("Please select a task from the table to delete.");
            }
        }
    }
}