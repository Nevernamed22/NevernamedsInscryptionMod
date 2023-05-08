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
    static class Calygreyhound
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Calygreyhound",
                "Calygreyhound",
                3,
               2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The calygreyhound- a confusing chimeric clash which nonetheless stirs the loyalties of it's comrades.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Herald.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/calygreyhound.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/calygreyhound_emission.png")
                );
        }
    }
}