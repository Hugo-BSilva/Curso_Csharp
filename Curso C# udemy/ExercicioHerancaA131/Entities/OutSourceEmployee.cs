namespace ExHerancaA131.Entities
{   //Funcionário terceirizado
    class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourceEmployee() 
        {
        }

        public OutSourceEmployee(string name, int hours, double valuePerHours, double additionalCharge) 
            : base(name,hours,valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + ((AdditionalCharge * 110)/100);
        }
    }
}
