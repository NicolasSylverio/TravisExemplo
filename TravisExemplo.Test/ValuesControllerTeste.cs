using TravisExemplo.WebApi.Controllers;
using Xunit;

namespace TravisExemplo.Test
{
    public class ValuesControllerTeste
    {
        private readonly ValuesController valuesController;

        public ValuesControllerTeste()
        {
            valuesController = new ValuesController();
        }

        [Fact]
        public void ValuesController()
        {
            Assert.Equal(1, 1);
        }
    }
}