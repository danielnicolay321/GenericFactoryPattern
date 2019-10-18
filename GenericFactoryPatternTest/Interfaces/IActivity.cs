namespace GenericFactoryPatternTest.Interfaces
{
    public interface IActivity
    {
        T CreateModel<T>();
    }
}
