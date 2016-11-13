using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;

namespace UnitTestProject1
{
    [TestClass]
    public class TestService
    {
        /*
        [TestMethod]
        public void TestCrear()
        {
            ProductoWSC.ProductoClient proxy = new ProductoWSC.ProductoClient();
            ProductoWSC.EProducto productocreado = proxy.CrearProducto(new ProductoWSC.EProducto()
                {
                    codigobarra = "555555555556",
                    Nombre = "Prueba3",
                    Stock = 20
                }
                );

            Assert.AreEqual("555555555556", productocreado.codigobarra);
            Assert.AreEqual("Prueba3", productocreado.Nombre);
            Assert.AreEqual(20, productocreado.Stock);
        }
        [TestMethod]
        public void TestCrearFault()
        {
            ProductoWSC.ProductoClient proxy = new ProductoWSC.ProductoClient();
            try
            {
                ProductoWSC.EProducto productocreado = proxy.CrearProducto(new ProductoWSC.EProducto()
                {
                    codigobarra = "555555555557",
                    Nombre = "Prueba4",
                    Stock = 100
                });
            }
            catch (FaultException<ProductoWSC.RepetidoException> error)
            {
                Assert.AreEqual("Error al intentar Insertar", error.Reason.ToString());
                Assert.AreEqual(error.Detail.excodigobarra, "555555555557");
                Assert.AreEqual(error.Detail.exNombreProducto, "Prueba4");
            }

        }


        [TestMethod]
        public void TestModificar()
        {
            ProductoWSC.ProductoClient proxy = new ProductoWSC.ProductoClient();
            ProductoWSC.EProducto productomodificar = proxy.ModificarProducto(new ProductoWSC.EProducto()
            {
                codigobarra = "123",
                Nombre = "Prueba Test1",
                Stock = 21
            }
                );

            Assert.AreEqual("123", productomodificar.codigobarra);
            Assert.AreEqual("Prueba Test1", productomodificar.Nombre);
            Assert.AreEqual(21, productomodificar.Stock);
        }


        [TestMethod]
        public void TestModificarFault()
        {
            ProductoWSC.ProductoClient proxy = new ProductoWSC.ProductoClient();
            try
            {
                ProductoWSC.EProducto productocreado = proxy.ModificarProducto(new ProductoWSC.EProducto()
                {
                    codigobarra = "121",
                    Nombre = "Prueba test A",
                    Stock = 47
                });
            }
            catch (FaultException<ProductoWSC.RepetidoException> error)
            {
                Assert.AreEqual("Error al intentar Modificar", error.Reason.ToString());
                Assert.AreEqual(error.Detail.excodigobarra, "121");
                Assert.AreEqual(error.Detail.exNombreProducto, "El producto No existe");
                Assert.AreEqual(error.Detail.exStock, 47);
            }

        }
        */
        [TestMethod]
        public void TestObtenerProductoFault()
        {
            ProductoWSC.ProductoClient proxy = new ProductoWSC.ProductoClient();
            string codigobarra = "121212121212";
            string nombre = "";
            string tipo = "";
            try
            {
                ProductoWSC.EProducto productocreado = proxy.ObtenerProducto(codigobarra,nombre,tipo);
            }
            catch (FaultException<ProductoWSC.ProductoInexistente> error)
            {
                if (error.Detail.exCodigo == 1)
                    Assert.AreEqual("Para Buscar Nombre o Tipo, no debe registrar Codigo de Barras", error.Reason.ToString());
                if (error.Detail.exCodigo == 10) 
                    Assert.AreEqual("El producto No existe", error.Reason.ToString());
                if (error.Detail.exCodigo == 11)
                    Assert.AreEqual("El producto " + error.Detail.exProducto + " no cuenta con Stock disponible", error.Reason.ToString());
                if (error.Detail.exCodigo == 12)
                    Assert.AreEqual("El producto " + error.Detail.exProducto + " esta por agotarse", error.Reason.ToString());
                if (error.Detail.exCodigo == 13)
                    Assert.AreEqual("El producto " + error.Detail.exProducto + " esta Deshabilitado", error.Reason.ToString());
            }

        }
    }
}
