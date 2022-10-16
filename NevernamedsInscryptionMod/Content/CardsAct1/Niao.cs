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
    static class Niao
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Niao",
                "Niao",
                0,
                0,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The iconic Niao. It's particular style of mockery is far more long lasting.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Mockery.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/niao.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/niao_emission.png")
                );
        }
    }
}