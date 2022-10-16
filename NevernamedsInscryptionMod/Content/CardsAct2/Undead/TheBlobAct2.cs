using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class TheBlobAct2
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed TheBlobAct2",
                "The Blob",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "That terrifying sludge, it never ceases to expand. Beware of the blob.",
                bloodCost: 0,
                bonesCost: 4,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { ContinualEvolution.ability },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/theblob_pixel.png")
                );
        }
    }
}
