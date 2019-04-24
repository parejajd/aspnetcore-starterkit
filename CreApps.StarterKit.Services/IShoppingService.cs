using CreApps.StarterKit.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreApps.StarterKit.Services
{
    public interface IShoppingCartService
    {
        IEnumerable<ShoppingItem> GetAllItems();
        ShoppingItem Add(ShoppingItem newItem);
        ShoppingItem GetById(Guid id);
        void Remove(Guid id);
    }
}
