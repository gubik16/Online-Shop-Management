using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemExplorer
{
    /// <summary>
    /// Should be inherited by form or class that is used to edit items
    /// </summary>
    public interface IItemCreator
    {
        /// <summary>
        /// Indicates whether the item was successfully created.
        /// </summary>
        bool ItemCreated { get; set; }

        /// <summary>
        /// Should create new item
        /// </summary>
        /// <returns>Created item</returns>
        IItem CreateItem();
    }
}
