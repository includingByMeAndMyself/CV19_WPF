using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _titel = "Анализ статистики CV19";

        /// <summary>Заголовок окна</summary>
        public string Titel
        {
            get => _titel;
 
            set => Set(ref _titel, value);
        }

        #endregion


    }
}
