using AppMaui.Components;
using AppMaui.Models;
using Microsoft.Maui.Controls.Xaml;

namespace AppMaui.Views;

public partial class ToDo : ContentPage
{
    public ToDo()
    {
        InitializeComponent();
        BindingContext = new ToDoViewModel();
    }

    //private void SearchButtonClicked(object sender, EventArgs e)
    //{
    //    var search = searchEntry.Text;
    //    List<TaskItem> taskList = BindingContext.LoadFromXaml();
    //    foreach (var item in taskList)
    //    {
    //        if (item.TaskName.Contains(search))
    //        {
    //            taskList.FindAll(x => x.TaskName.ToUpper.Contains(search.ToUpper));
    //        }
    //    }
    //}

    public void DisplayPopup()
    {
        //chamar a classe PopUp() que tem o que eu quero e exibir
        PopUp popUp = new PopUp();
        popUp.
    }



    private void AddButtonClicked(object sender, EventArgs e)
    {
        var taskList = (BindingContext as ToDoViewModel).TaskList;
        taskList.Add(new TaskItem { TaskName = "New Task" });
    }

}
