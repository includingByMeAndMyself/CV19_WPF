using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _title = "Анализ статистики CV19";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _title;
 
            set => Set(ref _title, value);
        }

        #endregion


    }
}
