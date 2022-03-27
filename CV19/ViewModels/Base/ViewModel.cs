﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CV19.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        private bool _disposed;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Dispose()
        {
            Dispose(true);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if(!disposing || _disposed)
            {
                return;
            }

            _disposed = true;
        }

        //~ViewModel()
        //{
        //    Dispose(false);
        //}

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool Set<T> (ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }
                
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
