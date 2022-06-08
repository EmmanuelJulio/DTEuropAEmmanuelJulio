using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTEuroapAEmmanuelJulioTest
{
    
    public class TestValidName
    {
        void setup() 
        { 
        }

        [Test]
        public void TestNombre_True_1()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("E. Poe");
            //aassert
            Assert.AreEqual(resultado, true);
        }
        [Test]
        public void TestNombre_True_2()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("E. A. Poe");
            //aassert
            Assert.AreEqual(resultado, true);
        }
        [Test]
        public void TestNombre_True_3()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("Edgar Allan Poe");
            //aassert
            Assert.AreEqual(resultado, true);
        }
        [Test]
        public void TestNombre_True_4()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("Edgar A. Poe");
            //aassert
            Assert.AreEqual(resultado, true);
        }
        [Test]
        public void TestNombre_Fail_1()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("Edgar");
            //aassert
            Assert.AreEqual(resultado, false);
        }
        [Test]
        public void TestNombre_Fail_2()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("E Poe");
            //aassert
            Assert.AreEqual(resultado, false);
        }
        [Test]
        public void TestNombre_Fail_3()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("E. A Poe");
            //aassert
            Assert.AreEqual(resultado, false);
        }
        [Test]
        public void TestNombre_Fail_4()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("E. Allan Poe");
            //aassert
            Assert.AreEqual(resultado, false);
        }
        [Test]
        public void TestNombre_Fail_5()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("E. A. P.");
            //aassert
            Assert.AreEqual(resultado, false);
        }
        [Test]
        public void TestNombre_Fail_6()
        {
            //arange
            DTEuropAEmmanuelJulio.Manager.Validate validate = new DTEuropAEmmanuelJulio.Manager.Validate();
            DTEuropAEmmanuelJulio.Manager.Service service = new DTEuropAEmmanuelJulio.Manager.Service(validate);
            //act
            bool resultado = service.ValidName("Edg. A. Poe");
            //aassert
            Assert.AreEqual(resultado, false);
        }
    }
}
