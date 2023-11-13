using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }

        public string Titel
        {
            get
            {
                return titel;
            }
        }

        public int Auflage
        {
            get
            {
                return auflage;
            }
            set
            {
                
                 auflage = value;
                            
            }
        }

        public Buch(string autor, string titel)
        {
            this.autor = autor;
            this.titel = titel;
        }


        public Buch(string autor, string titel, int auflage) : this(autor, titel)
        {
            if (auflage <= 0)
            {
                throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner 0 sein.");
            } else {
                this.auflage = auflage;
            }
        
        }
    }
}
