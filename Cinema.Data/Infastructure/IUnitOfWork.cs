namespace Cinema.Data.Infastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}