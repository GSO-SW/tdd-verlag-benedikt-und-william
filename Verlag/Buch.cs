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
        private string isbn;

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
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner 0 sein.");
                }
                else
                {
                    auflage = value;
                }
            }
        }

        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

        public Buch(string autor, string titel)
        {
            string[] unerlaubtesZeichen = { "", "#", ";", "§", "%" };
            for (int i = 0; i < unerlaubtesZeichen.Length; i++)
            {
                if (autor.Contains(unerlaubtesZeichen[i]))
                {
                    throw new ArgumentException("Unerlaubtes Zeichen im Autor vorhanden");
                }
                else
                {
                    this.autor = autor;
                    break;
                }

            }

            this.titel = titel;
            auflage = 1;
        }

        public string ISBN13
        {
            get
            {
                //TODO: ISBN13 aus ISBN berechnen
                return "irgendwas";
            }
        }


        public Buch(string autor, string titel, int auflage) : this(autor, titel)
        {
            if (auflage <= 0)
            {
                throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner 0 sein.");
            }
            else
            {
                this.auflage = auflage;
            }
        
        }
    }
}
