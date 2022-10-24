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
    static class Warg
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Warg",
                "Warg",
                2,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The vicious Warg, it becomes emboldened with every kill...",
                bloodCost: 3,
                bonesCost: 0,
                abilities: new List<Ability>() { Ravenous.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/warg.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/warg_emission.png")
                );
        }
    }
}