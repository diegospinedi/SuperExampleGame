using SuperExampleGame.Domain.AggregatesModel.GuerrerosAggregate;
using SuperExampleGame.Domain.AggregatesModel.PreciosAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperExampleGame.Domain.AggregatesModel.EquiposAggregate
{
    public class Equipos
    {
        public EquiposAttributeType Equipo { get; set; }
        public Precios Precio { get; set; }
        public ICollection<GuerrerosAttributeType> DestrezasMejoradas { get; set; }
    }
}
