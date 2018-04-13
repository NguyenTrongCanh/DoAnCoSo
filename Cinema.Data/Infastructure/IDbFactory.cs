using System;

namespace Cinema.Data.Infastructure
{
    public interface IDbFactory : IDisposable
    {
        DoAnCoSoDbContext Init();
    }
}