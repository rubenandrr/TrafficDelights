// FILE: C:/Users/ANDRER_INFO/Desktop/M226/TrafficDelights/classes//Camion.cs

// In this section you can add your own using directives
// section 10--122-97--48--d26d169:16894562a4a:-8000:0000000000000881 begin
// section 10--122-97--48--d26d169:16894562a4a:-8000:0000000000000881 end

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>
/// 
namespace TrafficDelights
{
    public class Camion : Vehicule
    {
        // Attributes

        private int nbRoues;

       

        public int NbRoues { get => nbRoues; set => nbRoues = value; }

        public Camion() : this(6, "Bentley", "Noir", 3)
        {
            //do nothing
        }

        public Camion(int pNbRoues, string pMarque, string pCouleur, int pNbPlaces)
        {
            this.NbRoues = pNbRoues;
            this.Marque = pMarque;
            this.Couleur = pCouleur;
            this.NbPlaces = pNbPlaces;
        }
    } /* end class Camion */
}
