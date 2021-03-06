// FILE: C:/Users/ANDRER_INFO/Desktop/M226/TrafficDelights/classes//Moto.cs

// In this section you can add your own using directives
// section 10--122-97--48--d26d169:16894562a4a:-8000:0000000000000884 begin
// section 10--122-97--48--d26d169:16894562a4a:-8000:0000000000000884 end

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>
/// 
namespace TrafficDelights
{
    public class Moto : Vehicule
    {
        // Attributes

        private int nbRoues;

        public int NbRoues { get => nbRoues; set => nbRoues = value; }

        public Moto() : this("Ducati", "Rouge", 2, 2)
        {
            //do nothing
        }
        public Moto(string pMarque, string pCouleur, int pNbPlaces, int pNbRoues)
        {
            this.Marque = pMarque;
            this.Couleur = pCouleur;
            this.NbPlaces = pNbPlaces;
            this.NbRoues = pNbRoues;
        }

    } /* end class Moto */
}