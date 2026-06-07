public class Lista
{
    public No inicio;
    public No fim;

    public Lista()
    {
        this.inicio = null;
        this.fim = null;
    }

    public bool estaVazia()
    {
        return this.inicio == null;
    }

    public void inserirInicio(int valor)
    {
        No novoNo = new No(valor);

        if (estaVazia())
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }

        Console.WriteLine("Valor inserido no início.");
    }

    public void inserirFim(int valor)
    {
        No novoNo = new No(valor);

        if (estaVazia())
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }

        Console.WriteLine("Valor inserido no fim.");
    }

    public void removerInicio()
    {
        if (estaVazia())
        {
            Console.WriteLine("Lista vazia.");
        }
        else if (this.inicio == this.fim)
        {
            this.inicio = null;
            this.fim = null;

            Console.WriteLine("Elemento removido do início.");
        }
        else
        {
            this.inicio = this.inicio.prox;

            Console.WriteLine("Elemento removido do início.");
        }
    }

    public void removerFim()
    {
        if (estaVazia())
        {
            Console.WriteLine("Lista vazia.");
        }
        else if (this.inicio == this.fim)
        {
            this.inicio = null;
            this.fim = null;

            Console.WriteLine("Elemento removido do fim.");
        }
        else
        {
            No atual = this.inicio;

            while (atual.prox != this.fim)
            {
                atual = atual.prox;
            }

            atual.prox = null;
            this.fim = atual;

            Console.WriteLine("Elemento removido do fim.");
        }
    }

    public void imprimir()
    {
        if (estaVazia())
        {
            Console.WriteLine("Lista vazia.");
        }
        else
        {
            No atual = this.inicio;

            while (atual != null)
            {
                Console.Write(atual.valor + " -> ");
                atual = atual.prox;
            }

            Console.WriteLine("NULL");
        }
    }
}