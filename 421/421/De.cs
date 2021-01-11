using System;
using System.Collections.Generic;
using System.Text;

namespace _421
{
    class De1 : De
    {
        public event EventHandler lancerDe;

        public MancheCourante MancheCourante
        {
            get => default;
            set
            {
            }
        }
    }

    public class De
    {
        public De()
        {

        }

        public int Valeur
        {
            get => default;
            
        }

        public void Jeter()
        {

        }
    }
}
