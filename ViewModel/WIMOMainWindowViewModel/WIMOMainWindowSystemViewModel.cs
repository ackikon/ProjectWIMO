using System.Windows.Input;
using System.Windows;
using TestNewDesign.ViewModel.HelperViewModel;
using System;
using System.Windows.Controls;
using TestNewDesign.View.Pages.WIMOMainWindowPages;

namespace TestNewDesign.ViewModel.WIMOMainWindowViewModel
{
    class WIMOMainWindowSystemViewModel : ViewModel.HelperViewModel.HelperViewModel
    {

        public static Action CloseWindowMain { get; set; }

        private Page currentPage;
        private Page currentPageRightSide;

        public static int pageNum=1;
        public static int pageRightSideNum=0;

        public Page CurrentPage 
        {
            get => this.currentPage;
            set => this.Set<Page>(ref currentPage, value);
        }
        public Page CurrentPageRightSide
        {
            get => this.currentPageRightSide;
            set => this.Set<Page>(ref currentPageRightSide, value);
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
                    CurrentPage = new View.Pages.WIMOMainWindowPages.LoginPage();
                    break;
                case 1:
                    CurrentPage = new View.Pages.WIMOMainWindowPages.RegisterPage();
                    break;
                default:
                    MessageBox.Show("Ошибка");
                    break;
            }

            switch (pageRightSideNum)
            {
                case 0:
                    CurrentPageRightSide = new View.Pages.WIMOMainWindowPages.WIMORightSidePages.PersonalDataPage();
                    break;
                case 1:
                    CurrentPageRightSide = new View.Pages.WIMOMainWindowPages.WIMORightSidePages.AdditionalAgreementPage();
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