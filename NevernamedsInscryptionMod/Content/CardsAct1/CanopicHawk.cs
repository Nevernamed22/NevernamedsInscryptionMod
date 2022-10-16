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
    static class CanopicHawk
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CanopicHawk",
                "Canopic Hawk",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A delicate ceramic bird, full of guts...",
                bloodCost: 0,
                bonesCost: 2,
                abilities: new List<Ability>() { GutSpewer.ability, GutSpewer.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/canopichawk.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/canopichawk_emission.png")
                );
        }
    }
}