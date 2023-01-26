using FontAwesome.Sharp;
using MGEN.Models;
using MGEN.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MGEN.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //Fields
        private UserAccountModel _currentUserAccount;
        private ViewModelBase _currentChildView;
        private string _caption;
        private IconChar _icon;
        private IUserRepository userRepository;
        //Properties
        public UserAccountModel CurrentUserAccount
        {
            get
            {
                return _currentUserAccount;
            }
            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }
        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        public IconChar Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }
        //--> Commands
        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowCustomerViewCommand { get; }
        public ICommand ShowBiomassesViewCommand { get; }
        public ICommand ShowDashboardViewCommand { get; }
        public ICommand ShowSettingViewCommand { get; }
        public ICommand ShowDiagramViewCommand { get; }
        public ICommand ShowContactUsViewCommand { get; }
        public MainViewModel()
        {
            userRepository = new UserRepository();
            CurrentUserAccount = new UserAccountModel();
            //Initialize commands
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowCustomerViewCommand = new ViewModelCommand(ExecuteShowCustomerViewCommand);
            ShowBiomassesViewCommand = new ViewModelCommand(ExecuteShowBiomassesViewCommand);
            ShowDashboardViewCommand = new ViewModelCommand(ExecuteShowDashboardViewCommand);
            ShowSettingViewCommand = new ViewModelCommand(ExecuteSettingViewCommand);
            ShowDiagramViewCommand = new ViewModelCommand(ExecuteDiagramViewCommand);
            ShowContactUsViewCommand = new ViewModelCommand(ExecuteContactUsViewCommand);
            //Default view
            ExecuteShowHomeViewCommand(null);
            LoadCurrentUserData();
        }

        private void ExecuteContactUsViewCommand(object obj)
        {
            CurrentChildView = new ContactUsViewModel();
            Caption = "Contact Us";
            Icon = IconChar.UserGroup;
        }

        private void ExecuteDiagramViewCommand(object obj)
        {
            CurrentChildView = new DiagramViewModel();
            Caption = "Diagram";
            Icon = IconChar.ChartLine;
        }

        private void ExecuteSettingViewCommand(object obj)
        {
            CurrentChildView = new SettingViewModel();
            Caption = "Settings";
            Icon = IconChar.Gear;
        }

        private void ExecuteShowDashboardViewCommand(object obj)
        {
            CurrentChildView = new DashboardViewModel();
            Caption = "Dashboard";
            Icon = IconChar.Home;
        }

        private void ExecuteShowCustomerViewCommand(object obj)
        {
            CurrentChildView = new CustomerViewModel();
            Caption = "Customers";
            Icon = IconChar.UserGroup;
        }
        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "Dashboard";
            Icon = IconChar.Home;
        }
        private void ExecuteShowBiomassesViewCommand(object obj)
        {
            CurrentChildView = new BiomassesViewModel();
            Caption = "Biomasses";
            Icon = IconChar.Seedling;
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.Username = user.Username;
                CurrentUserAccount.DisplayName = $"Welcome {user.Name} {user.LastName} ;)";
                CurrentUserAccount.ProfilePicture = null;
            }
            else
            {
                CurrentUserAccount.DisplayName = "Invalid user, not logged in";
                //Hide child views.
            }
        }
    }
}
