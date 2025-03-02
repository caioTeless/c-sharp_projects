using System;

namespace ProjectSite.Services.Excepetions
{
    public class DbConcurrencyExcepetion : ApplicationException
    {

        public DbConcurrencyExcepetion(string message) : base(message)
        {
        }


    }
}
