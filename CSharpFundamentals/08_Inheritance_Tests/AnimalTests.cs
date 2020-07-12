using System;
using _08_Inheritance_Classes.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void CatTest()
        {
            Cat firstCat = new Cat();
            firstCat.Move();
            firstCat.MakeSounds();

            Liger oneLiger = new Liger();
            oneLiger.MakeSounds();
            oneLiger.Move();

         
        }
    }
}
