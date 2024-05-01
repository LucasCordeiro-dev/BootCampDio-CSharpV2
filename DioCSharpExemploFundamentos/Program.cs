using DioCSharpExemploFundamentos.Common.Models;

#region Tipos de dados
// string apresentacao = "Olá seja bem-vindo"; 
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80m;
// bool condicao = true;
// System.Console.WriteLine(apresentacao);
// System.Console.WriteLine("Valor da variavel quantidade: " +  quantidade);
// System.Console.WriteLine("Valor da variavel altura: " +  altura);
// System.Console.WriteLine("Valor da variavel preco: " +  preco);
// System.Console.WriteLine("Valor da variavel condicao: " +  condicao);
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Cord";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();
#endregion

#region Combinando Operadores
//Combinando Operadores
// int a = 20;
// int b = 10;
// int c = a + b;
// c += 5;
// System.Console.WriteLine( c);
#endregion

#region Cast (Conversoes de var)
// Cast - Casting
// int a = Convert.ToInt32("5"); -> String para INT
// int a = int.Parse("5");
// Diferenca entre Convert e Parse (passando NULL)
// Convert -> Convert para 0
// Parse - > Erro , nao aceita nulo
// int inteiro = 5;
// string a = inteiro.ToString(); -> Para STRING

//Cast implícito
// int a  = 5;
// double b = a;

//De forma manual
// long a = long.MaxValue;
// int b = Convert.ToInt32(a);
// System.Console.WriteLine(b);
#endregion

#region Ordem dos Operadores
//double a = 4 / 2 + 2;
//C# Obedece as mesmas prioridades matematicas reais de conta
//System.Console.WriteLine(a);
#endregion

#region Conversao de maneira segura
// string a = "15-";
// int b = 0;
// int.TryParse(a, out b);
// System.Console.WriteLine(b);
#endregion

#region Operador Condicional na prática
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// System.Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// System.Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// System.Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if(possivelVenda)
// {
//     System.Console.WriteLine("Venda realizada");
// }
// else
// {
//     System.Console.WriteLine("Não temos a quantidade desejada em estoque");
// }

#endregion

#region Switch Case
// System.Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

#region Maneira "Convencional"
// if(letra == "a")
// {
// System.Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//         System.Console.WriteLine("Vogal");

// }
//   else if (letra == "i")
// {
//         System.Console.WriteLine("Vogal");

// }
//   else if (letra == "o")
// {
//         System.Console.WriteLine("Vogal");

// }
//   else if (letra == "u")
// {
//         System.Console.WriteLine("Vogal");

// }
// else
// {
//     System.Console.WriteLine("Não é vogal");
// }
#endregion
#region Switch na prática -> Utilizável quando se possui muitos else/if
// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     System.Console.WriteLine("Vogal");
//     break;
//     default:
//     System.Console.WriteLine("Não é vogal");
//     break;
// }
#endregion
#endregion

#region Operadores lógicos - OR, AND e NOT
// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     System.Console.WriteLine("Entrada liberada");
// }
// else
// {
//     System.Console.WriteLine("Entrada não liberada");
// }

//AND -> Necessario AMBAS condicões serem verdadeiras
// bool possuiPresencaMinima = true;
// double media = 7.5;

// if(possuiPresencaMinima && media>= 7)
// {
//     System.Console.WriteLine("Aprovado");
// }
// else
// {
//     System.Console.WriteLine("Reprovado");
// }

//NOT - Condições FALSAS para serem executadas
// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde)
// {
//     System.Console.WriteLine("Vou pedalar");
// }
// else
// {
//     System.Console.WriteLine("Vou pedalar outro dia");
// }
#endregion

#region Calculadora
//Calculadora calc = new Calculadora();
// calc.Somar(10,20);
// calc.Subtrair(10,30);
// calc.Multiplicar(10,60);
// calc.Dividir(50,5);
// calc.Potencia(3,3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//calc.RaizQuadrada(9);

// int numeroIncremento = 10;
// System.Console.WriteLine(numeroIncremento);
// System.Console.WriteLine("Incrementando o 10");
// numeroIncremento++;
// System.Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// System.Console.WriteLine(numeroDecremento);
// System.Console.WriteLine("Decrementando o 20");
// numeroDecremento--;
// System.Console.WriteLine(numeroDecremento);
#endregion

