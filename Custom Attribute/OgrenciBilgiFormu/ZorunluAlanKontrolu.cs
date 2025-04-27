using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiFormu
{
    public static class ZorunluAlanKontrolu
    {
        public static List<string> bosAlanlar = new List<string>(); // Bos alanlar icin liste olustrdm

        public static bool Dogrula(object dogrulanacakObje)
        {
            bosAlanlar.Clear(); 
            Type dogrulanacakTur = dogrulanacakObje.GetType();
            FieldInfo[] dogrulanacakTurAlanlari = dogrulanacakTur.GetFields(
                                                   BindingFlags.Public |
                                                   BindingFlags.Instance);

            foreach (FieldInfo dogrulanacakTurAlani in dogrulanacakTurAlanlari)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakTurAlani.GetCustomAttributes(typeof(ZorunluAlanAttribute), true);
                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    string alanDegeri = dogrulanacakTurAlani.GetValue(dogrulanacakObje) as string;
                    if (string.IsNullOrEmpty(alanDegeri))
                    {
                        bosAlanlar.Add(dogrulanacakTurAlani.Name); // Bos alanın name'ini listeye ekledim
                    }
                }
            }
            return bosAlanlar.Count == 0; // liste bos olursa dogrulama tamam
        }
    }
}
