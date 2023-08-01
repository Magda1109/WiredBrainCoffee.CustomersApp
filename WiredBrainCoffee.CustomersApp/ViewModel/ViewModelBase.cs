﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WiredBrainCoffee.CustomersApp.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //oznacza, że jeśli event PropertyChanged nie jest nullem, to go wywołujemy. This oznacza, że wywołujemy go dla tego view modelu, a 
        }

        public virtual Task LoadAsync() => Task.CompletedTask;
    }
}
