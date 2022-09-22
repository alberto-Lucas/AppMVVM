﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AppMVVM.ViewModels
{
    public abstract class BaseNotifyViewModel : INotifyPropertyChanged
    {
        public event 
            PropertyChangedEventHandler 
            PropertyChanged;

        public void OnPropertyChanged(
              [CallerMemberName]
                string propertyName = "")
        {
            PropertyChanged.Invoke(
                this, new PropertyChangedEventArgs(
                    propertyName));
        }
    }
}
