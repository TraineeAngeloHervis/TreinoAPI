using Crosscutting;

namespace Domain
{
    public class TesteService : ITesteService
    {
        private readonly ICombinadorDeStringService _combinadorDeStringService;

        public TesteService(ICombinadorDeStringService combinadorDeStringService)
        {
            _combinadorDeStringService = combinadorDeStringService;
        } 

        public string TesteMetodo(TesteRequisicaoDto requisicao)
        {
            var lista = new List<string>
            {
                requisicao.Primeira,
                requisicao.Segunda,
                requisicao.Terceira
            };

            var resultado = _combinadorDeStringService.CombinarPartes(lista);

            return resultado;
        }
    }
}
