using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginPageTest.Core
{
    class RelayCommand : ICommand
    {
        private Action<object> Execute;
        private Func<object, bool> CanExecute;
    }
}
