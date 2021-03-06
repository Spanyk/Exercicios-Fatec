using System;
using System.Text;
using System.Threading.Tasks;

namespace Exer_28
{
    internal class Program
    {
        const int N = 5;

        class Sc_no // Sem tratamento de colisão
        {
            public int idade;
            public string nome, sexo;
        }

        static int Hash(int c)
        {
            return (c % N);
        }
        static void Insere(Sc_no[] v, int age, string nm, string sex)
        {
            
            int pos = Hash(age);
            v[pos].idade = age;
            v[pos].nome = nm;
            v[pos].sexo = sex;
        }
        static int Busca(int age)
        {
            int pos = Hash(age); ;
            return pos;

        }
        static void criaNos(Sc_no[] V)
        {
            int i;
            for (i = 0; i < N; i++)
            {
                V[i] = new Sc_no();
            }
        }
        /*
        static void InserirLinear(Tp_no[] v, int age, string nm, string sex, ref int q)
        {
            int pos = hash(age);
            while (v[pos].idade != 0)
            {
                pos++;
                pos = pos % N;
                q += q;
            }
            v[pos].idade = age;
            v[pos].nome = nm;
            v[pos].sexo = sex;
        }
        static int RecuperarLinear(Tp_no[] v, int nt)
        {
            int pos = hash(nt);
            int cont = 0;

            while (v[pos].idade != nt && cont <= N)
            {
                pos++;
                pos = pos % N;
                cont++;
            }
            if (cont <= N)
            {
                return pos;
            }
            else
            {
                return -1;
            }

        }
        */
        static void funcionalidades(string x) // main 2
        {
            Sc_no[] Vetor = new Sc_no[N];
            criaNos(Vetor);
            int op = 0, idade = 0;
            string nome, sexo;

            while (true)
            {

            
                Console.WriteLine("\nEscolha uma opção:");
                Console.Write(
                    "[1] Inserir\n" +
                    "[2] Consultar\n" +
                    "[3] Alterar\n" +
                    "[4] Relatar\n" +
                    "\n>>  "
                    );
                op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("\n>> Prencha os campos");
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sexo: ");
                    sexo = Console.ReadLine();

                    switch (x)
                    {
                        case "1":
                            Insere(Vetor, idade, nome, sexo);
                            break;

                        case "2":
                            break;

                        case "3":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(">> Gay <<");
                            Console.ResetColor();
                            break;
                    }
                }

                else if (op == 2)
                {
                    Console.Write(">> Informe a idade: ");
                    int idadeBuscada = int.Parse(Console.ReadLine());

                    Busca(idadeBuscada);
                }

                else if (op == 3)
                {

                }

                else if (op == 4)
                {

                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Insira uma opção válida <<");
                    Console.ResetColor();
                }
        }
    }
        static void Main(string[] args)
        {
            int op = 0;
            Console.WriteLine("Escolha um opção");
            Console.Write(
            "[1] Sem tratamento de colisão\n" +
            "[2] Tratamento de colisão Linear\n" +
            "[3] Tratamento de colisão com lista encadeada\n" +
            "\n>> "
            );

            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Opção escolhida: Sem tratamento <<");
                    Console.ResetColor();
                    SemColisao();
                    break;

                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Opção escolhida: Com tratamento <<");
                    Console.ResetColor();
                    ColisaoLinear();
                    break;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">> Opção escolhida: Colisão encadeada <<");
                    Console.ResetColor();
                    ColisaoLinearEncadeada();
                    break;
            }
        }

        static void SemColisao()
        {
            string x = "1";
            funcionalidades(x);
        }

        static void ColisaoLinear()
        {
            string x = "2";
            funcionalidades(x);
        }

        static void ColisaoLinearEncadeada()
        {
            string x = "3";
            funcionalidades(x);
        }
    }
}
