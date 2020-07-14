using Microsoft.CodeAnalysis;

namespace webook.domain.proprietes.Domain
{
    public class Adresse
    {
        /// <summary>
        /// Nom de la Rue Complete
        /// </summary>
        public string Rue { get; set; }
        /// <summary>
        ///  Nom de la Ville
        /// </summary>
        public string Ville { get; set; }
        /// <summary>
        /// Code postal 
        /// </summary>
        public string CodePostal { get; set; }

        /// <summary>
        /// Code du Pays 
        /// @see Etat
        /// </summary>
        public int Pays { get; set; }

        /// <summary>
        /// Coordonnées GPS de la location
        /// </summary>
        public Location Position{ get; set; }

    }
}
