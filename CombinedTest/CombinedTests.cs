using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HousingApplication;
using System.Collections.Generic;

namespace CombinedTest
{
    [TestClass]
    public class CombinedTest
    {
        [TestMethod]
        public void Tests()
        {
            SingleFamily singleFamily1 = new SingleFamily("445 Mount Eden Road, Mount Eden, Auckland.", "Building", 1988, 850, 500, 2, 1, true, false);
            SingleFamily singleFamily2 = new SingleFamily("446 Mount Eden Road, Mount Eden, Auckland.", "Apartment", 1987, 300, 600, 2, 1, false, false);
            SingleFamily singleFamily3 = new SingleFamily("447 Mount Eden Road, Mount Eden, Auckland.", "Building", 1986, 1250, 125, 2, 1, true, false);
            SingleFamily singleFamily4 = new SingleFamily("448 Mount Eden Road, Mount Eden, Auckland.", "Building", 1986, 1000, 5000, 2, 1, true, true);
            SingleFamily singleFamily5 = new SingleFamily("449 Mount Eden Road, Mount Eden, Auckland.", "Building", 1988, 870, 500, 2, 1, true, false);

            MultiUnit multiUnit1 = new MultiUnit("445 Mount Eden Road, Mount Eden, Auckland.", "Building", 1988, "Complex name 1", 6, 850);
            MultiUnit multiUnit2 = new MultiUnit("446 Mount Eden Road, Mount Eden, Auckland.", "Building", 1955, "Complex name 2", 4, 650);
            MultiUnit multiUnit3 = new MultiUnit("447 Mount Eden Road, Mount Eden, Auckland.", "Building", 1942, "Complex name 3", 5, 350);
            MultiUnit multiUnit4 = new MultiUnit("448 Mount Eden Road, Mount Eden, Auckland.", "Building", 1988, "Complex name 4", 2, 2000);
            MultiUnit multiUnit5 = new MultiUnit("449 Mount Eden Road, Mount Eden, Auckland.", "Building", 1999, "Complex name 5", 5, 100);

            List<Housing> housings = new List<Housing>();
            housings.Add(singleFamily1);
            housings.Add(singleFamily2);
            housings.Add(singleFamily3);
            housings.Add(singleFamily4);
            housings.Add(singleFamily5);
            housings.Add(multiUnit1);
            housings.Add(multiUnit2);
            housings.Add(multiUnit3);
            housings.Add(multiUnit4);
            housings.Add(multiUnit5);

            foreach (var item in housings)
            {
                Console.WriteLine(item.Address);
                Console.WriteLine(item.ProjectedRentalAmt().ToString("C"));
                Console.WriteLine();
            }
        }
    }
}
