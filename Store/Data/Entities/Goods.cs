using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Data.Entities
{
    public class Goods
    {
        public Goods (int _Id, string _Code, string _Name, double _Count)
        {
            Id = _Id; Code = _Code; Name = _Name; Count = _Count; 
        }

        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public double Count { get; set; }

        public string GetCount(string _Code)
        {
            return DataBase.GetAnser(question);
        }


    }
}
