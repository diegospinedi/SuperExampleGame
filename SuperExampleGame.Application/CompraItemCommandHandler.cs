using SuperExampleGame.Domain.AggregatesModel.GuerrerosAggregate;
using SuperExampleGame.Domain.AggregatesModel.UsuariosAggregate;
using System.Threading;
using System.Threading.Tasks;

namespace SuperExampleGame.Application
{
    
    public class CompraItemCommandHandler
    {
        readonly IUsuarioRepository _usuariosRepository;
        readonly IGuerreroRepository _gerrerosRepository;

        public CompraItemCommandHandler(IUsuarioRepository usuariosRepository,
                                        IGuerreroRepository guerreroRepository)
        {
            _usuariosRepository = usuariosRepository;
            _gerrerosRepository = guerreroRepository;
        }
    

    public async Task<CompraItemSalidaModel> Handle (CompraItemCommand request,CancellationToken cancellationToken)
    {
            var user = await _usuariosRepository.GetAsync(request.IdUsuario, cancellationToken);

            if (user == null)
            {
                return null;
            }

           //En el usuario guardo el saldo que tiene

            var guerrero = await _gerrerosRepository.GetAsync(request.IdUsuario, cancellationToken);

            //Recupero el gerrero al cual quiere equipar

            //Valido su nivel actual, y en caso que que posea el saldo,
            //adquiero nuevo item y subo los niveles que me da el item.

            // en "mensaje" voy a guardar el mensaje de exito,
            //caso contrario, debo mostrar mensaje de que el saldo era insuficiente o que 
            //el guerrero llego al maximo nivel.
           

            return null;
        }

       
       
    }


}
