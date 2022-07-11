using Microsoft.EntityFrameworkCore;
using SuperExampleGame.Domain;
using SuperExampleGame.Domain.AggregatesModel.GuerrerosAggregate;
using SuperExampleGame.Domain.AggregatesModel.UsuariosAggregate;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SuperExampleGame.Infrastructure
{
    public class GuerreroRepository:IGuerreroRepository
    {
        readonly SuperExampleGameContext _context;

        public GuerreroRepository(SuperExampleGameContext context)
        {
            _context = context;
        }
        
       
        public Task<Guerrero> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            return _context.Guerreros.FirstOrDefaultAsync(x => x.GuerreroId== id);
        }
    }

}
