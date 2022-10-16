using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class FearGorta
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed FearGorta",
                "Fear Gorta",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.GainAttackOnKill },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/feargorta_pixel.png")
                );
        }
    }
}