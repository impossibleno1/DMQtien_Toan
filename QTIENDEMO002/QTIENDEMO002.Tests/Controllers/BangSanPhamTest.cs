using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QTIENDEMO002.Controllers;
using System.Linq;
using System.Web.Mvc;
using QTIENDEMO002.Models;
using System.Collections.Generic;

namespace QTIENDEMO002.Tests.Controllers
{
    [TestClass]
    public class BangSanPhamTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new BangSanPhamController();
            var result = controller.Index() as ViewResult;
            var db = new CS4PEEntities();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model, typeof(List<BangSanPham>));
            Assert.AreEqual(db.BangSanPhams.Count(), ((List<BangSanPham>)result.Model).Count);
        }
    }
}
