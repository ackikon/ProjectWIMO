using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestNewDesign.ViewModel.HelperViewModel
{
    class ViewModelProp : INotifyPropertyChanged ///Данный класс отслеживает какие-либо изменения в окне, наследует элементы интерфейса INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; ///Событие, когда что-либо поменялось
            
        protected void OnPropertyChanged([CallerMemberName] string prop = "") ///Если событие не null, значит что-то поменялось, где prop - имя свойства
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        protected void Set<T>(ref T field, T value, [CallerMemberName] string prop = "") 
        {
            if (Equals(field, value)) return;
            field = value;
            OnPropertyChanged(prop);
        }
    }
}
