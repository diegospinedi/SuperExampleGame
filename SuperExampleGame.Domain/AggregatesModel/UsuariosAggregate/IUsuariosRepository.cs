using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperExampleGame.Domain.AggregatesModel.UsuariosAggregate
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetAsync(Guid id, CancellationToken cancellationToken);
    }
}
