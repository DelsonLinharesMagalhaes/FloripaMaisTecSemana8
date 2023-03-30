using System.Globalization;
using SistemaBanco;

List<Cliente> clientes = new List<Cliente>();

clientes.Add(new Cliente("Delson",
            "12345678911",
            "delson@hotmail.com",
            "99999885566",
            "Rua da Aventura, 123",
            new DateTime(1968-07-02),
            1));

clientes.Add(new Cliente("Andrea",
            "98765432111",
            "andrea@hotmail.com",
            "98889885566",
            "Rua das Bromelias, 123",
            new DateTime(1971-04-20),
            2));

clientes.Add(new Cliente("Spark",
            "14725836996",
            "spark@hotmail.com",
            "97779885566",
            "Rua dos Cachorros, 123",
            new DateTime(2000-04-20),
            3));

clientes.Add(new Cliente("Juscelino",
            "36925814774",
            "spark@hotmail.com",
            "96669885566",
            "Rua dos Desconhecidos, 123",
            new DateTime(2002-05-25),
            4));




string opcao;
do{
Console.WriteLine("Bem vindo ao Banco Full Stack, escolha uma opção:");
Console.WriteLine("1 - Criar conta");
Console.WriteLine("2 - Adicionar Transação");
Console.WriteLine("3 - Consultar Extrato");
Console.WriteLine("4 - Exibir Cliente");
Console.WriteLine("5 - Sair");
opcao = Console.ReadLine();
if (opcao == "1"){
    CriarConta();
} 
if (opcao == "2"){
    AdicionarTransacao();
} 
if (opcao == "3"){
    ExibirExtrato();
} 
if (opcao == "4"){
    ExibirClientes();
} 
}while(opcao!= "5" );

void AdicionarTransacao(){
    Console.WriteLine("Qual a conta:");
    int numeroConta = int.Parse(Console.ReadLine());

    Cliente contaCliente = BuscarClientePorNumeroDeConta(numeroConta);

    if(contaCliente == null){
        Console.WriteLine("Conta não cadastrada.");
        return;
    }

    Console.WriteLine("Qual é o valor da transação:");
    double valor = double.Parse(Console.ReadLine());
    Transacao transacao = new Transacao(DateTime.Now, valor);
    contaCliente.Extrato.Add(transacao);

}

void ExibirExtrato(){
    Console.WriteLine("Qual a conta:");
    int numeroConta = int.Parse(Console.ReadLine());

    Cliente contaCliente = BuscarClientePorNumeroDeConta(numeroConta);

   if(contaCliente == null){
        Console.WriteLine("Conta não cadastrada!");
        return;
   }
   
   double saldo = 0;   
   
    foreach(Transacao transacao in contaCliente.Extrato){
        Console.WriteLine("Data: " +transacao.Data+" Valor: R$ "+ transacao.Valor);
        saldo+=transacao.Valor;
    }
    Console.WriteLine("Saldo = " + contaCliente.Saldo);
}



Cliente BuscarClientePorNumeroDeConta (int numeroConta){
  foreach(Cliente cliente in clientes){
    if(cliente.NumeroConta == numeroConta){
      return cliente;
    }
  }
  return null;
}

void ExibirClientes(){
   Console.WriteLine("Número da conta        | Nome         | CPF    ");
  for(int i =0; i < clientes.Count; i++){
    Console.WriteLine(clientes[i].ResumoCliente());
  }
}

void CriarConta(){
    Cliente cliente = new Cliente();
    Console.WriteLine("Data de Nascimento do Cliente");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
    if(!cliente.EhMaior()){
        Console.WriteLine("Cliente menor de idade, não é permitido abirir a conta");
        return;
    }
    Console.WriteLine($"A idade do cliente é : {cliente.Idade}");

    Console.WriteLine("Nome do Cliente");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("CPF do Cliente");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Email do Cliente");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Telefone do Cliente");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Endereço do Cliente");
    cliente.Endereco = Console.ReadLine();
   
    Console.WriteLine("Número da conta");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    clientes.Add(cliente);
}








