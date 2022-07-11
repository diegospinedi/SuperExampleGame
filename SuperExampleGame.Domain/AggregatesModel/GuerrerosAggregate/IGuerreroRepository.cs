using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperExampleGame.Domain.AggregatesModel.GuerrerosAggregate
{
    public interface IGuerreroRepository
    {
        Task<Guerrero> GetAsync(Guid id, CancellationToken cancellationToken);
    }
}
