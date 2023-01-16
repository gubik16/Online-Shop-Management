using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemExplorer
{
    /// <summary>
    /// Should be inherited by class that you want to display in ItemExplorer
    /// </summary>
    public interface IItem
    {
        int Id { get; set; }

        /// <summary>
        /// Item's name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Byte array that represent item image
        /// </summary>
        byte[] Img { get; set; }
    }
}
