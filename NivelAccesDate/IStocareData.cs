using LibrarieModele;
using System.Collections;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddMasina(Masina s);
        ArrayList GetMasina();

        Masina GetMasina(string nume, string prenume);

        bool UpdateMasini(Masina s);
    }
}
