// Screen Sound
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

string mensagemDeBoasVindas = "\nBoas Vindas ao Screen Sound!!";
//List<string> listaDasBandas = new List<string>{ "Menotody", "orochi", "matue"};
//List<string> listaDeArtistas = new List<string> { "Menotody", "orochi", "matue" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
Dictionary<string, List<int>> artistasRegistrados = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
artistasRegistrados.Add("Matue", new List<int> { 10, 7, 6 });

// Titulo do programa
void ExibirLogo()
{
    Console.WriteLine(@" 
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀ ");

    Console.WriteLine(mensagemDeBoasVindas);

}


// Menu de Opções do Programa
void ExibirOpcoesDoMenu()

{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para cadastrar um Artista");
    Console.WriteLine("Digite 3 para mostrar todas as bandas e Artistas Registrados");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um artista");
    Console.WriteLine("Digite 6 para exibir a media de uma banda");
    Console.WriteLine("Digite 7 para exibir a media do artista");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            Registrarbanda();
            break;
        case 2:
            Registrarartista();
            break;
        case 3:
            MostrarBandasRegistradas();
            break;
        case 4:
            AvaliarUmaBanda();
            break;
        case 5:
            AvaliarUmArtista();
            break;
        case 6:
            MediaDasBandas();
            break;
        case 7:
            MediaDosArtistas();
            break;
        case 0:
            Console.WriteLine("Obrigado por utilizar meu programa, até logo! :)");
            break;
        default:
            Console.WriteLine("Opção Invalida :( ");
            break;
    }

}

ExibirOpcoesDoMenu();

//registro da banda
void Registrarbanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso :D");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();


}

void Registrarartista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Artistas");
    Console.Write("Digite o nome do artista que deseja cadastrar: ");
    string nomeDoArtista = Console.ReadLine()!;
    artistasRegistrados.Add(nomeDoArtista, new List<int>());
    Console.WriteLine($"O Artista {nomeDoArtista} foi cadastrado com sucesso :D");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as Bandas e Artistas registrados...");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    {
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        foreach (string artista in artistasRegistrados.Keys)
        {
            Console.WriteLine($"Artista: {artista}");
        }
    }


    Console.WriteLine("\nPrecione uma tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda() 
{
    //digite qual banda voce vai avaliar
    //se a banda existe no sistema >> atribuir uma nota
    //se nao existir voltar para o menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a {nomeDaBanda} merece?: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota para a banda {nomeDaBanda} foi {nota}, e a nota foi registrada com sucesso :D");
        Thread.Sleep(6000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else

    {
        Console.WriteLine($"\nA banda {nomeDaBanda} nao foi encontrada na base de dados");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}
void AvaliarUmArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar o Artista");
    Console.Write("Digite o nome do artista que você deseja avaliar: ");
    string nomeDoArtista = Console.ReadLine()!;

    if (artistasRegistrados.ContainsKey(nomeDoArtista))
    {
        Console.Write($"Qual a nota que o(a) {nomeDoArtista} merece?: ");
        int notaArtista = int.Parse(Console.ReadLine()!);
        artistasRegistrados[nomeDoArtista].Add(notaArtista);
        Console.WriteLine($"a nota para {nomeDoArtista} foi {notaArtista}, e a nota foi registrada com sucesso :D");
        Thread.Sleep(6000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else

    {
        Console.WriteLine($"\nO Artista {nomeDoArtista} nao foi encontrado na base de dados. Tente novamente mais tarde...");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}
void MediaDasBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Media das Bandas");
    Console.Write($"Qual Banda voce deseja ver a media?: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda{nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.Write("Pressione uma tecla para voltar ao menu principal....");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();


    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} nao foi encontrada na base de dados :(, tente novamente. ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
                    
}
void MediaDosArtistas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Media dos Artistas");
    Console.Write("Qual o Artista que você deseja ver a media?: ");
    string nomeDosArtista = Console.ReadLine()!;
    if (artistasRegistrados.ContainsKey(nomeDosArtista))
    {
        List<int> notasDoArtista = artistasRegistrados[nomeDosArtista];
        Console.WriteLine($"A Media do Artista {nomeDosArtista} é {notasDoArtista.Average()}.");
        Console.Write("Pressione Qualquer tecla para voltar ao menu principal ... ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nO artista {nomeDosArtista} nao foi encontrada na base de dados :(, tente novamente. ");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal ... ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}