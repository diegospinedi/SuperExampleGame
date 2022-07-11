using Microsoft.EntityFrameworkCore;
using SuperExampleGame.Domain.AggregatesModel.UsuariosAggregate;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SuperExampleGame.Infrastructure
{
    public class UsuarioRepository:IUsuarioRepository
    {
        readonly SuperExampleGameContext _context;

        public UsuarioRepository(SuperExampleGameContext context)
        {
            _context = context;
        }
        
        public Task<Usuario> GetAsync (Guid id,CancellationToken cancellationToken)
        {
            return _context.Usuarios.FirstOrDefaultAsync(x => x.UsuarioId == id);
        }
         
    }

}
