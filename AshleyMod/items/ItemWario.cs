using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshleyMod.items
{
  public class ItemWario : CustomItem
  {
    public ItemWario()
      :this(int.MaxValue)
    {

    }

    public ItemWario(int stackSize)
      :base()
    {
      Texture = "wario";

      name = "Wario Item";
      Description = "it's wario!";
      CategoryName = "Bunnelby";
      Category = 4163;
      CategoryColour = Color.White;
      IsPassable = false;
      IsPlaceable = false;
      boundingBox = new Rectangle(0, 0, 64, 64);
      MaxStackSize = stackSize;

      type = "interactive";
    }
  }
}
