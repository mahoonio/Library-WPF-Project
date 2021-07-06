using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoginPageTest.Core
{
    class ObserveableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string Name = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }
    }
}
