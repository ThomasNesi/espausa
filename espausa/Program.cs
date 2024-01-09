using espausa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace espausa
{
    class persona
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
        public persona(string nome)
        {
            this.nome = "";
        }
    }
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
            this.saldo = 0;
            this.chiu = false;
            Nome = "";
        }
        public void ApriConto()
        {
            chiu = true;
            Console.WriteLine("Scrivi il nome del proprietario del conto: ");
            string N = Console.ReadLine();
            Nome = N;
            Console.WriteLine("Conto aperto");
            Console.ReadLine();
        }
        public void ChiudiConto()
        {
            Console.WriteLine("Inserisci nome:");
            string nome = Console.ReadLine();
            if (Nome == nome)
            {
                chiu = false;
                Console.WriteLine("Il conto è stato chiuso.");
                Console.WriteLine("Saldo da prelevare: " + saldo);
                saldo = 0;
                Console.WriteLine("Conto chiuso");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Il nome non trovato");
            }

        }
        public void DepositaSuConto()
        {
            Console.WriteLine("Inserisci nome:");
            string nome = Console.ReadLine();
            if (Nome == nome)
            {
                Console.WriteLine("Inserisci soldi da depositare");
                int s = Convert.ToInt32(Console.ReadLine());
                saldo += s;
                Console.WriteLine("Il saldo corrente è: " + saldo);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Il nome non trovato");
            }
      

        }
        public void PrelevaDaConto()
        {
            Console.WriteLine("Inserisci nome:");
            string nome = Console.ReadLine();
            if (Nome == nome)
            {
                Console.WriteLine("Inserisci soldi da prelevare");
                int p = Convert.ToInt32(Console.ReadLine());
                saldo -= p;
                Console.WriteLine("Il saldo corrente è: " + saldo);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Il nome non trovato");
            }
        }
        public void VediSaldoConto()
        {
            Console.WriteLine("Inserisci nome:");
            string nome = Console.ReadLine();
            if (Nome == nome)
            {
                Console.WriteLine("Saldo del conto: " + saldo);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Il nome non trovato");
            }
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
        Console.WriteLine("1. Apri Contocorrente");
        Console.WriteLine("2. Chiudi Contocorrente");
        Console.WriteLine("3. Deposita soldi Contocorrente");
        Console.WriteLine("4. Preleva soldi su Contocorrente");
        Console.WriteLine("5. Vedi saldo Contocorrente");
        Console.WriteLine("6. Vedi info Contocorrente");
        string menu = Console.ReadLine();
        switch (menu)
        {
            case "1":
                b.ApriConto();
                break;
            case "2":
                b.ChiudiConto();
                break;
            case "3":
                b.DepositaSuConto(); 
                break;
            case "4":
                b.PrelevaDaConto();
                break;
            case "5":
                b.VediSaldoConto();
                break;
        }
    }
}
