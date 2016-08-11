using AntLife.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AntLife.ViewModels
{
    public class MainMenuViewModel : ViewModelBase
    {
        #region Команды главного меню 
        /// <summary>
        /// Старт новой игры
        /// </summary>
        public CommandViewModel StartNewGameCommand { get; set; }

        /// <summary>
        /// Загрузка сохранённой игры
        /// </summary>
        public CommandViewModel LoadSavedGameCommand { get; set; }

        /// <summary>
        /// Продолжить игру с последнего сохранения
        /// </summary>
        public CommandViewModel ContinueGameCommand { get; set; }

        /// <summary>
        /// Вернуться к игре
        /// </summary>
        public CommandViewModel BackToGameCommand { get; set; }

        /// <summary>
        /// Сохранить игру
        /// </summary>
        public CommandViewModel SaveGameCommand { get; set; }

        /// <summary>
        /// Настройки игры
        /// </summary>
        public CommandViewModel SettingsCommand { get; set; }

        /// <summary>
        /// Выход из игры
        /// </summary>
        public CommandViewModel ExitGameCommand { get; set; }
        #endregion

        /// <summary>
        /// Создаёт экземпляр модели главного меню и инициализирует обработчики команд
        /// </summary>
        public MainMenuViewModel()
        {
            StartNewGameCommand = new CommandViewModel(StartGameExecuteAsync);
            LoadSavedGameCommand = new CommandViewModel(LoadGameExecuteAsync);
            ContinueGameCommand = new CommandViewModel(ContinueGameExecuteAsync);
            BackToGameCommand = new CommandViewModel(BackToGameExecuteAsync);
            SaveGameCommand = new CommandViewModel(SaveGameExecuteAsync);
            SettingsCommand = new CommandViewModel(SettingsExecuteAsync);
            ExitGameCommand = new CommandViewModel(ExitGameExecuteAsync);
        }

        #region Обработчики команд
        private async Task StartGameExecuteAsync(Object parameter)
        {
            throw new NotImplementedException();
        }
        private async Task LoadGameExecuteAsync(Object parameter)
        {
            throw new NotImplementedException();
        }
        private async Task ContinueGameExecuteAsync(Object parameter)
        {
            throw new NotImplementedException();
        }
        private async Task BackToGameExecuteAsync(Object parameter)
        {
            throw new NotImplementedException();
        }
        private async Task SaveGameExecuteAsync(Object parameter)
        {
            throw new NotImplementedException();
        }
        private async Task SettingsExecuteAsync(Object parameter)
        {
            throw new NotImplementedException();
        }
        private async Task ExitGameExecuteAsync(Object parameter)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
