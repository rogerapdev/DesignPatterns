namespace AbstractFactoryPattern.Interfaces
{
    // Abstract Factory
    public interface ITelemovel
    {
        ISmartPhone BuscarSmartPhone();

        INormalPhone BuscarNormalPhone();

    }
}
