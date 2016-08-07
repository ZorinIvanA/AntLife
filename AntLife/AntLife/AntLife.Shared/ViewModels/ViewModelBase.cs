using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Reflection;

namespace AntLife.ViewModels
{
    /// <summary>
    /// Базовый класс для всех моделей представления
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие, сообщающее, что значение свойства было изменено
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Потокобезопасный запуск события PropertyChanged
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void DoPropertyChanged(String propertyName)
        {
            var x = PropertyChanged;
            if (x != null)
            {
                x(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Запускает PropertyChanged для всех свойств модели представления
        /// </summary>
        protected virtual void DoAllPropertiesChanged()
        {
            var properties = this.GetType().GetRuntimeProperties();
            foreach (var property in properties)
            {
                this.DoPropertyChanged(property.Name);
            }
        }
    }
}
