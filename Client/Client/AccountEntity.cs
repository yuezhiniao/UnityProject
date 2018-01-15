using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [Serializable]
    public class AccountEntity : IEntityIntKey
    {
        public virtual int ID { get; set; }
        public virtual  string Name { get; set; }
        public virtual  string Password { get; set; }
        public virtual bool IsLogin { get; set; }
        public  virtual DateTime LoginTime { get; set; }
        public virtual DateTime LogouTime { get; set; }





    }
}
