using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Bakunawa
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Bakunawa",
                "Bakunawa",
                4,
                4,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The lengthy Bakunawa, terror of the sea and skies.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Submerge, Ability.StrafeSwap, Ability.Flying, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bakunawa.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bakunawa_emission.png")
                );
        }
    }
}