namespace WeatherApp
{
    class Zapchasti
    {
        private string _name;
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public Zapchasti(string name)
        {
            _name = name;
        }
    }
}
