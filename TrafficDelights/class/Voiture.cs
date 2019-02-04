// FILE: C:/Users/ANDRER_INFO/Desktop/M226/TrafficDelights/classes//Voiture.cs

// In this section you can add your own using directives
// section 10--122-97--48--d26d169:16894562a4a:-8000:0000000000000883 begin
// section 10--122-97--48--d26d169:16894562a4a:-8000:0000000000000883 end

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>
/// 
namespace TrafficDelights
{
    public class Voiture : Vehicule
    {
        // Attributes

        private int nbRoues;

        public int NbRoues { get => nbRoues; set => nbRoues = value; }

        public Voiture(int NBRoues)
        {
            this.NbRoues = NBRoues;
        }
    } /* end class Voiture */
}