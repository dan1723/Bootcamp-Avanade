using Exemplo2.Models;
using System.Globalization;
using System.Security.Cryptography;











  











































/*Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

/*foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("----------------------");

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}*/

/*string chave = "BA2";

Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave)){
    Console.WriteLine($"Valor existente: {chave}");
} else{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}*/

//Console.WriteLine(estados["MG"]);

 


















































/*Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha){
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo da pilha: {pilha.Pop()}");

pilha.Push(20);

foreach(int item in pilha){
    Console.WriteLine(item);
}*/
























/*Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(8);
fila.Enqueue(10);
 
foreach(int item in fila){
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(11);

foreach(int item in fila){
    Console.WriteLine(item);
}*/







//new Exececao().mt1();










/*string[] linhasex = File.ReadAllLines("Arquivos/pasta1/arquivo_Leitura.txt");


try{

    string[] linhas = File.ReadAllLines("Arquivos/barquivoLeitura.txt");

    foreach(string linha in linhas){

    Console.WriteLine(linha);
    }

} catch (FileNotFoundException ex){

    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");

} catch (Exception ex){

    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");

} finally{
    Console.WriteLine("Chegou até aqui");
}*/















/*Pessoa p1 = new Pessoa("Danilo", "Fernandes");
Pessoa p2 = new Pessoa("José", "Silva");

Curso Ingles = new Curso();
Ingles.Nome = "ingles";
Ingles.Alunos = new List<Pessoa>();

Ingles.AdicionarAluno(p1);
Ingles.AdicionarAluno(p2);
Ingles.ListarAlunos();*/







    /*string dataString = "2023-13-16 09:54";
    
    bool sucesso = DateTime.tryParseExact(dataString, 
                                          "yyyy-MM-dd HH:mm",
                                          CultureInfo.InvariantCulture,
                                          DateTimeStyles.None,
                                          out DateTime data);
    
    
    if (sucesso){
        Console.WriteLine($"Conversão com sucesso! Data: {data}");
    } else{
        Console.WriteLine($"{dataString} não é uma data valida");
    }*/
    
    
    
    
    

    
/*decimal valorMon = 1582.40M;
    
    Console.WriteLine(valorMon.ToString("N2", CultureInfo.CreateSpecificCulture("pt-BR")));
    
    double porcen = .3421;
    
    Console.WriteLine(porcen.ToString("P"));
    
    int num = 123456;
 Console.WriteLine(num.ToString("##-##-##"));*/
    
    
    
    
    
/*string n1 = "10";
    string n2 = "20";
    
    string result = n1 + n2;
    
Console.WriteLine(result);*/


/*Pessoa p1 = new Pessoa();
p1.Nome = "Danilo";
p1.Sobrenome = "Fernandes";
p1.Idade = 30;
p1.Apresentar();*/