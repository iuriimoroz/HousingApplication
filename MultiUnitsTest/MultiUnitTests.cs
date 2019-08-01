using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HousingApplication;
using System.Collections.Generic;

namespace MultiUnitsTest
{
    [TestClass]
    public class MultiUnitsTest
    {
        [TestMethod]
        public void Tests()
        {
            MultiUnit multiUnit1 = new MultiUnit("445 Mount Eden Road, Mount Eden, Auckland.", "Building", 1988, "Complex name 1", 6, 850);
            MultiUnit multiUnit2 = new MultiUnit("446 Mount Eden Road, Mount Eden, Auckland.", "Building", 1955, "Complex name 2", 4, 650);
            MultiUnit multiUnit3 = new MultiUnit("447 Mount Eden Road, Mount Eden, Auckland.", "Building", 1942, "Complex name 3", 5, 350);
            MultiUnit multiUnit4 = new MultiUnit("448 Mount Eden Road, Mount Eden, Auckland.", "Building", 1988, "Complex name 4", 2, 2000);
            MultiUnit multiUnit5 = new MultiUnit("449 Mount Eden Road, Mount Eden, Auckland.", "Building", 1999, "Complex name 5", 5, 100);


            List<MultiUnit> multiUnits = new List<MultiUnit>();
            multiUnits.Add(multiUnit1);
            multiUnits.Add(multiUnit2);
            multiUnits.Add(multiUnit3);
            multiUnits.Add(multiUnit4);
            multiUnits.Add(multiUnit5);

            foreach (var item in multiUnits)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}
