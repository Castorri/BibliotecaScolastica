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

        public Libro aggiuntaLibro(string autore, string titolo, int annoPubblicazione, string editore, int nPagine)
        {
            return new Libro(autore, titolo, annoPubblicazione, editore, nPagine);
        }
        internal string ricercaLibroTitolo(List<Libro> libri, string titolo)
        {
            for (int i = 0; i < libri.Count; i++)
            {
                if (libri[i].Titolo == titolo)
                {
                    return libri[i].ToString();
                }
            }
            return titolo + " non trovato";
        }
        internal string ricercaLibroAutore(List<Libro> libri, string autore)
        {
            List<Libro> libriTrovati = new List<Libro>();
            for (int i = 0; i < libri.Count; i++)
            {
                if (libri[i].Autore == autore)
                {
                    libriTrovati.Add(libri[i]);
                }
            }
            if (libriTrovati.Count > 0)
            {
                return libriTrovati.ToString();
            }
            else
            {
                return "non esistono libri scritti da " + autore;
            }
        }
        internal string determinazioneLibriPresenti(List<Libro> libri)
        {
            return "ci sono " + libri.Count + " libri";
        }
        public override string ToString()
        {
            return "titolo: " + Titolo + "\nautore: " + Autore + "\neditore: " + Editore + "\nanno di pubblicazione: " + AnnoPubblicazione + "\nnumero di pagine: " + NPagine + '\n';
        }
        internal string readingTime(Libro libro)
        {
            if (libro.NPagine <= 100)
            {
                return "tempo di lettura: 1h";
            }
            else if (libro.NPagine <= 200)
            {
                return "tempo di lettura: 2h";
            }
            else
            {
                return "tempo di lettura: superiore a 2h";
            }
        }
    }
}
