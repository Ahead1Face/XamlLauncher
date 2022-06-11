using BattleLauncher.View;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace BattleLauncher.ViewModel
{
    internal class MainWindeowModel : ViewModelBase
    {
        private Page Wow = new WOW();
        private Page COD_MW = new COD_MW();
        private Page COD4 = new COD4();
        private Page Diadl = new Diablo();
        private Page HS = new Hearthstone();
        private Page HOTS = new HOTS();
        private Page OW = new Overwatch();
        private Page W3 = new Warcraft3();

        private Page _CurPage = new HOTS();

        public Page CurPage
        {
            get { return _CurPage; }
            set { Set(ref _CurPage, value); }
        }

        public ICommand OpenCOD_MW
        {
            get
            {
                return new RelayCommand(() => CurPage = COD_MW); 
            }
        }
        public ICommand OpenWOW
        {
            get
            {
                return new RelayCommand(() => CurPage = Wow);
            }
        }
        public ICommand OpenCOD4
        {
            get
            {
                return new RelayCommand(() => CurPage = COD4);
            }
        }
        public ICommand OpenDiablo
        {
            get
            {
                return new RelayCommand(() => CurPage = Diadl);
            }
        }
        public ICommand OpenHS
        {
            get
            {
                return new RelayCommand(() => CurPage = HS);
            }
        }
        public ICommand OpenHOTS
        {
            get
            {
                return new RelayCommand(() => CurPage = HOTS);
            }
        }
        public ICommand OpenOW
        {
            get
            {
                return new RelayCommand(() => CurPage = OW);
            }
        }
        public ICommand OpenW3
        {
            get
            {
                return new RelayCommand(() => CurPage = W3);
            }
        }
    }
}
