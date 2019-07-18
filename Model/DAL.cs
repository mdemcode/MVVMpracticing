namespace MVVMtest.Model {
    public static class DAL {
        private static readonly Properties.Settings ustawienia = Properties.Settings.Default;
        public static Cosik Wczytaj() {
            var dane = new Cosik() {
                Elementy = ustawienia.ELEMENTY,
                Grupy = ustawienia.GRUPY,
                Zlecenia = ustawienia.ZLECENIA
            };
            return dane;
        }
        public static void Zapisz (Cosik dane) {
            ustawienia.ZLECENIA = dane.Zlecenia;
            ustawienia.GRUPY = dane.Grupy;
            ustawienia.ELEMENTY = dane.Elementy;
            ustawienia.Save();
        }
    }
}
