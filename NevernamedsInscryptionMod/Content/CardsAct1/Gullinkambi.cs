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
    static class Gullinkambi
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Gullinkambi",
                "Gullinkambi",
                2,
              2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Gullinkambi- cockerel of the end times. When he crows, all is set to perish.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { LashOut.ability, SplashDamage.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gullinkambi.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gullinkambi_emission.png")
                );
        }
    }
}