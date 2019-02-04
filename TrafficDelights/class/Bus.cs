// FILE: C:/Users/ANDRER_INFO/Desktop/M226/TrafficDelights/classes//Bus.cs

// In this section you can add your own using directives
// section 10--122-97--48--d26d169:16894562a4a:-8000:0000000000000882 begin
// section 10--122-97--48--d26d169:16894562a4a:-8000:0000000000000882 end

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>
/// 
namespace TrafficDelights
{
    public class Bus : Vehicule
    {
        // Attributes

        private int nbRoues;

        private string depart;

        private string arrive;

        private int numeroBus;

        public int NbRoues { get => nbRoues; set => nbRoues = value; }
        public string Depart { get => depart; set => depart = value; }
        public string Arrive { get => arrive; set => arrive = value; }
        public int NumeroBus { get => numeroBus; set => numeroBus = value; }

        public Bus() : this(6, "Aéroport", "Rive", 10)
        {
            //do nothing
        }

        public Bus(int pNbRoues, string pDepart, string pArrive, int pNumeroBus)
        {
            this.NbRoues = pNbRoues;
            this.Depart = pDepart;
            this.Arrive = pArrive;
            this.NumeroBus = pNumeroBus;
        }
    } /* end class Bus */
}