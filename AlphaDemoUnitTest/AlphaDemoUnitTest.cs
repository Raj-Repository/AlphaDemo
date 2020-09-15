using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlphaDemo.Database;
using System.Linq;
using AlphaDemo.Database.InitialData;

namespace AlphaDemoUnitTest
{
    [TestClass]
    public class AlphaDemoUnitTest
    {
        [TestMethod]
        public void LoadDataInitializeWithOutDataTest()
        {
            DatabaseContext db = new DatabaseContext();
            var all = from c in db.SampleData select c;
            db.SampleData.RemoveRange(all);
            db.SaveChanges();
            int rowCount = LoadData.Initialize(db);
            Assert.AreEqual(rowCount, 100);
        }

        [TestMethod]
        public void LoadDataInitializeWithDataTest()
        {
            DatabaseContext db = new DatabaseContext();
            int actualCount = db.SampleData.ToList().Count;
            int rowCount = LoadData.Initialize(db);
            Assert.AreEqual(rowCount, actualCount);
        }
    }
}
