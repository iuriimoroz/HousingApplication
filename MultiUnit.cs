namespace HousingApplication
{
    public class MultiUnit : Housing, IUnits
    {
        public string ComplexName { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal RentalAmountPerUnit { get; set; }
        public MultiUnit(string address, string typeOfConstruction, int yearBuilt, string complexName, int numberOfUnitsAvailable, decimal rentalAmountPerUnit) : base(address, typeOfConstruction, yearBuilt)
        {
            Address = address;
            TypeOfConstruction = typeOfConstruction;
            YearBuilt = yearBuilt;
            ComplexName = complexName;
            NumberOfUnits = numberOfUnitsAvailable;
            RentalAmountPerUnit = rentalAmountPerUnit;
        }
        public int GetNumUnits()
        {
            return NumberOfUnits;
        }
        public override decimal ProjectedRentalAmt()
        {
            return RentalAmountPerUnit * NumberOfUnits * 12;
        }
        public override string ToString()
        {
            return $"Address {Address} \nType of constuction {TypeOfConstruction} \nYear Built {YearBuilt} \nComplex name {ComplexName} \nNumber of units {NumberOfUnits} \nRental amount per unit {RentalAmountPerUnit} \nProjected rental amount {ProjectedRentalAmt().ToString("C")}";
        }
    }
}
