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
                                Zlecenia = 0m;
                                Grupy = 0m;
                                Elementy = 0m;
                            },
                            argument => Zlecenia>=0m
                        );
                }
                return zapisz;
            }
        }

        private ICommand zapisz2;
        public ICommand Zapisz2 {
            get {
                if (zapisz2 == null) {
                    zapisz2 = new RelayCommand
                        (
                            argument => {
                                Zlecenia = 10m;
                                Grupy = 20m;
                                Elementy = 30m;
                            },
                            argument => Zlecenia >= 0m
                        );
                }
                return zapisz2;
            }
        }
        #endregion
    }
}
