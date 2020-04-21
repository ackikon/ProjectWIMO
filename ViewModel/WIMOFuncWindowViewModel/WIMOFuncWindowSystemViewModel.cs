using System.Windows.Input;
using System.Windows;
using TestNewDesign.ViewModel.HelperViewModel;
using System;
using System.Windows.Controls;
using TestNewDesign.View.Pages.WIMOFuncWindowPages;

namespace TestNewDesign.ViewModel.WIMOFuncWindowViewModel
{
    class WIMOFuncWindowSystemViewModel : ViewModel.HelperViewModel.HelperViewModel
    {

        public static Action CloseWindowMain { get; set; }

        private Page currentCenterPage;
        private Page currentSidePage;

        private static int pageCenterNum = 0;
        private static int pageSideNum = 2;
        public Page CurrentCenterPage 
        {
            get => this.currentCenterPage;
            set => this.Set<Page>(ref currentCenterPage, value);
        }

        public Page CurrentSidePage
        {
            get => this.currentSidePage;
            set => this.Set<Page>(ref currentSidePage, value);
        }

        public WIMOFuncWindowSystemViewModel()
        {
            switch(pageCenterNum)
            {
                case 0:
                    CurrentCenterPage = new View.Pages.WIMOFuncWindowPages.WIMOCenterPages.InfoPage();
                    break;

                default:
                    MessageBox.Show("Ошибка");
                    break;
            }


            switch (pageSideNum)
            {
                case 0:
                    CurrentSidePage = new View.Pages.WIMOFuncWindowPages.WIMOSidesPages.AdminPage();
                    break;
                case 1:
                    CurrentSidePage = new View.Pages.WIMOFuncWindowPages.WIMOSidesPages.UserPage();
                    break;
                case 2:
                    CurrentSidePage = new View.Pages.WIMOFuncWindowPages.WIMOSidesPages.UnknowUserPage();
                    break;
                default:
                    MessageBox.Show("Ошибка");
                    break;
            }
        }

    }
}
