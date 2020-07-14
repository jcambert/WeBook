using System.Linq;

namespace webook.domain
{
    /// <summary>
    /// @see https://fr.wikipedia.org/wiki/ISO_3166
    /// @see https://fr.wikipedia.org/wiki/ISO_4217
    /// Cette norme définit des codes pour la quasi-totalité des pays du monde,
    /// y compris pour certains territoires (îles en général), non habités de façon permanente. 
    /// Chacune de ces entités reçoit ainsi un code à deux lettres, 
    /// un code à trois lettres et un code numérique
    /// </summary>
    public readonly partial struct Etat
    {
        public Etat(string nom, string alpha2, string alpha3, int codePays,string nomDevise,string devise,int codeDevise)
        => (Nom,Alpha2,Alpha3,CodePays,NomDevise,Devise,CodeDevise) = (nom,alpha2,alpha3,codePays,nomDevise,devise,codeDevise);
        /// <summary>
        /// Nom de l'etat
        /// </summary>
        public readonly string Nom { get;  }
        /// <summary>
        /// Code Alpha2
        /// </summary>
        public readonly string Alpha2 { get;  }
        /// <summary>
        /// Code Alpha3
        /// </summary>
        public readonly string Alpha3{ get;  }
        /// <summary>
        /// Code du pays selon ISO3166
        /// </summary>
        public readonly int CodePays { get;  }
        /// <summary>
        /// Nom de la devise
        /// </summary>
        public readonly string NomDevise { get;  }
        /// <summary>
        /// Devise
        /// </summary>
        public readonly string  Devise { get;  }
        /// <summary>
        /// Code de la devise selon ISO4217
        /// </summary>
        public readonly int CodeDevise { get;  }

        /// <summary>
        /// Retourne un etat selon son code Alpha2
        /// </summary>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static Etat Find(string a2)=> Etats.Where(e => e.Alpha2 == a2).FirstOrDefault();

        /// <summary>
        /// Retourne un etat selon son code
        /// </summary>
        /// <param name="code">Code selon ISO3166</param>
        /// <returns></returns>
        public static Etat Find(int code) => Etats.Where(e => e.CodePays == code).FirstOrDefault();

    }

    
}
