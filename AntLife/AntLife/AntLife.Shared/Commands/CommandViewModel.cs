using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AntLife.Commands
{
    /// <summary>
    /// Модель представления команды, которая будет связана с окнами игры
    /// </summary>
    public class CommandViewModel
    {
        private ICommand command;

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

        public CommandViewModel(ExecuteAsyncCommand commandHandler)
        {
            this.command = new AsyncPageCommand(commandHandler);            
        }
    }


}
