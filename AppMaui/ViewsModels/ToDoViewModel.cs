using AppMaui.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace AppMaui.ViewsModels
{
    public class ToDoViewModel : BaseViewModel
    {
        private ObservableCollection<TaskItem> _originalTaskList;

        private ObservableCollection<TaskItem> _taskList = new ObservableCollection<TaskItem>
        {
            new TaskItem { TaskName = "Study Math" },
            new TaskItem { TaskName = "Work in the new project" },
            new TaskItem { TaskName = "Practice exercises" },
            new TaskItem { TaskName = "Meet at work" },
        };

        public ObservableCollection<TaskItem> TaskList
        {
            get => _taskList;
            set => SetProperty(ref _taskList, value);
        }

        public ToDoViewModel()
        {
            _originalTaskList = new ObservableCollection<TaskItem>(TaskList);
            foreach (TaskItem item in _originalTaskList)
            {
                TaskList.Add(item);
            }
        }


        public void Search(string searchText)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    var filteredList = _originalTaskList
                        .Where(item => item.TaskName.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    TaskList.Clear();

                    foreach (var task in filteredList)
                    {
                        TaskList.Add(task);
                    }
                }
                else
                {
                    // If search text is empty or whitespace, restore the original TaskList
                    TaskList.Clear();
                    foreach (var task in _originalTaskList)
                    {
                        TaskList.Add(task);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddNewTask(string name)
        {
            try
            {
                _originalTaskList.Add(new TaskItem { TaskName = name });
                foreach (var task in _originalTaskList)
                {
                    TaskList.Add(task);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteTask(TaskItem taskToDelete)
        {
            try
            {
                _originalTaskList.Remove(taskToDelete);
                TaskList.Remove(taskToDelete);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
