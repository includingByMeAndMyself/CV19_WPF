using CV19.Infrastucture.Commands;
using CV19.Models;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region TestDataPoints

        private IEnumerable<DataPoint> _testDataPoint;

        public IEnumerable<DataPoint> TestDataPoint 
        { 
            get => _testDataPoint;
            set => Set(ref _testDataPoint, value);
        }

        #endregion

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

            var dataPoints = new List<DataPoint>((int)(360/0.1));
            for(var x = 0d; x <=360; x += 0.1)
            {
                const double toRad = Math.PI / 180;
                var y = Math.Sin(x * toRad);

                dataPoints.Add(new DataPoint { XValue = x, YValue = y });
            }
            TestDataPoint = dataPoints;
        }
    }
}
