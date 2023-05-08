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
    static class Snoligoster
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Snoligoster",
                "Snoligoster",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The brutal snoligoster... it flies through the marshland on it's propellor-fins.",
                bloodCost: 2,
                bonesCost: 3,
                abilities: new List<Ability>() { Ability.Submerge, RunningStrike.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/snoligoster.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/snoligoster_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/snoligoster_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile }

                );
        }
    }
}