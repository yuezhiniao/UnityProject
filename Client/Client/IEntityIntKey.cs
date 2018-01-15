using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public interface IEntityIntKey : IEntity
    {
        int ID { get; set; }
    }
}
