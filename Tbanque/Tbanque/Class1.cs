using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPbanque
{

    public class Compte
    {
        string e = Encoding.Default.GetString(new Byte[] { 128 });


        //attributs

        private int decouvertAutorise;
        private string nomCompte;
        private string numeroCompte;
        protected double soldeCompte;

        // propriétés 
        public int Decouvert
        {
            get
            {
                return decouvertAutorise;
            }

            set
            {
                decouvertAutorise = value;
            }
        }

        public string GetNom
        {
            get
            {
                return nomCompte;
            }

        }

        public string GetNumero
        {
            get
            {
                return numeroCompte;
            }

        }

        public double SoldeCompte
        {

            get
            {
                return this.soldeCompte;
            }

            set
            {
                this.soldeCompte = value;
            }

        }



        ~Compte()
        {
            Console.WriteLine("haaa le Compte se  détruit !!!");

        }

        /// 
        /// <param name="_Numero"></param>
        /// <param name="_NomCompte"></param>
        /// <param name="_SoldeCompte"></param>
        /// <param name="_DecouvertAutorise"></param>
        /// 
        public Compte(string _numero, string _nomCompte, double _soldeCompte, int _decouvertAutorise)
        {
            this.numeroCompte = _numero;
            this.nomCompte = _nomCompte;
            this.soldeCompte = _soldeCompte;
            this.decouvertAutorise = _decouvertAutorise;
        }

        public Compte()
        {
            Random aleas = new Random();
            this.numeroCompte = Convert.ToString(aleas.Next(100000, 1000000));
            this.nomCompte = "sans nom";
            this.soldeCompte = 0;
            this.decouvertAutorise = 0;
        }

        /// 
        /// <param name="_montant"></param>
        public void Crediter(double _montant)
        {
            SoldeCompte += _montant;
        }

        /// 
        /// <param name="_montant"></param>
        public bool Debiter(double _montant)
        {
            if ((SoldeCompte - _montant) < Decouvert)
            {
                //this.Crediter(_montant);
                //SoldeCompte += _montant;
                return false;
            }
            else
            {
                SoldeCompte -= _montant;
                return true;
            }

        }


        /// 


        /// 
        /// <param name="_AutreCompte"></param>
        public int Superieur(Compte _AutreCompte)
        {
            int result;
            if (SoldeCompte > _AutreCompte.SoldeCompte)
            {
                result = 1;
            }
            else if (SoldeCompte == _AutreCompte.SoldeCompte)
            {
                result = 0;
            }
            else
            {
                result = -1;
            }
            return result;
        }

        /// 
        /// <param name="UnCompte"></param>
        /// 
        public override string ToString()
        {
            return "Compte n°:" + this.GetNumero + " appartenant à : " + GetNom + "  ayant pour solde " + SoldeCompte + e + " Euros  avec un decouvert de:" + Decouvert + e;
        }


        /// 
        /// <param name="_Montant"></param>
        /// <param name="_Beneficiaire"></param>


        public bool Transferer(double _Montant, Compte _Beneficiaire)
        {
            bool transfertOk;
            if (this.Debiter(_Montant) == false)
            {
                transfertOk = false;

            }
            else
            {
                this.Debiter(_Montant);
                _Beneficiaire.Crediter(_Montant);
                transfertOk = true;

            }
            return transfertOk;
        }



    }//end Compte
}