using System;
using POO_Heranca.classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            //instanciamos nossa subclasse
            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();
            //atribuimos um valor para a propriedade disponivel na superclasse
            Console.WriteLine("Digite o seu nome");
            pf.nome = Console.ReadLine();
        
            Console.ForegroundColor = ConsoleColor.Cyan;
            //mostramos no console o método de saudação
            Console.WriteLine(pf.DarBoasVindas(pf.nome));
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Você é pessoa Física ou Jurídica?");
            Console.WriteLine("[1]- PESSOA FÍSICA");
            Console.WriteLine("[2]- PESSOA JURÍDICA");
            choice= int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;
            if(choice ==1){
            //mostramos no console o metodo de validação da subclasse
            Console.WriteLine("Digite seu CPF");
            pf.cpf =Console.ReadLine();

            Console.WriteLine("Digite seu RG");
            pf.rg = Console.ReadLine();

            Console.WriteLine(pf.ValidarCpf(pf.cpf)+" CPF Válido!");
            Console.WriteLine(pf.ValidarRg(pf.rg)+" RG Válido!");
            }else if(choice ==2){

                Console.WriteLine("Digite seu CNPJ");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("Digite sua Inscrição Estadual");
                pj.inscricaoEstadual = Console.ReadLine();

                Console.WriteLine(pj.ValidarCNPJ(pj.cnpj)+"CNPJ Válido!");
                Console.WriteLine(pj.ValidarInscricao(pj.inscricaoEstadual)+"Inscrição Válida!");
            }else{
                Console.WriteLine("Opção Inválida");
            }


        }
    }
}
