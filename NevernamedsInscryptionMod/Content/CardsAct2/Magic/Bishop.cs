using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Bishop
    {
        public static void Init()
        {
            // Add the card
           CardSetupUtility.NewCard("Nevernamed Bishop",
                "Bishop",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Green, GemType.Orange },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.SplitStrike, Ability.BuffEnemy },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bishop_pixel.png")
                );
        }
    }
}