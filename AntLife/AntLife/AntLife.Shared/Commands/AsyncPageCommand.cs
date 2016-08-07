using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AntLife.Commands
{
    /// <summary>
    /// Реализация интерфейса ICommand
    /// </summary>
    internal class AsyncPageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public AsyncPageCommand(ExecuteAsyncCommand handler)
        {
            ExecuteAsync = handler;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ExecuteAsync(parameter);
        }

        private ExecuteAsyncCommand ExecuteAsync;
    }

    /// <summary>
    /// Делегат для асинхронной команды
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    public delegate Task ExecuteAsyncCommand(Object p);
}
