using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Terraria.ModLoader.ModItem;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace BagOpener
{
    public class BagOpener : ModItem
	{
        public override string Texture => "BagOpener/Sprite";

        public override void UpdateInventory (Player player)
        {
            
            //Iterate over each item in the player's inventory.
            //Indexes 50-58 cover coin/ammo slots and the item being moved by the mouse within the inventory. They are skipped over.
            for(int i = 0; i < 50; i++)
            {
                //Checks if the item is openable.
                //TODO: Is there a need to account for any mod items that can be right clicked in inventory but aren't openable?
                if (ItemLoader.CanRightClick(player.inventory[i]))
                {
                    //Give appropriate items
                    player.DropFromItem(player.inventory[i].type);
                    
                    //Decreases stack, plays noise, etc.
                    ItemLoader.RightClick(player.inventory[i], player);            
                }
            }

        }


    }
}
