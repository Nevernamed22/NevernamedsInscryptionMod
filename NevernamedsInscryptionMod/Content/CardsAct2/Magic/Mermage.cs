using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Mermage
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Mermage",
                "Mermage",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Blue },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Submerge, },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mermage_pixel.png")
                );
        }
    }
}