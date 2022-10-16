using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class CrookedWraith
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed CrookedWraith",
                "Crooked Wraith",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 3,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { CrookedStrikeLeft.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/crookedwraith_pixel.png")
                );
        }
    }
}