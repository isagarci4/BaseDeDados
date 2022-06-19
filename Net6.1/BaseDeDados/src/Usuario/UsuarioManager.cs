namespace BaseDeDados.Usuario;
using System.Collections.Generic;
public class UsuarioManager
{
    List<Usuario> listaUsuarios = new List<Usuario>();
    int teste = 0;
    public void AdicionarUsuarioNaBase()
    {
        var user = new Usuario();

        Console.WriteLine("Nome: ");
        user.Nome = Console.ReadLine();
        Console.WriteLine("  ");

        Console.WriteLine("CPF: ");
        user.CPF = Console.ReadLine();
        Console.WriteLine("  ");

        Console.WriteLine("RA: ");
        user.RA = int.Parse(Console.ReadLine());
        Console.WriteLine("  ");

        Console.WriteLine("Email: ");
        user.Email = Console.ReadLine();
        Console.WriteLine("  ");

        Console.WriteLine("Data De Nascimento: ");
        user.DataDeNascimento = Console.ReadLine();
        Console.WriteLine("  ");
        listaUsuarios.Add(user);

        Console.WriteLine("Usuario adicionado com sucesso!");
        Console.ReadLine();
    }

    public void RemoverUsuarioDaBase(){
        
        if (listaUsuarios.Count() <= 0){
            Console.WriteLine("Não há nenhum usuário na base de dados");
        } else  {
            Console.WriteLine("Qual o usuário deseja remover?");
            var nomeRemovido = Console.ReadLine();

                for (int i = 0; i < listaUsuarios.Count(); i++){
                    if (listaUsuarios[i].Nome == nomeRemovido){
                        teste = i;
                        break;
                     }  else {
                         teste = -1;
                    }
                }
                if (teste < 0){
                    Console.WriteLine("Usuário já foi removido ou não existe!");
                } else {
                    listaUsuarios.Remove(listaUsuarios[teste]);
                    Console.WriteLine("Usuário removido com sucesso!");
                    }
            }
        Console.ReadLine();
    }

    public void AlterarUsuarioNaBase()
    {
        Console.ReadLine();
    }

    public void PesquisarUsuarioNaBase()
    {
        if (listaUsuarios.Count() <= 0){
            Console.WriteLine("Não há nenhum usuário na base de dados");
        } else {
             Console.WriteLine("Qual o nome do usuário que deseja encontrar? \n");
        var nomePassado = Console.ReadLine();
        for (int i = 0; i < listaUsuarios.Count(); i++){
                    if (listaUsuarios[i].Nome == nomePassado){
                        teste = i;
                        break;
                     }  else {
                         teste = -1;
                    }
                }
                if (teste < 0){
                   Console.WriteLine("Nenhum usuário com esse nome foi encontrado volte ao inicio para adicionar");
                } else {
                Console.WriteLine($"{listaUsuarios[teste].Nome} encontrado seus dados são: \n");
                Console.WriteLine($"CPF: {listaUsuarios[teste].CPF}\n");
                Console.WriteLine($"Data De Nascimento: {listaUsuarios[teste].DataDeNascimento}\n");
                Console.WriteLine($"Email: {listaUsuarios[teste].Email}\n");
                Console.WriteLine($"RA: {listaUsuarios[teste].RA}");
                    }
        }
       
        Console.ReadLine();
    }

    public void ListarTodosOsUsuariosDaBase()
    {
         if (listaUsuarios.Count() <= 0){
            Console.WriteLine("Não há nenhum usuário na base de dados");
        } else {
             foreach (var item in listaUsuarios)
        {
            Console.WriteLine(item.Nome);
        }
        }
        Console.ReadLine();
    }
}