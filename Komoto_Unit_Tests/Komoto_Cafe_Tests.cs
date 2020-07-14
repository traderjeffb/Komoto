using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Komoto_Unit_Tests
{
    [TestClass]
    public class Komoto_Cafe_Tests
    {

        protected readonly List<Menu> _menu = new List<Menu>();
        [TestMethod]
        public void ShouldAddToMenu(Menu content)
        {
             int startingCount = _menu.Count;
            _menu.Add(content);
            bool wasAdded = (_menu.Count > startingCount) ? true : false;
            return wasAdded;
        }
    }
}
