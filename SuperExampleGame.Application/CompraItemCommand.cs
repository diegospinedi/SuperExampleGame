using SuperExampleGame.Domain.AggregatesModel.EquiposAggregate;
using SuperExampleGame.Domain.AggregatesModel.GuerrerosAggregate;
using SuperExampleGame.Domain.AggregatesModel.NivelesAggregate;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SuperExampleGame.Application
{
    [DataContract]
    public class CompraItemCommand
    {
        [DataMember]
        public Guid IdUsuario { get; set; }

        [DataMember]
        public Guid GuerreroId { get; set; }

        [DataMember]
        public Equipos ItemAComprar { get; set; }
    }

    [DataContract]
    public class CompraItemSalidaModel
    {
        [DataMember]
        public Equipos  ItemAdquirido { get; set; }

        [DataMember]
        public ICollection<GuerrerosAttributeType> DestrezaMejorada { get; set; }

        [DataMember]
        public Niveles NuevoNivelAdquirido { get; set; }

        [DataMember]
        public string  Mensaje { get; set; }


    }
}
