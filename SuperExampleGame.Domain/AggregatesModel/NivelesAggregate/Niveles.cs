using SuperExampleGame.Domain.AggregatesModel.GradosAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperExampleGame.Domain.AggregatesModel.NivelesAggregate
{
    public class Niveles
    {
        public NivelesAttributeType Nivel { get; set; }
        public Grados Grado { get; set; }


        public Niveles (NivelesAttributeType nivel,Grados grado)
        {
            Nivel = nivel;
            Grado = grado;
        }

        public void SetSubirNivel()
        {

        }
    }
}
