﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FriendOrganizer.UI.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
