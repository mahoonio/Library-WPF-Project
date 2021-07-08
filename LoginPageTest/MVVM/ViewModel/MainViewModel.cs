using LoginPageTest.Core;
using LoginPageTest.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPageTest.MVVM.ViewModel
{
    class MainViewModel : ObserveableObject
    {
        public RelayCommand LibraryBCommand { get; set; }
        public RelayCommand MyBooksCommand { get; set; }
        public LIbraryBViewModel HomeVm { get; set; }
        public MyBooksViewModel MybooksVm { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new LIbraryBViewModel();
            MybooksVm= new MyBooksViewModel();
            CurrentView = HomeVm;
            LibraryBCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });
            MyBooksCommand = new RelayCommand(o =>
            {
                CurrentView = MybooksVm;
            });
        }
    }
}
