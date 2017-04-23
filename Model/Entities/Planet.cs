using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.Models
{
    public class Planet
    {
        private string name;
        private int velocity; //Expresada en grados / dia
        private PolarCoordinates position;

        public Planet(string name, PolarCoordinates initialPosition, int velocity)
        {
            this.name = name;
            this.position = initialPosition;
            this.velocity = velocity;
        }

        public PolarCoordinates GetPosition()
        {
            return position;
        }

        public void MoveOneDay()
        {
            //Esto es una simplificacion. Como se que la velocidad angular esta expresada en grados / dia puedo plantear el cambio de posicion 
            //diario como el incremento de grados dado por la magnitud de la velocidad angular.
            this.position.IncreaseAngle(velocity);
        }
    }
}