#region Estruturas de repetição
#region LAÇO FOR
// int numero = 5;
//Declaração da variável para o CONTADOR;Condição de parada;Incrementado ou decrementado
// for (int contador = 0;contador <=10;contador++)
// {
//     System.Console.WriteLine($"{numero} X {contador} = {numero*contador}");
// }
#endregion

#region LAÇO WHILE
// int numero = 5;
// int contador = 0;

//     while(contador <=10)
//     {
//         System.Console.WriteLine($"{contador}° Execução: {numero}X {contador} = {numero*contador}");
//         contador++;
//     }
#endregion

#region LAÇO DO WHILE
// int soma = 0 ,numero = 0;
//     do
//     {
//         System.Console.WriteLine("Digite um número (0 para PARAR)");
//         numero = Convert.ToInt32(Console.ReadLine());

//         soma += numero;

//     }while(numero != 0);
//     System.Console.WriteLine($"Total da soma dos números digitados é: {soma}");
#endregion
#endregion

#region MENU Interativo
// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     System.Console.WriteLine("Digite a sua opção: ");
//     System.Console.WriteLine("1 - Cadastrar cliente");
//     System.Console.WriteLine("2 - Buscar cliente");
//     System.Console.WriteLine("3 - Apagar cliente");
//     System.Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//         System.Console.WriteLine("Cadastro cliente");
//         break;

//         case "2":
//         System.Console.WriteLine("Buscar cliente");
//         break;

//         case "3":
//         System.Console.WriteLine("Apagar cliente");
//         break;

//         case "4":
//         System.Console.WriteLine("Encerrar");
//         //Environment.Exit(0);
//         exibirMenu = false;
//         break;

//         default:
//         System.Console.WriteLine("Opção inválida");
//         break;
//     }
//     System.Console.WriteLine("O programa se encerrou");
// }
#endregion

#region Trabalhando com Arrays
// int[] arrayInteiro = new int[4];
// arrayInteiro[0] = 72;
// arrayInteiro[1] = 64;
// arrayInteiro[2] = 50;
// arrayInteiro[3] = 60;

#region Copiando um array para o outro
//int[] arrayInteiroDobrado = new int[arrayInteiro.Length * 2];
//Array.Copy(arrayInteiro, arrayInteiroDobrado,arrayInteiro.Length);
#endregion

#region Redimensionando um array
//Array.Resize(ref arrayInteiro,arrayInteiro.Length * 2);
#endregion

#region Se necessita do valor do contador -> FOR
// System.Console.WriteLine("Percorrendo o array com o FOR");
// for (int contador = 0; contador < arrayInteiro.Length; contador++)
// {
//     System.Console.WriteLine($"Posicao N {contador} - {arrayInteiro[contador]}");
// }
#endregion

#region Se NÄO necessita do valor do contador -> FOREACH
// System.Console.WriteLine("Percorrendo o array com o FOREACH");
// foreach (int valor in arrayInteiro)
// {
//     System.Console.WriteLine($"Posicao N {valor} - {arrayInteiro[valor]}");
// }
#endregion
#endregion

#region Trabalhando com Listas
// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// System.Console.WriteLine($"Itens na minhalista: {listaString.Count} - Capacidade: {listaString.Capacity}");
// listaString.Add("SC");

// System.Console.WriteLine($"Itens na minhalista: {listaString.Count} - Capacidade: {listaString.Capacity}");
// listaString.Remove("MG");

// System.Console.WriteLine($"Itens na minhalista: {listaString.Count} - Capacidade: {listaString.Capacity}");


// System.Console.WriteLine("Percorrendo lista com FOR");
// for(int contador  = 0; contador < listaString.Count; contador++)
// {
//     System.Console.WriteLine($"Posiçäo N {contador} - {listaString[contador]}");
// }

// System.Console.WriteLine("Percorrendo lista com FOREACH");

// foreach(string item in listaString)
// {
//     System.Console.WriteLine($"Posiçäo N {item} - {item}");
    
// }
#endregion