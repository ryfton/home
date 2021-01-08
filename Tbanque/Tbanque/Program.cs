
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace TPbanque
    {
        class Program
        {

            static void Main(string[] args)
            {
                string e = Encoding.Default.GetString(new Byte[] { 128 });
                Console.OutputEncoding = Encoding.Default;
                 Compte Tournesol = new Compte("123456", "Tryphon", 4000, -5000);
                 Compte Haddock = new Compte("567891", "Archibald", 1000, -500);
                 Compte technique = new Compte();
                  //affichage comptes;

                 Console.WriteLine(Tournesol.ToString());
                 Console.WriteLine(Haddock );
                 Console.WriteLine(technique);
                 Haddock.Crediter(500);

                 Console.WriteLine("---------------------------------");

                 Console.WriteLine(Haddock);

                 if (Haddock.Debiter(3000) ==false)
                 {
                     Console.WriteLine("debit impossible solde insuffisant!! ");

                 }
                 else
                 {
                     Console.WriteLine("Débit autorisé");
                    Console.WriteLine( "------------------\n"+Haddock);

                 }
                 if (Haddock.Debiter(2000) == false)
                 {
                     Console.WriteLine("debit impossible solde insuffisant!! ");

                 }
                 else
                 {
                     Console.WriteLine("Débit autorisé");
                     Console.WriteLine("------------------\n" + Haddock);

                 }

                 ;

                 Haddock.Crediter(12000);
                 Tournesol.Crediter(1500);
                 if (Haddock.Transferer(2000, Tournesol) == false)
                 {
                     Console.WriteLine("transfert impossible solde insuffisant!! ");

                 }
                 else
                 {
                     Console.WriteLine("transfert autorisé");
                     Console.WriteLine("------------------\n" + Haddock +"\n"+Tournesol);

                 }

                 if (Haddock.Superieur(Tournesol)==1)
                 {
                     Console.WriteLine("le solde de Haddock est supérieur!!");
                 }
                 else if (Haddock.Superieur(Tournesol) == 0)
                 {
                     Console.WriteLine("le solde de Haddock est  le même que celui de Tournesol!!");
                 }
                 else
                 {
                     Console.WriteLine("le solde de Tounesol est supérieur!!");
                 }

                Banque BNP = new Banque("BNP", "Mulhouse");
                BNP.init();
                Console.WriteLine(BNP.ToString());

                Compte test = BNP.RendCompte("101224");
                Console.WriteLine(test);
                bool VirOK = BNP.Virement("678910", "101214", 150000);

                Console.WriteLine(BNP);
                Console.ReadKey();
            }
        }
    }
}
    

