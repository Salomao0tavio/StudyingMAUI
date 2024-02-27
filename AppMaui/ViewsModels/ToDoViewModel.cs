using AppMaui.Models;
using AppMaui.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;

namespace AppMaui.Views
{
    public partial class ToDoViewModel : BaseViewModel
    {
        private ObservableCollection<TaskItem> _taskList;


        public ObservableCollection<TaskItem> TaskList
        {
            get => _taskList;
            set => SetProperty(ref _taskList, value);
        }

        public ToDoViewModel()
        {
            // Inicializa a lista de tarefas com alguns itens de exemplo
            TaskList = new ObservableCollection<TaskItem>
            {
                new TaskItem { TaskName = "Study Math" },
                new TaskItem { TaskName = "Work in the new project" },
                new TaskItem { TaskName = "Practice exercises" },
                new TaskItem { TaskName = "Meeting at work" },
            };
        }
    }
}
