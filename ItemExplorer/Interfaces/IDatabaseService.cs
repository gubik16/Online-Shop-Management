using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemExplorer
{
    public interface IDatabaseService
    {
        /// <summary>
        /// Should receive object that inherits IItem interface and save it to database
        /// </summary>
        /// <param name="item">item to be removed</param>
        void AddItem(IItem item);

        /// <summary>
        /// Should delete item from database
        /// </summary>
        /// <param name="id">id of item that should be removed</param>
        void Remove(int id);

        /// <summary>
        /// Should receive object that inherits IItem interface and edit it's instance in database
        /// </summary>
        /// <param name="item">item to be edited</param>
        void Edit(IItem item);

        /// <summary>
        /// Should return collection of all items from database
        /// </summary>
        /// <returns></returns>
        IEnumerable<IItem> GetAllItems();
    }
}
