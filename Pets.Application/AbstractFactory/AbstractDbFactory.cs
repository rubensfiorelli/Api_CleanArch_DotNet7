using System.Data.Common;

namespace Pets.Application.AbstractFactory
{
    public abstract class AbstractDbFactory
    {
        public abstract DbConnection CreateConnection();
    }
}
