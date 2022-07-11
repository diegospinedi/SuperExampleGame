using SuperExampleGame.Domain.AggregatesModel.GuerrerosAggregate;
using SuperExampleGame.Domain.AggregatesModel.NivelesAggregate;
using System;
using System.Collections.Generic;

namespace SuperExampleGame.Domain.AggregatesModel.GuerrerosAggregate
{
    public class Guerrero
    {
        public Guid GuerreroId { get; set; }
        public ICollection<GuerrerosAttributeType> Destreza { get; set; }
        public Niveles Nivel { get; set; }
        public Guid IdUsuario { get; set; }


        public Guerrero (ICollection<GuerrerosAttributeType> destreza,Niveles nivel,Guid idUsuario)
        {
            Destreza = new HashSet<GuerrerosAttributeType>();
            Nivel = nivel;
            IdUsuario = idUsuario;
        }
            
    }
}
