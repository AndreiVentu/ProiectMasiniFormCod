using LibrarieModele;
using System;
using System.Collections;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareStudenti_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareStudenti_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddMasina(Masina s)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public ArrayList GetMasina()
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }

        public Masina GetMasina(string nume, string prenume)
        {
            throw new Exception("Optiunea GetStudent nu este implementata");
        }

        public bool UpdateMasini(Masina s)
        {
            throw new Exception("Optiunea UpdateStudent nu este implementata");
        }
    }
}
