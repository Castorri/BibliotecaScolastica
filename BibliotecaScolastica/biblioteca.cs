using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class biblioteca
    {
        internal string Nome { get; set; }
        internal string Indirizzo { get; set; }
        internal string OrarioApertura { get; set; }
        internal string OrarioChiusura { get; set; }
        List<Libro> Libri = new List<Libro>();
        internal biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura, List<Libro> libri)
        {
            this.Nome = nome;
            this.Indirizzo = indirizzo;
            this.OrarioApertura = orarioApertura;
            this.OrarioChiusura = orarioChiusura;
            this.Libri = libri;
        }
        
    }
}
