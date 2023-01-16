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
    public interface IItemEditor
    {
        /// <summary>
        /// Indicates whether the item was successfully edited.
        /// </summary>
        bool ItemModified { get; set; }

        /// <summary>
        /// Should edit passed item
        /// </summary>
        /// <param name="item">item to be edited</param>
        /// <returns>Edited item</returns>
        IItem EditItem(IItem item);
    }
}
