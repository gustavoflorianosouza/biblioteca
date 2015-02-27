using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClassLibrary.Entity;

namespace BibliotecaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Categoria objCategoria = new Categoria();
            Usuario objUsuario = new Usuario();
            Autor objAutor = new Autor();
            Livro objLivro = new Livro();

            //Categoria
            Console.WriteLine("Nome da Categoria: ");
            objCategoria.Nome = Console.ReadLine();
            Console.WriteLine("Categoria: " + objCategoria.Nome);

            //Autor
            Console.WriteLine("Nome do Autor");
            objAutor.Nome = Console.ReadLine();
            Console.WriteLine("Autor: " + objAutor.Nome);

            //Livro
            Console.WriteLine("Título do livro: ");
            objLivro.Titulo = Console.ReadLine();
            Console.WriteLine("Título: " + objLivro.Titulo);

            Console.WriteLine("Editora do livro: ");
            objLivro.Editora = Console.ReadLine();
            Console.WriteLine("Editora: " + objLivro.Editora);

            //Usuario
            Console.WriteLine("Nome do usuário: ");
            objUsuario.Nome = Console.ReadLine();
            Console.WriteLine("Nome: " + objUsuario.Nome);

            Console.WriteLine("Email: ");
            objUsuario.Email = Console.ReadLine();
            Console.WriteLine("Email : " + objUsuario.Email);

            Console.WriteLine("Senha: ");
            objUsuario.Email = Console.ReadLine();
            Console.WriteLine("Senha : " + objUsuario.Senha);
        }
    }
}
