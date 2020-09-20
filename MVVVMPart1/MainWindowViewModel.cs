using System;
using System.Windows.Input;
using WalterLabs.Command;
using WalterLabs.ViewModel;

namespace MVVVMPart1
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Properties
        public string InsertedText
        {
            get => _insertedText;
            set { _insertedText = value; OnPropertyChanged(); }
        }
        private string _insertedText;
        #endregion

        #region Commands
        public ICommand OnOkCommand { get; private set; }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            OnOkCommand = new RelayCommand(OnOk, OkCanExecute);
        }

        private bool OkCanExecute(object obj)
        {
            return InsertedText != null && InsertedText.Trim() != "";
        }
        #endregion
        private void OnOk(object obj)
        {
            InsertedText = "ciao";
        }
    }
}
