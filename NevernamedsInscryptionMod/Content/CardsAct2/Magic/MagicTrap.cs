using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class MagicTrap
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed MagicTrap",
                "Magic Trap",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                gemsCost: new List<GemType>() { GemType.Orange },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.SteelTrap },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/magictrap_pixel.png")
                );
        }
    }
}