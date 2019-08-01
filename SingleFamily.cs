namespace HousingApplication
{
    public class SingleFamily : Housing
    {
        public decimal RentAmount { get; set; }
        public int SizeInSquareFeet { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public bool IsPorchAvailable { get; set; }
        public bool IsGarageAvailable { get; set; }
        public SingleFamily(string address, string typeOfConstruction, int yearBuilt, decimal rentAmount, int sizeInSquareFeet, int numberOfBedrooms, int numberOfBathrooms, bool isPorchAvailable, bool isGarageAvailable) : base(address, typeOfConstruction, yearBuilt)
        {
            Address = address;
            TypeOfConstruction = typeOfConstruction;
            YearBuilt = yearBuilt;
            RentAmount = rentAmount;
            SizeInSquareFeet = sizeInSquareFeet;
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfBathrooms = numberOfBathrooms;
            IsPorchAvailable = isPorchAvailable;
            IsGarageAvailable = isGarageAvailable;
        }
        public override decimal ProjectedRentalAmt()
        {
            return RentAmount * 12;
        }
        public override string ToString()
        {
            return $"Address {Address} \nType of constuction {TypeOfConstruction} \nYear Built {YearBuilt} \nRent amount {RentAmount} \nSize in square feet {SizeInSquareFeet} \nNumber of bedrooms {NumberOfBedrooms} \nNumber of bathrooms {NumberOfBathrooms} \nIs porch available {IsPorchAvailable} \nIs garage available {IsGarageAvailable} \nProjected rental amount {ProjectedRentalAmt().ToString("C")}";
        }
    }
}
