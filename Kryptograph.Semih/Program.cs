using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace Tabelle_test
{
    public struct Tabelle
    {
        public string Buchstaben;
        public double prozent;
    }
    public static class Tabel
    {
        public static Tabelle[] getTable(string datei)
        {
            List<Tabelle> liste = new List<Tabelle>();
            string[] zeilen = File.ReadAllLines(datei);

            foreach (string zeile in zeilen)
            {
                string[] data = zeile.Split(';');
                Tabelle a;
                a.Buchstaben = data[0];
                double.TryParse(data[1], out a.prozent);

                liste.Add(a);
            }
            return liste.ToArray();
        }
    }
}
