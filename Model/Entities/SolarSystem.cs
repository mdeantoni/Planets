using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Observer;

namespace Planets.Models
{
    public class SolarSystem : Model.Observer.IObservable<SolarSystem>
    {
        private IList<Planet> planets;
        private IList<Model.Observer.IObserver<SolarSystem>> observers;
        private int day;

        public IList<Planet> GetPlanets()
        {
            return this.planets;
        }

        public SolarSystem(IList<Planet> planets, int dayOffset = 0)
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