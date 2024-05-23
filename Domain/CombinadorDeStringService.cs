namespace Domain
{
    public class CombinadorDeStringService : ICombinadorDeStringService
    {
        public string CombinarPartes(IEnumerable<string> partes) 
        { 
            return string.Join(",", partes);
        }
    }
}
