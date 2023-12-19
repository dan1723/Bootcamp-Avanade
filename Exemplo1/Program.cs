using Exemplo1.Moldes;

List<string> listastring = new List<string>();

listastring.Add("SP");
listastring.Add("BA");
listastring.Add("MS");
listastring.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listastring.Count} - Capacidade: {listastring.Capacity}");

listastring.Add("SC");

Console.WriteLine($"Itens na minha lista: {listastring.Count} - Capacidade: {listastring.Capacity}");

listastring.Remove("MS");

Console.WriteLine($"Itens na minha lista: {listastring.Count} - Capacidade: {listastring.Capacity}");

 






/*Console.WriteLine("Percorrendo o Array com o FOR");
for(int cont = 0; cont < listastring.Count; cont++){

    Console.WriteLine($"Posição Nº {cont} - {listastring[cont]}");
}


Console.WriteLine("Percorrendo o Array com o FOREACH");
int contForeach = 0;
foreach(string item in listastring){

    Console.WriteLine($"Posição Nº {contForeach} - {item}");
    contForeach++;
}*/

































/*int[] arrayint = new int[4];

arrayint[0] = 72;
arrayint[1] = 22;
arrayint[2] = 10;
arrayint[3] = 10;


int[] arraycopia = new int[arrayint.Length * 2];
Array.Copy(arrayint, arraycopia, arrayint.Length); 


Array.Resize(ref arrayint, arrayint.Length * 2);


Console.WriteLine("Percorrendo o Array com o FOR");
for(int cont = 0; cont < arrayint.Length; cont++){

    Console.WriteLine($"Posição nº{cont + 1} - {arrayint[cont]}");
}*/













/*Console.WriteLine("Percorrendo o Array com o FOREACH");
int contForeach = 0;
foreach(int valor in arrayint){
    
    Console.WriteLine($"Posição nº{contForeach + 1} - {valor}");
    contForeach++;

}*/















/*string opcao;
bool exibirMenu = true;

while(exibirMenu){

    Console.Clear(); 
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao){
        case "1":
            Console.WriteLine("Cadastrar cliente");
            break;

        case "2":
            Console.WriteLine("Buscar cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");*/



















/*int soma = 0, num = 0;



do{
    Console.WriteLine("Digite um número (0 para parar): ");
    num = Convert.ToInt32(Console.ReadLine());

    soma += num;

} while(num != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");*/





 








/*int numero = 5;
int cont = 0;

while(cont <= 10){

    Console.WriteLine($"{cont +1}º Execução: {numero} x {cont} = {numero*cont}");
    cont++;  

    if (cont == 5 ){
        break;
    }
}*/





/*Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}*/





















