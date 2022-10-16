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
    static class Kuchipatchi
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Kuchipatchi",
                "Kuchipatchi",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Do you plan to take care of it?...",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Incontinent.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kuchipatchi.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kuchipatchi_emission.png")
                );
        }
    }
}