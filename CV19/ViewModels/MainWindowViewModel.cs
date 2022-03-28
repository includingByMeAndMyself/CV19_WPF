using CV19.Infrastucture.Commands;
using CV19.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Title : string Заголовок окна

        private string _title = "Анализ статистики CV19";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _title;
 
            set => Set(ref _title, value);
        }

        #endregion

        #region Status : string - Статус программы

        private string _status = "Done";

        public string Status 
        { 
            get => _status; 
            set => Set(ref _status, value); 
        }

        #endregion

        #region Команды

        #region CloseApplicationCommand 

        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion
        }
    }
}
