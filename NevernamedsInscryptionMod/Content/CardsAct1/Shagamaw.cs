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
    static class Shagamaw
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Shagamaw",
                "Shagamaw",
                3,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The peculiar toteroad shagamaw... it alternates between it's two pairs of legs as it roams.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { TransformerCustom.ability, Ability.Strafe },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/shagamaw.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/shagamaw_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Hooved },
                transformerForm: "BeastNevernamed ShagamawFlipped"
                );

            CardSetupUtility.NewCard("Nevernamed ShagamawFlipped",
                "Shagamaw",
                2,
                2,
                new List<CardMetaCategory> {},
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { TransformerCustom.ability, SplashDamage.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/shagamawflipped.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/shagamawflipped_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Hooved },
                transformerForm: "BeastNevernamed Shagamaw"
                );
        }
    }
}