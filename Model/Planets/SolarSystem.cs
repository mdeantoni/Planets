using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Observer;

namespace Planets.Models
{
    public class SolarSystem : Model.Observer.IObservable<SolarSystem>
    {
        private CartesianCoordinates SunCoordinates = new CartesianCoordinates(0, 0); //Initialized here since i dont have a ctor parameter that alters this.
        private IList<Planet> planets;
        private IList<Model.Observer.IObserver<SolarSystem>> observers;
        private int day;

        public IList<Planet> GetPlanets()
        {
            return this.planets;
        }

        public void AdvanceDays(int days)
        {
            for (var i = 1; i < days; i++)
            {
                this.ForwardOneDay();
            }
        }

        public SolarSystem(IList<Planet> planets, int dayOffset = 1)
        {
            this.planets = planets;
            this.observers = new List<Model.Observer.IObserver<SolarSystem>>();
            this.day = dayOffset;
        }

        public void ForwardOneDay()
        {
            this.day++;

            foreach (var planet in planets)
            {
                planet.MoveOneDay();
            }

            this.NotifyObservers();
        }

        public CartesianCoordinates GetSunCoordinates()
        {
            return new CartesianCoordinates(0, 0);
        }

        public void NotifyObservers()
        {
            foreach (var observer in this.observers)
            {
                observer.Update(this);
            }
        }

        public int GetDay()
        {
            return this.day;
        }

        public void AddObserver(Model.Observer.IObserver<SolarSystem> observer)
        {
            this.observers.Add(observer);
            observer.Update(this); //Initial Value set up
        }
    }
}