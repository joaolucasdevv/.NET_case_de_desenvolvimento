//<-- Desde já, agradeço pelo tempo e atenção empregados na avaliação deste Case!! -->//
using Case_de_desenvolvimento;
Console.WriteLine("Olá, você está no Case de Desenvolvimento de João Lucas Barreto dos santos!");
// Coloquei para imprimir no console alguns informações para facilitar no entendimento das funcionalidades do Case.
// e como acessar essas funcionalidades, através dos dígitos "1", "2", "3" e a palavra "exit".
Console.WriteLine("______________________________________________________________________________");
Console.WriteLine("Para cadastrar usuários, digite 1");
Console.WriteLine("Para visualizar todos os usuários, digite 2");
Console.WriteLine("Para visualizar um usuário em específico, digite 3");
Console.WriteLine("Para finalizar, escreva 'exit'");
Console.WriteLine("______________________________________________________________________________");

// Aqui é nossa lista, com os atributos da nossa classe, onde armazenaremos as classes criadas
List<Usuario> listaDeUsuarios = new List<Usuario>();

// Criei uma estrutura de "while" para podermos adicionar quantos uruários quiseros e mantermos o Case funcionando,
// esse WHile recebe o valor da variável booleana "rodando" como true pra seguir rodando nosso case, lá embaixo, o comando "exit"
// irá servir para mudarmos para "false" e encerrar a aplicação.
bool rodando = true;
while (rodando == true)
{
    // Inseri um "ReadLine" para o usuário escolher qual funcionalidade ele quer utilizar.
    Console.WriteLine("Digite um comando de acordo com as opções a cima");
    string resp = Console.ReadLine();

    // Aqui eu criei uma estrutura de "IF" para ativar as funcionalidades de acordo com o comando do usuário.
    if (resp == "1")
    {
        // Temos 3 inputs diferentes para receber o valor referentes a "nome", "email" e "idade".
        Console.WriteLine("Digite o NOME do usuário:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o EMAIL do usuário:");
        string email = Console.ReadLine();
        Console.WriteLine("Digite a IDADE do usuário");
        int idade = int.Parse(Console.ReadLine());

        // Despos de inserirmos nossos dados, vamos adicioná-los em nossa lista,
        // Nossa classe e constructor se mostrou muito útil para fazer isso!!
        listaDeUsuarios.Add(new Usuario(nome, email, idade));
    }
    // Seguimos para a funcionalidade da do comando "2", ele simplesmente exibe todos os
    // usuários cadastrados em nossa lista.
    else if (resp == "2")
    {
        // Utilizei um "foreach" para percorrer por todos os usuários e imprimir no console.
        foreach (var usuario in listaDeUsuarios)
        {
            Console.WriteLine($"Nome: {usuario.Nome}");
            Console.WriteLine($"Email: {usuario.Email}");
            Console.WriteLine($"Idade: {usuario.Idade}");
        }
    }
    // Partindo pra funcionalidade referente ao comando "3", forneceremos um nome de usuário,
    // que se estiver cadastrado em nossa lista irá imprimir todos os dados desse usuário.
    else if (resp == "3")
    {
        // Utilizei um "foreach" mais uma vez pra percorrer nossa lista
        foreach (var usuario in listaDeUsuarios)
        {
            // Coloquei um input para receber um valor referente ao nome de usuário
            Console.WriteLine("Digite o NOME de usuário para realizar a busca");
            string consultUsuario = Console.ReadLine();

            // Aqui temos um "if" para validar se o usuário referente a nossa consulta está cadastrado em nossa lista.
            if (usuario.Nome == consultUsuario)
            {
                // Se sim, irá imprimir todos os dados desse usuário.
                Console.WriteLine($"Nome: {usuario.Nome}");
                Console.WriteLine($"Email: {usuario.Email}");
                Console.WriteLine($"Idade: {usuario.Idade}");

            }
            else
            {
                // Se não, irá mostrar uma mensagem de "Usuário não encontrado!".
                Console.WriteLine("Usuário não encontrado!");
            }
        }
    }
    // Como dito no início do nosso código, esse último "else if" faz uma checagem do valor inicial do input
    // se o valor for igual a "exit", ele encerra nossa aplicação
    else if (resp == "exit")
    {
        // Se o valor de "resp" for "exit", mudamos o "rodando" para "false", encerrando a aplicação
        rodando = false;
    }
}

//<-- Agradeço pelo tempo e atenção empregados na avaliação deste Case!! -->//
