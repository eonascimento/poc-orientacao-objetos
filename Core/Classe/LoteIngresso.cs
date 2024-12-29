namespace Core.Classe
{
    public class LoteIngresso
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataEncerramento { get; set; }
        public IEnumerable<Ingresso> Ingressos { get; set; }
    }
}
