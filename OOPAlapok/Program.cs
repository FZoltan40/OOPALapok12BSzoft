using System;
using System.Collections.Generic;

namespace OOPAlapok
{
    public class Szemely
    {
        protected string _nev;
        protected int _kor;

        public Szemely(string nev, int kor)
        {
            _nev = nev;
            _kor = kor;
        }

        public string Nev
        {
            get { return _nev; }
            //set { _nev = value; }
        }

        public int Kor
        {
            get { return _kor; }
            set
            {
                if (value >= 0)
                    _kor = value;
                else
                    Console.WriteLine("Hibás érték.");

            }
        }

        public override string ToString()
        {
            return $"A tanuló neve {_nev} életkora {_kor}";
        }

    }

    class BankSzamla
    {
        private int _egyenleg;

        public int Egyenleg
        {
            set
            {
                if (value >= 0)
                {
                    _egyenleg = value;
                }
                else
                {
                    Console.WriteLine("Az egyenleg nem lehet kisebb 0-nál.");
                }
            }
        }
        public void Betesz()
        {

        }

        public void Kivesz()
        {

        }
    }

    class Hallgato : Szemely
    {
        private string _neptunkod;

        public string Neptunkod
        {
            get { return _neptunkod; }
            set
            {
                if (value.Length <= 6)
                    _neptunkod = value;
            }
        }
        public Hallgato(string nev, int kor) : base(nev, kor)
        {

        }
    }

    class Dolgozo : Szemely
    {
        private int _ber;

        public Dolgozo(string nev, int kor, int ber) : base(nev, kor)
        {
            _ber = ber;
        }

        public override string ToString()
        {
            return $"{Nev} {Kor} {_ber}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Kiss Ilona", 34);

            Console.WriteLine(tanulo1);
            //Console.WriteLine(tanulo1.Nev + tanulo1.Kor);

            List<Hallgato> hallgatoLista = new List<Hallgato>();

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. nevet:");
                string nev = Console.ReadLine();
                Console.Write($"Kérem a(z) {i + 1}. tanuló életkorát:");
                int kor = int.Parse(Console.ReadLine());
                Hallgato tanulo = new Hallgato(nev, kor);
                Console.Write($"Kérem a(z) {i + 1}. tanuló neptunkódját:");
                string neptunkod = Console.ReadLine();
                tanulo.Neptunkod = neptunkod;

                hallgatoLista.Add(tanulo);
            }

            foreach (var item in hallgatoLista)
            {
                Console.WriteLine($"{item.Nev} {item.Kor} {item.Neptunkod}");
            }

            Dolgozo dolgozo1 = new Dolgozo("Lapos Elemér", 43, 7500);
            Console.WriteLine(dolgozo1);
        }
    }
}
