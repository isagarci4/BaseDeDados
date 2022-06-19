namespace BaseDeDados.Acesso;

public class AcessoManager
{
    Queue<string> fila = new Queue<string>();
    public void AdicionarAcessoParaUsuario()
    {
        Console.WriteLine("Digite o usuario para acesso");
        var user = Console.ReadLine();
        fila.Enqueue(user);
        Console.WriteLine("Pedido para acesso feito com sucesso!");
        Console.ReadLine();
    }

    public void LiberarPrimeiroAcessoDaFila()
    {
         if(fila.Count() == 0){
            Console.WriteLine("Não há nenhum usuário para acesso");
            Console.ReadLine();
         }
         else{
            Console.WriteLine("Acessando agora: " + fila.Dequeue());
            var nextQueue = fila.Count() > 0 ? "Próximo da fila: " + fila.Peek() + "\nRestantes: " + fila.Count() : "\nNão há mais ninguém para acesso";
            Console.WriteLine(nextQueue);
            Console.ReadLine();
         }
    }

    public void RemoverPrimeiroAcessoDaFila()
    {
        if (fila.Count() <= 0)
        {
            Console.WriteLine("Não há nenhum usuário para remover acesso");
        }
        else{
            Console.WriteLine($"Acesso de {fila.Dequeue()} removido");
        }
        Console.ReadLine();
    }

    public void LiberarTodosOsAcessosDaFila()
    {
        if (fila.Count() <= 0)
        {
            Console.WriteLine("Não há usuário para liberar o acesso");
        }
        else{
            while (fila.Count() != 0)
            {
                Console.WriteLine($"Acesso de {fila.Dequeue()} liberado");
            }
        }
        Console.ReadLine();
    }
}