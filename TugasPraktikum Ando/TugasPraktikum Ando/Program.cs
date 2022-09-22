using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum_Ando
{
    // Membuat Super Class Mobil
    class Mobil
    {
        // Membuat Propeties
        public string Merk, Tipe;
        public Ban ban;
        // Membuat Konstruktor
        public Mobil(string merk, string tipe, Ban ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban = ban;
        }
        // Membuat Metode
        public void NyalakanMesin()
        {
            Console.WriteLine("Mesin mobil " + Merk + " bertipe " + Tipe + " menyala");
        }
        public void MatikanMesin()
        {
            Console.WriteLine("Mesin mobil " + Merk + " bertipe " + Tipe + " mati");
        }

    }

    // Membuat class Ban
    class Ban
    {
        public string Merk;

        public Ban(string merk)
        {
            Merk = merk;
        }
    }

    // Membuat Sub class dari Ban yakni Michelin
    class Michelin:Ban
    {
        public Michelin(string merk):base(merk)
        {
            Merk = merk;
        }
    }

    // Membuat Sub Class dari Ban yakni Bridgestone
    class Bridgestone : Ban
    {
        public Bridgestone(string merk) : base(merk)
        {
            Merk = merk;
        }
    }

    // Membuat Sub Class Toyota
    class Toyota : Mobil
    {
        public Toyota(string merk, string tipe, Ban ban):base(merk, tipe, ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban = ban;
        }
    }

    // Membuat Class Agya
    class Agya : Toyota
    {
        public Agya(string merk, string tipe, Ban ban):base(merk, tipe, ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban = ban;
        }
    }

    // Class Innova
    class Innova:Toyota
    {
        public Innova(string merk, string tipe, Ban ban) : base(merk, tipe, ban)
        {
            Merk= merk;
            Tipe = tipe;
            this.ban = ban;
        }
    }

    // Class Avanza
    class Avanza : Toyota
    {
        public Avanza(string merk, string tipe, Ban ban):base(merk, tipe, ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban= ban;
        }

        public void NyalakanLampu()
        {
            Console.WriteLine("Lampu mobil " + Merk + " bertipe " + Tipe + " menyala");
        }
    }

    // Membuat Sub Class Daihatsu
    class Daihatsu : Mobil
    {
        public Daihatsu(string merk, string tipe, Ban ban) : base(merk, tipe, ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban = ban;
        }
    }

    // Membuat Class Ayla
    class Ayla : Daihatsu
    {
        public Ayla(string merk, string tipe, Ban ban):base(merk, tipe, ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban = ban;
        }
    }

    // Membuat Class Xenia
    class Xenia : Daihatsu
    {
        public Xenia(string merk, string tipe, Ban ban):base(merk, tipe, ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban = ban;
        }
    }

    // Membuat Sub Class Honda
    class Honda : Mobil
    {
        public Honda(string merk, string tipe, Ban ban) : base(merk, tipe, ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban = ban;
        }
    }

    // Membuat Class Brio
    class Brio : Honda
    {
        public Brio(string merk, string tipe, Ban ban) : base(merk, tipe, ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban = ban;
        }
    }

    // Membuat Class Civic
    class Civic : Honda
    {
        public Civic(string merk, string tipe, Ban ban) : base(merk, tipe, ban)
        {
            Merk = merk;
            Tipe = tipe;
            this.ban = ban;
        }

        public void VtecKickedIn()
        {
            Console.WriteLine("Ngeeeng Wooosh!!!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Mobil mobil1 = new Agya("Toyota", "Agya", new Ban("Michelin"));
            Console.WriteLine("Merek Mobil\t: " + mobil1.Merk + "\nTipe\t\t: " + mobil1.Tipe + "\nMerek Ban\t: " + mobil1.ban.Merk);
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();

            Mobil mobil2 = new Avanza("Toyota", "Avanza", new Ban("Bridgestone"));
            Console.WriteLine("\nMerek Mobil\t: " + mobil2.Merk + "\nTipe\t\t: " + mobil2.Tipe + "\nMerek Ban\t: " + mobil2.ban.Merk);
            mobil2.NyalakanLampu(); // Error

            Civic civic1 = new Civic("Honda", "Civic", new Ban("Bridgestone"));
            Console.WriteLine("\nMerek Mobil\t: " + civic1.Merk + "\nTipe\t\t: " + civic1.Tipe + "\nMerek Ban\t: " + civic1.ban.Merk);
            civic1.VtecKickedIn();

            Honda honda1 = new Civic("Honda", "Brio", new Ban("Michelin");
            honda1.VtecKickedIn(); // Error

        }
    }
}
