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
    static class ManTis
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/manmantis.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed ManTis",
                "Man-Tis",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "A cruel fusion between man and insect... did the Mycologists create this? It does not bear signs of their handiwork...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { TrophyHunter.ability, Ability.DoubleStrike },
                tribes: new List<Tribe>() { Tribe.Insect },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mantis_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/manmantis_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                defaultEvolutionName: "Woman-Tis"
                );
        }
    }
}