using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models.Contexto
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {

        }

        public System.Data.Entity.DbSet<Web.Models.TipoItem> TipoItems { get; set; }

        public System.Data.Entity.DbSet<Web.Models.Item> Items { get; set; }
    }
}