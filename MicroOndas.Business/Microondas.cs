namespace MicroOndas.Business
{
    public enum EstadoMicroondas
    {
        Parado,
        Aquecendo,
        Pausado
    }

    public class Microondas
    {
        public int Tempo { get; private set; }
        public int Potencia { get; private set; }
        public EstadoMicroondas Estado { get; private set; }

        private const int TEMPO_MAX = 120;
        private const int TEMPO_MIN = 1;
        private const int POTENCIA_MAX = 10;
        private const int POTENCIA_MIN = 1;

        public Microondas()
        {
            Tempo = 0;
            Potencia = 10;
            Estado = EstadoMicroondas.Parado;
        }

        public void Configurar(int tempo, int potencia = 10)
        {
            if (tempo < TEMPO_MIN || tempo > TEMPO_MAX)
                throw new ArgumentException("Tempo inválido (1s a 120s)");

            if (potencia < POTENCIA_MIN || potencia > POTENCIA_MAX)
                throw new ArgumentException("Potência inválida (1 a 10)");

            Tempo = tempo;
            Potencia = potencia;
        }

        public void Iniciar()
        {
            if (Tempo == 0) // início rápido
            {
                Tempo = 30;
                Potencia = 10;
            }

            Estado = EstadoMicroondas.Aquecendo;
        }

        public void PausarOuCancelar()
        {
            if (Estado == EstadoMicroondas.Aquecendo)
                Estado = EstadoMicroondas.Pausado;
            else
            {
                Tempo = 0;
                Potencia = 10;
                Estado = EstadoMicroondas.Parado;
            }
        }

        public void AcrescentarTempo()
        {
            if (Estado == EstadoMicroondas.Aquecendo)
                Tempo = Math.Min(TEMPO_MAX, Tempo + 30);
        }
    }
}
