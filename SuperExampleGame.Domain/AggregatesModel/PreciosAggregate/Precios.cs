using System;
using System.Collections.Generic;
using System.Text;

namespace SuperExampleGame.Domain.AggregatesModel.PreciosAggregate
{
    public class Precios
    {
        public PrecioAttributeType Material { get; set; }
        public int Costo { get; set; }
    }
}
