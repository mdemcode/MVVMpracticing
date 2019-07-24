using MVVMtest.Model;
using System.Windows.Input;

namespace MVVMtest.ModelWidoku {
    public class WidokGlowny : Powiadomienia {

        #region POLA I WŁAŚCIWOŚCI
        private readonly Cosik dane = DAL.Wczytaj();
        public decimal Zlecenia {
            get { return dane.Zlecenia; }
            set {
                dane.Zlecenia = value;
                OnPropertyChanged(nameof(Zlecenia));
                DAL.Zapisz(dane);
            }
        }
        public decimal Grupy {
            get { return dane.Grupy; }
            set {
                dane.Grupy = value;
                OnPropertyChanged(nameof(Grupy));
                DAL.Zapisz(dane);
            }
        }
        public decimal Elementy {
            get { return dane.Elementy; }
            set {
                dane.Elementy = value;
                OnPropertyChanged(nameof(Elementy));
                DAL.Zapisz(dane);
            }
        }
        #endregion

        #region POLECENIA
        private ICommand zapisz;
        public ICommand Zapisz {
            get {
                if (zapisz == null) {
                    zapisz = new RelayCommand
                        (
                            argument => {
                                Zlecenia = 100m;
                                Grupy = 200m;
                                Elementy = 300m;
                            },
                            argument => Zlecenia>=0m
                        );
                }
                return zapisz;
            }
        }
        #endregion
    }
}
