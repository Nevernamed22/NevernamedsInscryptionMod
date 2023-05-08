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
    static class Roperite
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Roperite",
                "Roperite",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The swift and deadly roperite, it snares prey in it's looped beak.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Tug.ability, Bloodbait.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/roperite.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/roperite_emission.png")
                );
        }
    }
}