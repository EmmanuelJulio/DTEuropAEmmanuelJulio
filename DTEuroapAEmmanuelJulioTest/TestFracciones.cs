namespace DTEuroapAEmmanuelJulioTest
{
    public class TestSimplificacionDeFracciones
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SimplificacionDeFracciones1()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            string resultado = service.Simplificar("100/400");
            //aassert
            Assert.AreEqual(resultado,"1/4");
        }
        [Test]
        public void SimplificacionDeFracciones2()
        {
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);

            string resultado = service.Simplificar("10/11");

            Assert.AreEqual(resultado,"10/11");
        }
        [Test]
        public void SimplificacionDeFracciones3()
        {
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);

            string resultado = service.Simplificar("102//11");

            Assert.AreEqual(resultado,DTEuropAEmmanuelJulio.Constants.Constants.InvalidFormatFraction);
        }
        [Test]
        public void SimplificacionDeFraccionesSiSedivideEnteroRetornaEntero()
        {
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            string resultado = service.Simplificar("100/10");
            Assert.AreEqual(resultado,"10");
        }
    }
}