using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;

namespace SecureStorageDemo.Util
{
    public abstract class NotifyClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public void NotifyPropertyChanged([CallerMemberName] string _propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_propName));
        }
    }
}
