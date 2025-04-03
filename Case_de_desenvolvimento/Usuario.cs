using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case_de_desenvolvimento;

namespace Case_de_desenvolvimento
{
    // Aqui eu criei uma classe para poder armazenar os dados de "nome", "email" e "idade" dentro da nossa lista de uma forma
    // mais organizada, também para poder facilitar a consulta dos mesmos.
    class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        // Aqui eu resolvi criar um constructor para inserir os dados que vierem do input com mais facilidade.
        public Usuario(string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}
