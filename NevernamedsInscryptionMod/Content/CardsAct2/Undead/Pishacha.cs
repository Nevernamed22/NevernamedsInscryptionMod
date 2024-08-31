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
    static class Pishacha
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Pishacha",
                "Pishacha",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "A vile demon, it rends and gorges itself on the flesh of the unfortunate... the very manifestation of evil.",
                bloodCost: 0,
                bonesCost: 3,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Carnivore.ability },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/pishacha.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/pishacha_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/pishacha_pixel.png")
                );
        }
    }
}