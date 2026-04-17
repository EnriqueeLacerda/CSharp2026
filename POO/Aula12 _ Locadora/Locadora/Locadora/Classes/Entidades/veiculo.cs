namespace LocadoraCarro.Entidades
{
    public class Veiculo
    {
        private string _modelo;

        public Veiculo(string modelo)
        {
            _modelo = modelo;
        }

        public string Modelo => _modelo;
    }
}