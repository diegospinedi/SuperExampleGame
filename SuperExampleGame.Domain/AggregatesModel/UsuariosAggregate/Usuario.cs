using SuperExampleGame.Domain.AggregatesModel.PreciosAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperExampleGame.Domain.AggregatesModel.UsuariosAggregate
{
    public class Usuario
    {
        public virtual Guid UsuarioId  {get;set;}
        public virtual string  Nombre { get; set; }
        public virtual Precios Saldo { get; set; }
        
        public Usuario (string nombre, Precios saldo)
        {
            UsuarioId = new Guid();
            Nombre = nombre;
            Saldo = saldo;
        
        }
    }
}
