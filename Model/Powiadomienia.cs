using System.ComponentModel;

namespace MVVMtest.Model {
    public abstract class Powiadomienia : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(params string[] nazwyWlasnosci) {
            if (PropertyChanged != null) {
                foreach (var wlasnosc in nazwyWlasnosci) {
                    PropertyChanged(this, new PropertyChangedEventArgs(wlasnosc));
                }
            }
        }
    }
}
