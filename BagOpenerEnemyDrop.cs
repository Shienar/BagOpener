using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Terraria.ModLoader.ModItem;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace BagOpener
{
    public class BagOpenerEnemyDrop : GlobalNPC
	{

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            //Wall of Flesh
            if(npc.type == 113 || npc.type == 114)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BagOpener>(), 1));
            }
        }

    }
}
