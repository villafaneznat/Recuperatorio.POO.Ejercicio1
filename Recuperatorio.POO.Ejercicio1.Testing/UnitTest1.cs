using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Recuperatorio.POO.Ejercicio1.Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAlturaTest()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto();
            Assert.AreEqual(prisma.GetAltura(), 1);

        }
        [TestMethod]
        public void GetAnchoTest()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto();
            Assert.AreEqual(prisma.GetAncho(), 1);

        }
        [TestMethod]
        public void GetLargoTest()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto();
            Assert.AreEqual(prisma.GetLargo(), 1);
        }
        [TestMethod]
        public void GetAreaTest()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto();
            Assert.AreEqual(prisma.GetArea(), 4);

        }
        [TestMethod]
        public void GetVolumenTest()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto();
            Assert.AreEqual(prisma.GetVolumen(), 1);

        }
        [TestMethod]
        public void GetDiagonalTest()
        {
            PrismaRectangularRecto prisma = new PrismaRectangularRecto();
            Assert.AreEqual(prisma.GetDiagonal(), 1.7320508075688772);

        }





    }
}