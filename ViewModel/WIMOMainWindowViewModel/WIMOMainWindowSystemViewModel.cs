using System.Windows.Input;
using System.Windows;
using TestNewDesign.ViewModel.HelperViewModel;
using System;
using System.Windows.Controls;

namespace TestNewDesign.ViewModel.WIMOMainWindowViewModel
{
    class WIMOMainWindowSystemViewModel : ViewModel.HelperViewModel.HelperViewModel
    {

        public static Action CloseWindowMain { get; set; }

        private Page currentPage;

        public static int pageNum=0;

        public Page CurrentPage 
        {
            get => this.currentPage;
            set => this.Set<Page>(ref currentPage, value);
        }


        public ICommand LoginCommand { get; set; } // Команда для входа 
        public ICommand RegCommand { get; set; } // Команда для регистрации
        public ICommand ExitCommand { get; set; } //Команда для выхода


        public WIMOMainWindowSystemViewModel()
        {
            this.LoginCommand = new Command(LoginCommandClick);
            this.RegCommand = new Command(RegCommandClick);
            this.ExitCommand = new Command(ExitCommandClick);

            switch (pageNum)
            {
                case 0:
                    CurrentPage = new View.MainWindowSystem.LoginPage.LoginPage();
                    break;
                default:
                    MessageBox.Show("Ошибка");
                    break;
            }
        }



        private void LoginCommandClick(object obj)
        {
            
            
        }

        private void RegCommandClick(object obj)
        {
            MessageBox.Show("Регистрация");
        }

        private void ExitCommandClick(object obj)
        {
            Environment.Exit(0);
        }
    }
}
