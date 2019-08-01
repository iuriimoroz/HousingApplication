using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HousingApplication;
using System.Collections.Generic;

namespace SingleFamilyTest
{
    [TestClass]
    public class SingleFamilyTest
    {
        [TestMethod]
        public void Tests()
        {
            SingleFamily singleFamily1 = new SingleFamily("445 Mount Eden Road, Mount Eden, Auckland.", "Building", 1988, 850, 500, 2, 1, true, false);
            SingleFamily singleFamily2 = new SingleFamily("446 Mount Eden Road, Mount Eden, Auckland.", "Apartment", 1987, 300, 600, 2, 1, false, false);
            SingleFamily singleFamily3 = new SingleFamily("447 Mount Eden Road, Mount Eden, Auckland.", "Building", 1986, 1250, 125, 2, 1, true, false);
            SingleFamily singleFamily4 = new SingleFamily("448 Mount Eden Road, Mount Eden, Auckland.", "Building", 1986, 1000, 5000, 2, 1, true, true);
            SingleFamily singleFamily5 = new SingleFamily("449 Mount Eden Road, Mount Eden, Auckland.", "Building", 1988, 870, 500, 2, 1, true, false);

            List<SingleFamily> families = new List<SingleFamily>();
            families.Add(singleFamily1);
            families.Add(singleFamily2);
            families.Add(singleFamily3);
            families.Add(singleFamily4);
            families.Add(singleFamily5);

            foreach (var item in families)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}
