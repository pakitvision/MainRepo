using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Company.Model;
using Company.DAL;

namespace Company.BLL
{
    public class ItemBLL
    {
        public bool SaveItem(Item item)
        {
            return new ItemDAL().SaveItem(item);
        }
    }
}
