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
            string nome = Console.ReadLine();
            Nome = nome;
            Console.WriteLine("Conto aperto");
            Console.ReadLine();
        }
        public void ChiudiConto()
        {
            chiu = false;
            Console.WriteLine("Il conto è stato chiuso.");
            Console.WriteLine("Saldo da prelevare: " + saldo);
            saldo = 0;
            Nome = "";
            Console.ReadLine();
        }
        public void DepositaSuConto()
        {
            Console.WriteLine("Inserisci soldi da depositare");
            int s = Convert.ToInt32(Console.ReadLine());
            saldo += s;
            Console.WriteLine("Il saldo corrente è: " + saldo);               
            Console.ReadLine();

        }
        public void PrelevaDaConto()
        {
            Console.WriteLine("Inserisci soldi da prelevare");
            int p = Convert.ToInt32(Console.ReadLine());
            saldo -= p;
            Console.WriteLine("Il saldo corrente è: " + saldo);
            Console.ReadLine();
        }
        public void VediSaldoConto()
        {
            Console.WriteLine("Saldo del conto: " + saldo);
            Console.ReadLine();
        }
        public void VediInfoConto()
        {
            Console.WriteLine("Proprietario conto: " + Nome);
            Console.WriteLine("Saldo del conto: " + saldo);
            if (chiu == false)
            {
                Console.WriteLine("Stato del conto:  aperto");
            }
            else
            {
                Console.WriteLine("Stato del conto:  chiuso");
            }
            Console.ReadLine();
        }

    }
}
internal class Program
{
    static void Main(string[] args)
    { 
        Banca[] b = new Banca[5];
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
                    for (int i=0; i < b.Length; i++)
                    {
                        if (b[i] == null)
                        {
                            b[i] = new Banca();
                            b[i].ApriConto();
                            Console.Clear();
                            break;
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Inserisci nome:");
                    string nom = Console.ReadLine();
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] == null)
                        {

                        }
                        else if (nom == b[i].Nome)
                        {
                            b[i].ChiudiConto();
                            Console.Clear();
                            break;
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Inserisci nome:");
                    string n = Console.ReadLine();
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] == null)
                        {

                        }
                        else if (n == b[i].Nome)
                        {
                            b[i].DepositaSuConto();
                            Console.Clear();
                            break;
                            
                        }
                    }
                    break;
                case "4":
                    Console.WriteLine("Inserisci nome:");
                    string nome1 = Console.ReadLine();
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] == null)
                        {

                        }
                        else if (nome1 == b[i].Nome)
                        {
                            b[i].PrelevaDaConto();
                            Console.Clear();
                            break;
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("Inserisci nome:");
                    string nome = Console.ReadLine();
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] == null)
                        {

                        }
                        else if (nome == b[i].Nome)
                        {
                            b[i].VediSaldoConto();
                            Console.Clear();
                            break;
                        }
                    }
                    break;
                case "6":
                    Console.WriteLine("Inserisci nome:");
                    string nome2 = Console.ReadLine();
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] == null)
                        {

                        }
                        else if (nome2 == b[i].Nome)
                        {
                            b[i].VediInfoConto();
                            Console.Clear();
                            break;
                        }
                    }
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
