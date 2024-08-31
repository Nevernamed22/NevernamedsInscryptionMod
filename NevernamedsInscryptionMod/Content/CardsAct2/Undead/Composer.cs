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
    static class Composer
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed TubularBells",
                "Tubular Bells",
                0,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Undead,
                description: "",
                bonesCost: 1,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { },
                traits: new List<Trait>() { Trait.Terrain },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/tubularbell.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/tubularbell_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/tubularbells_pixel.png")
                );

            CardSetupUtility.NewCard("Nevernamed Composer",
                "Composer",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "A master of the art. Don't interfere with the harmony of his bells, or you'll live to regret it.",
                bonesCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Erratic.ability },
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.Daus },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/composer.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/composer_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/composer_pixel.png"),
                erraticLeaveBehind: "DeadNevernamed TubularBells"
                );
        }
    }
}