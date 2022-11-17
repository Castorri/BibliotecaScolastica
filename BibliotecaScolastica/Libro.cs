using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Libro
    {
        internal string Autore { get; set; }
        internal string Titolo { get; set; }
        internal int AnnoPubblicazione  { get; set; }
        internal string Editore { get; set; }
        internal int NPagine { get; set; }

        internal Libro (string autore, string titolo, int annoPubblicazione, string editore, int nPagine)
        {
            this.Autore = autore;
            this.Titolo = titolo;
            this.AnnoPubblicazione = annoPubblicazione;
            this.Editore = editore;
            this.NPagine = nPagine;
        }
    }
}
