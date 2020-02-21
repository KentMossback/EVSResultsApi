using System;
using EVSResultsApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EVSResultApiTest
{
    [TestClass]
    public class RepoTest
    {
        [TestMethod]
        public void ShouldCreateNewTeam()
        {
            //var options = new DbContextOptionsBuilder<SQLiteDBContext>()
            //    .UseMemoryCache()
            //    .Options;

            //using (var context = new PxLoadContext(options))
            //{
            //    var repo = new PxLoadStatusRepository(context);
            //    var result = repo.CreateLoadStatus("SSD", "TestTable", "SCBTEST", Guid.NewGuid());
            //    Assert.AreEqual("TestTable", result.MainTable);
            //}


        }
    }
}
