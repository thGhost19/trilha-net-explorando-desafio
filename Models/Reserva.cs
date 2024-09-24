namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes, Suite suite)
        {
            if (suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade máxima atingida");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            if (hospedes != null)
            {
                return hospedes.Count;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalcularValorDiaria(Suite suite)
        {
            decimal valor = 0;
            decimal valorReservaEDiaria = 0;
            if (suite != null)
            {
                valorReservaEDiaria = suite.ValorDiaria * DiasReservados;
            }

            if (DiasReservados >= 10)
            {
                valor = valorReservaEDiaria * 0.9m;
            }
            else
            {
                valor = valorReservaEDiaria;
            }

            return valor;
        }
    }
}