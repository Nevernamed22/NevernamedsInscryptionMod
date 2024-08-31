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
    static class Pricolici
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Pricolici",
                "Pricolici",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "What a delightful creature- the result of a poor soul being both a werewolf and a vampire at once! Truly marvelous.",
                bloodCost: 0,
                bonesCost: 9,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.DoubleStrike, Ability.GainAttackOnKill },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/pricolici.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/pricolici_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/pricolici_pixel.png")
                );
        }
    }
}