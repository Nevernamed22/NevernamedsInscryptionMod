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
    static class Biscione
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Biscione",
                "Biscione",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The vicious biscione, it is insatiable in it's lust for flesh.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Vampiric.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/biscione.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/biscione_emission.png")
                );
        }
    }
}