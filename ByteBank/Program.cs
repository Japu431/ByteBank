using ByteBank.Funcionarios;
using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonficacao();

            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor Roberta = new Diretor("832.123.123-112");
            Roberta.Nome = "Roberta";
            Roberta.Senha = "123";


            GerenteDeConta Camila = new GerenteDeConta("122.543.832-12");
            Camila.Nome = "Camila";
            Camila.Senha = "12314";


            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "12321";

            sistemaInterno.Logar(Roberta, "123");
            sistemaInterno.Logar(Camila, "12314");
            sistemaInterno.Logar(parceiro, "82342");

        }

        public static void CalcularBonficacao()
        { 
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario Pedro = new Designer("832.123.123-12");
            Pedro.Nome = "Pedro";

            Funcionario Roberta = new Diretor("832.123.123-112");
            Roberta.Nome = "Roberta";

            Funcionario Igor = new Auxiliar("832.123.832-12");
            Igor.Nome = "Igor";

            Funcionario Camila = new GerenteDeConta("122.543.832-12");
            Camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(Pedro);
            gerenciadorBonificacao.Registrar(Roberta);
            gerenciadorBonificacao.Registrar(Igor);
            gerenciadorBonificacao.Registrar(Camila);

            Console.WriteLine("Total de bonificação do mês : " + 
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
