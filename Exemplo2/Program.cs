using Exemplo2.Models;
using System.Globalization;




try{

    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    foreach(string linha in linhas){

    Console.WriteLine(linha);
    }

} catch (Exception ex){

    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

Console.WriteLine("Chegou até aqui");



























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