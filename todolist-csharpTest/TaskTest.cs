using Microsoft.VisualStudio.TestTools.UnitTesting;
using JHashimoto.Todolist.RegisterTask;
using System;

namespace todolist_csharpTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void IsExpired () {
            var limit = DateTime.Today.AddDays(1);
            var task = new Task(limit);
            var actual = task.IsExpired;
            var expected = false;

            Assert.AreEqual(expected, actual);
         }
    }
}