namespace WeatherApp
{
    public enum Avto
    {
        Honda,
        Nissan,
        Toyoat
    }

    internal class AvtoMagaz
    {
        private double _cena;
        private Avto _avto = Avto.Honda;
        private Zapchasti _zap;
        private Rashodnik _rashodnik;
        private Postavshik _postavshik;

        public double Cena
        {
            get => _cena;
        }

        public Avto Avto
        {
            get => _avto;
        }

        private Zapchasti Zap
        {
            get => _zap;
        }
        private Rashodnik Ras
        {
            get => _rashodnik;
        }
        private Postavshik Post
        {
            get => _postavshik;
        }
        public string RasName
        {
            get { return Ras != null ? Ras.Name : "Не назначено"; }
        }
        public string ZapName
        {
            get { return Zap != null ? Zap.Name : "Не назначено"; }
        }
        public string PostName
        {
            get { return Post != null ? Post.Name : "Не назначено"; }
        }

        public AvtoMagaz(double cena, Avto avto,Rashodnik rashodnik, Zapchasti zapchasti,Postavshik postavshik)
        {
            _cena = cena;
            _avto = avto;
           _rashodnik = rashodnik;
            _zap = zapchasti;
            _postavshik = postavshik;
        }


    }
}