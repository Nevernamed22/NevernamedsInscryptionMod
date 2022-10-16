using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Basilisk
    {
        public static void Init()
        {     
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Basilisk",
                "Basilisk",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The grim basilisk. Life withers and dies under it's mere gaze.",
                bloodCost: 3,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Sentry, Ability.Deathtouch },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/basilisk.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {Tribe.Reptile, Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/basilisk_emission.png")
                );
        }
    }
}