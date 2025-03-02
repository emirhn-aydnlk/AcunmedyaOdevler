using Odev_2.Abstracts;

GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Yazilimci pr = new Yazilimci();
Stajyer st = new Stajyer();

double toplamMaas = 0.0;

toplamMaas += gm.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += pr.maasinizNedir();
toplamMaas += st.maasinizNedir();

Console.WriteLine("Toplam Maaş: " + toplamMaas);