using AppMaui.Models;
using AppMaui.ViewsModels;

namespace AppMaui.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDo : ContentPage
    {
        public ToDo()
        {
            InitializeComponent();
            BindingContext = new ToDoViewModel();
        }

        private void SearchButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var searchEntryText = entryName.Text;
                (BindingContext as ToDoViewModel)?.Search(searchEntryText);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AddItem(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entryName.Text))
                (BindingContext as ToDoViewModel)?.AddNewTask(entryName.Text);
            
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            try
            {
                SwipeItem swipeItem = sender as SwipeItem;
                if (swipeItem != null)
                {
                    TaskItem taskToDelete = swipeItem.BindingContext as TaskItem;
                    if (taskToDelete != null)
                    {
                        (BindingContext as ToDoViewModel)?.DeleteTask(taskToDelete);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
