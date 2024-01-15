using espausa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace espausa
{ 
    
    class Banca
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 2 && value != null)
                {
                    nome = value;
                }
                else
                {
                    Console.WriteLine("nome non valido");
                }
            }
        }
        private bool chiu = false;
        public bool Chiu
        {
            get { return chiu; }
            set { chiu = value; }
        }
        private float saldo;
        public float Saldo
        {
            get { return saldo; }
            set
            {
                if (saldo >= 0)
                {
                    saldo = value;
                }
                else
                {
                    Console.WriteLine("Saldo minore di 0");
                }
            }
        }
        public Banca()
        {
            saldo = 0;
            chiu = false;
            nome = "";
        }
        public void ApriConto()
        {
            chiu = true;
            Console.WriteLine("Scrivi il nome del proprietario del conto: ");
            nome = Console.ReadLine(); ;
            Console.WriteLine("Conto aperto");
            Console.ReadLine();
        }
        public void ChiudiConto()
        {
            Console.WriteLine("Inserisci nome:");
            string nom = Console.ReadLine();
            if (nome == nom)
            {
                chiu = false;
                Console.WriteLine("Il conto è stato chiuso.");
                Console.WriteLine("Saldo da prelevare: " + saldo);
                saldo = 0;
                nome = "";
            }
            else
            {
                Console.WriteLine("Il nome non trovato");
                
            }
            Console.ReadLine();
        }
        public void DepositaSuConto()
        {
            Console.WriteLine("Inserisci nome:");
            string nom = Console.ReadLine();
            if (nome == nom)
            {
                Console.WriteLine("Inserisci soldi da depositare");
                int s = Convert.ToInt32(Console.ReadLine());
                saldo += s;
                Console.WriteLine("Il saldo corrente è: " + saldo);               
            }
            else
            {
                Console.WriteLine("Il nome non trovato");
            }
            Console.ReadLine();

        }
        public void PrelevaDaConto()
        {
            Console.WriteLine("Inserisci nome:");
            string nom = Console.ReadLine();
            if (nome == nom)
            {
                Console.WriteLine("Inserisci soldi da prelevare");
                int p = Convert.ToInt32(Console.ReadLine());
                saldo -= p;
                Console.WriteLine("Il saldo corrente è: " + saldo);
                
            }
            else
            {
                Console.WriteLine("Il nome non trovato");
                
            }
            Console.ReadLine();
        }
        public void VediSaldoConto()
        {
            Console.WriteLine("Inserisci nome:");
            string nom = Console.ReadLine();
            if (nome == nom)
            {
                Console.WriteLine("Saldo del conto: " + saldo);
            }
            else
            {
                Console.WriteLine("Il nome non trovato");
            }
            Console.ReadLine();
        }
        public void VediInfoConto()
        {
            Console.WriteLine("");
        }

    }
}
internal class Program
{
    static void Main(string[] args)
    { 
        Banca b = new Banca();
        bool m = true;
        while (m == true)
        {
            Console.WriteLine("1. Apri Contocorrente");
            Console.WriteLine("2. Chiudi Contocorrente");
            Console.WriteLine("3. Deposita soldi Contocorrente");
            Console.WriteLine("4. Preleva soldi su Contocorrente");
            Console.WriteLine("5. Vedi saldo Contocorrente");
            Console.WriteLine("6. Vedi info Contocorrente");
            Console.WriteLine("0. Esci");
            Console.WriteLine("Inserisci un'azione: ");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    b.ApriConto();
                    Console.Clear();
                    break;
                case "2":
                    b.ChiudiConto();
                    Console.Clear();
                    break;
                case "3":
                    b.DepositaSuConto();
                    Console.Clear();
                    break;
                case "4":
                    b.PrelevaDaConto();
                    Console.Clear();
                    break;
                case "5":
                    b.VediSaldoConto();
                    Console.Clear();
                    break;
                case "6":
                    b.VediInfoConto();
                    Console.Clear();
                    break;
                case "0":
                    Console.WriteLine("Uscita dal menu.");
                    Console.ReadLine();
                    m = false;
                    break;

            }
        }  
    }
}
