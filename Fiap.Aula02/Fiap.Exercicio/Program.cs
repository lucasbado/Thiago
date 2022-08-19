//Ler a quantidade de clientes
using Fiap.Exercicio.Models;

Console.WriteLine("Digite a qtd de clientes");
int qtd = Convert.ToInt32(Console.ReadLine());


//Criar uma lista de clientes
IList<Cliente> lista = new List<Cliente>();

//Cria um laço para ler os clientes
    for (int i = 0; i < qtd; i++)
{
    //Ler os dados do cliente (id e nome)
    Console.WriteLine("Digite o Id");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o nome");
    string? nome = Console.ReadLine();
    //Instanciar o cliente e adicionar na Lista
    Cliente cliente = new Cliente(id, nome);
    lista.Add(cliente);
}

//Ler os dados da conta corrente (numero, agencia e tipo)
Console.WriteLine("Digite o Agencia");
var agencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o numero");
var numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o tipo da conta 0-Comum, 1-Especial, 2-Premium");
TipoConta tipo = (TipoConta)Convert.ToInt32(Console.ReadLine());

var cc = new ContaCorrente(agencia, numero, lista, tipo);


//Exibir os dados do conta corrente 
foreach(Cliente cliente in cc.Clientes)
Console.WriteLine(cc);

//Exibir o menu (1-depositar, 2retirar,3exibir dados, 0-sair)
int opcao;
do
{
    Console.WriteLine("Escolha uma opção: 1-depositar, 2-retirar, 3-exibir dados, 0-sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    while (opcao != 0)
    {
        
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite o valor para deposito");
                decimal valor = Convert.ToDecimal(Console.ReadLine());
                cc.Depositar(valor);
                Console.WriteLine("Depósito realizado");
                break;
            case 2:
                Console.WriteLine("Digite o valor para retirar");
                valor = Convert.ToDecimal(Console.ReadLine);
                try
                {
                    cc.Retirar(valor);
                    Console.WriteLine("Saque realizado");
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
                
                
                break;
            case 3:
                Console.WriteLine(cc);
                break;
            case 0:
                Console.WriteLine("Adeus");
                break;
            default:
                Console.WriteLine("opção Invalida");
                break;
        
       
           
        }
            
    }
        

}while (opcao != 0);

