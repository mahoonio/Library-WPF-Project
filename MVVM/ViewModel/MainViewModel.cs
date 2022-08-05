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
        public RelayCommand WalletCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public LIbraryBViewModel HomeVm { get; set; }
        public MyBooksViewModel MybooksVm { get; set; }
        public WalletViewModel WalletVm { get; set; }
        public EditViewModel EditVm { get; set; }
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
            WalletVm = new WalletViewModel();
            EditVm = new EditViewModel();
            CurrentView = HomeVm;
            LibraryBCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });
            MyBooksCommand = new RelayCommand(o =>
            {
                CurrentView = MybooksVm;
            });
            WalletCommand = new RelayCommand(o =>
            {
                CurrentView = WalletVm;
            });
            EditCommand = new RelayCommand(o =>
            {
                CurrentView = EditVm;
            });
        }
    }
}
