namespace GenericFactoryPatternTest.Interfaces
{
    public interface IActivity
    {
        T ReturnModel<T>(int id, string docname);
    }
}
