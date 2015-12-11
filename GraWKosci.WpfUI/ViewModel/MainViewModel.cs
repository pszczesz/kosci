using System.Collections.ObjectModel;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GraWKosci.WpfUI.View.Services;

namespace GraWKosci.WpfUI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>

        private readonly IMessageDialogService _messageDialogService;
        public MainViewModel(IMessageDialogService messageDialogService)
        {
            #region "sssss"
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            #endregion

            _messageDialogService = messageDialogService;
        }
        private RelayCommand _newGameStartCommand;

        /// <summary>
        /// Gets the NewGameCommand.
        /// </summary>
        public RelayCommand NewGameCommand
        {
            get
            {
                return _newGameStartCommand
                    ?? (_newGameStartCommand = new RelayCommand(
                    () => {
                        _messageDialogService
                        .ShowYesNowDialog("Nowa gra", "Czy zacząć nową grę"
                            );
                    }));
            }
        }

        private RelayCommand _exitCommand;

        /// <summary>
        /// Gets the ExitCommand.
        /// </summary>
        public RelayCommand ExitCommand
        {
            get
            {
                return _exitCommand
                    ?? (_exitCommand = new RelayCommand(
                    () => {
                        var result = _messageDialogService.ShowYesNowDialog("Wyjście", "Czy zakończyć grę");
                        if (result == MessageDialogResult.Yes) {
                            Application.Current.Shutdown();
                        }
                    }));
            }
        }
        private RelayCommand _addNewGamerCommand;

        /// <summary>
        /// Gets the NewGamerAddCommand.
        /// </summary>
        public RelayCommand NewGamerAddCommand
        {
            get
            {
                return _addNewGamerCommand
                    ?? (_addNewGamerCommand = new RelayCommand(
                    () =>
                    {   if(Tabs.Count<1)
                        Tabs.Add(new GameTabViewModel() {Header = "Test"});
                    },
                    () => { return Tabs.Count == 0; }
                    
                    ));
            }
        }

        private ObservableCollection<ITabViewModel> _tabs = new ObservableCollection<ITabViewModel>();

        public ObservableCollection<ITabViewModel> Tabs {
            get { return _tabs; }
            
        } 

    }
}