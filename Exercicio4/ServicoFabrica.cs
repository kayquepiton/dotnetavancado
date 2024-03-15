namespace Fabrica;
public class ServicoFabrica<T> where T : IServico, new()
{
    public T NovaInstancia()
    {
        return new T();
    }
}