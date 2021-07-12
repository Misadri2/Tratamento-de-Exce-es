using System;

namespace Testes.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {}
        
    }
}