namespace HousingApplication
{
    public class Housing
    {
        public string Address { get; set; }
        public string TypeOfConstruction { get; set; }
        public int YearBuilt { get; set; }

        public Housing (string address, string typeOfConstruction, int yearBuilt)
        {
            Address = address;
            TypeOfConstruction = typeOfConstruction;
            YearBuilt = YearBuilt;
        }

        public virtual decimal ProjectedRentalAmt()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"Address {Address} \nType of constuction {TypeOfConstruction} \nYear Built {YearBuilt}";
        }
    }
}
