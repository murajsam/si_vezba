using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;

namespace BusinessLayer
{
    public class MenuItemBusiness
    {
        private readonly MenuItemRepository menuItemRepository;

        public MenuItemBusiness()
        {
            menuItemRepository = new MenuItemRepository();
        }

        //Vraca spisak svih stavki iz jelovnika
        public List<MenuItem> GetAllMenuItems()
        {
            return menuItemRepository.GetAllMenuItems();
        }

        public List<MenuItem> GetAllMenuItemsFromRange(double priceFrom, double priceTo)
        {
            List<MenuItem> filteredMenuItems = menuItemRepository.GetAllMenuItems()
            .Where(menuItem => menuItem.price > priceFrom && menuItem.price < priceTo)
            .ToList();

            return filteredMenuItems;

        }

        public bool InsertMenuItem(MenuItem menuItem) 
        { 
            return menuItemRepository.InsertMenuItem(menuItem);
        }
    }
}
