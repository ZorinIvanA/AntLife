using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace AntLife.Commands
{
    /// <summary>
    /// Модель представления команды, которая будет связана с окнами игры
    /// </summary>
    public class CommandViewModel
    {
        private ICommand command;

        /// <summary>
        /// Может ли команда быть выполнена
        /// </summary>
        public Visibility IsVisible
        {
            get { return command.CanExecute(null) ? Visibility.Visible : Visibility.Collapsed; }
            set
            {
                var asyncCommand = command as AsyncPageCommand;
                if (asyncCommand != null)
                {
                    asyncCommand.CanBeExecuted = (value == Visibility.Visible);
                }
            }
        }


        /// <summary>
        /// Команда, к которой привязаны элементы управления
        /// </summary>
        public ICommand Command
        {
            get
            {
                return command;
            }

            set
            {
                command = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр модели представления команды с привязанным
        /// асинхронным обработчиком
        /// </summary>
        /// <param name="commandHandler">Асинхронный обработчик</param>
        public CommandViewModel(ExecuteAsyncCommand commandHandler)
        {
            this.command = new AsyncPageCommand(commandHandler);
        }
    }


}
