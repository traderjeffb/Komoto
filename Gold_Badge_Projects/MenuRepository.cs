using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gold_Badge_Projects;

namespace Gold_Badge_Projects
{
    class MenuRepository
    {
        protected readonly List<Menu> _menu = new List<Menu>();

        //CRUD

        //CREATE
        public bool AddToMenu(Menu content)
        {
            int startingCount = _menu.Count;
            _menu.Add(content);
            bool wasAdded = (_menu.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //READ
        public Menu GetMenuItemByMenuName(string mealName)
        {
            foreach (Menu content in _menu)
            {
                if (content.MealName.ToLower() == mealName.ToLower())
                {
                    return content;
                }
            }
            return null;
        }


        //SHOW ALL MENU ITEMS
        //GetMenuItemsAll(int mealNumber, string mealName, string mealDescription, string ingredients, float price )
        public List<Menu> GetContents()
        {
            return _menu;
        }

        public List<Menu> ShowAllMenuItems()
        {
            List<Menu> allMenuItems = new List<Menu>();
            foreach (Menu content in _menu)
            {
                if(content is Menu)
                {
                    allMenuItems.Add((Menu)content);
                }
            }
            return allMenuItems;
        }

        //DELETE
        public bool DeleteExistingMenuItem(Menu existingContent)
        {
            bool deleteResult = _menu.Remove(existingContent);
            return deleteResult;
        }

        public void SeedMenuItemsList()
        {
            Menu menuItem1 = new Menu(int.Parse("1"), "Chicken", "Chicken with garlic sauce", "Chicken,peas,rice, sauce",int.Parse("12.50"));
            Menu menuItem2 = new Menu(int.Parse("2"), "Beef", "Beef with garlic sauce", "Beef,peas,rice, sauce", int.Parse("13.50"));
            Menu menuItem3 = new Menu(int.Parse("1"), "Pork", "Pork with garlic sauce", "Pork,peas,rice, sauce", int.Parse("10.50"));
        }
    }
}
