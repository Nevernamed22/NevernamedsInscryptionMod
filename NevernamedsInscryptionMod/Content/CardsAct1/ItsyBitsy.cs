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
    static class ItsyBitsy
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ItsyBitsy",
                "Itsy Bitsy",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The poor thing is hydrophobic... oh well.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.SplitStrike, SplashDamage.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/itsybitsy.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/itsybitsy_emission.png")
                );
        }
    }
}