using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class LiliputianSkeleton
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed LiliputianSkeleton",
                "Lilliputian Skeleton",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 1,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/liliputianskeleton_pixel_1.png"),
               specialAbilities: new List<SpecialTriggeredAbility>() { LiliputianPileup.ability }
                );
        }
    }
}