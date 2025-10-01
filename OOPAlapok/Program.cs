using System;

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
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Kiss Ilona", 34);

            Console.WriteLine(tanulo1);
            //Console.WriteLine(tanulo1.Nev + tanulo1.Kor);
        }
    }
}
