﻿using Scheduler.Command;
using Scheduler.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Xceed.Wpf.Toolkit;

namespace Scheduler.ViewModel
{
    public class ToDoListVM : INotifyPropertyChanged
    {
        private ObservableCollection<ToDo> todo = new ObservableCollection<ToDo>();

        public ObservableCollection<ToDo> ToDoItem {
            get { return todo; } 
            set
            {
                if (todo != value)
                {
                    todo = value;
                    NotifyPropertyChanged(nameof(todo));
                }
            }
        }

        public ICommand CreateToDoCommand { get { return new CreateToDoCommand(); } }

        public DateTime DoneBy { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
