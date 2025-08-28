using Xunit;
using System;
using MicroOndas.Business;  // <-- Aqui é o que conecta os testes com a classe

namespace MicroOndas.Tests
{
    public class MicroondasTests
    {
        [Fact]
        public void IniciarRapido_DeveConfigurar30SegundosPotencia10()
        {
            var micro = new Microondas();

            micro.Iniciar();

            Assert.Equal(30, micro.Tempo);
            Assert.Equal(10, micro.Potencia);
            Assert.Equal(EstadoMicroondas.Aquecendo, micro.Estado);
        }

        [Fact]
        public void Configurar_TempoInvalido_DeveLancarExcecao()
        {
            var micro = new Microondas();
            Assert.Throws<ArgumentException>(() => micro.Configurar(200, 5));
        }

        [Fact]
        public void AcrescentarTempo_DeveSomar30Segundos()
        {
            var micro = new Microondas();
            micro.Configurar(20, 5);
            micro.Iniciar();

            micro.AcrescentarTempo();

            Assert.Equal(50, micro.Tempo); // 20 + 30
        }
    }
}
