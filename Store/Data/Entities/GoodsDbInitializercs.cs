using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Store.Data.Entities
{
    public class GoodsDbInitializercs : DropCreateDatabaseAlways<StoreContext>
    {
        protected void Seed(StoreContext db)
        {
            db.Goods.Add(new Goods(1,"defaultCode","defaultName", 2.0));
            base.Seed(db);
        }
    }
}
