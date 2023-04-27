using System;
using System.Collections.Generic;

namespace WeatherApp
{
    public class WeatherDatabase
    {
      
        
        internal List<AvtoMagaz> AvtoMagazs { get; private set; }

        public void Initialize()
        {
            AvtoMagazs = new List<AvtoMagaz>
            {
                new AvtoMagaz(400, Avto.Honda, new Rashodnik("свеча"), new Zapchasti("Руль"),new Postavshik ("A-Z Traid")), 
                new AvtoMagaz(500, Avto.Nissan, new Rashodnik("Свеча"), new Zapchasti("Двигатель"),new Postavshik ("A-Z Traid")),
                new AvtoMagaz(400, Avto.Toyoat, new Rashodnik("свеча"), new Zapchasti("Дворники"),new Postavshik ("A-Z Traid")),
                new AvtoMagaz(3.124, Avto.Honda, new Rashodnik("Свеча"), new Zapchasti("Тормозной диск"),new Postavshik ("A-Z Traid")),
                new AvtoMagaz(1.320, Avto.Nissan, new Rashodnik("Свеча"), new Zapchasti("Выхлопная труба"),new Postavshik ("A-Z Traid")),
                new AvtoMagaz(400, Avto.Toyoat, new Rashodnik("Свеча"), new Zapchasti("Эмблема"),new Postavshik ("A-Z Traid")),
                new AvtoMagaz(3.567, Avto.Honda, new Rashodnik("Свеча"), new Zapchasti("Капот"),new Postavshik ("A-Z Traid")),
                new AvtoMagaz(5.421, Avto.Nissan, new Rashodnik("Свеча"), new Zapchasti("Сцепление"),new Postavshik ("A-Z Traid")),
                new AvtoMagaz(400, Avto.Toyoat, new Rashodnik("Свеча"), new Zapchasti("Тормозная система"),new Postavshik ("A-Z Traid"))
            };
        }
    }
}