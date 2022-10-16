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
    static class AderynYCorph
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed AderynYCorph",
                "Aderyn Y corph",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The corpse bird. It's appearance portends the end.",
                bloodCost: 0,
                bonesCost: 5,
                abilities: new List<Ability>() { GiftBearerCustom.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/aderynycorph.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/aderynycorph_emission.png")
                );
        }
    }
}