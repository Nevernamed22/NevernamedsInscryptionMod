using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class Skvader
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Skvader",
                "Skvader",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The nimble skvader, rarely seen and even more rarely believed.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/skvader.png"),
                abilities: new List<Ability>() { Ability.Flying, Leaper.ability },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/skvader_emission.png")
                ).SetExtendedProperty("LeaperLeaveBehind", "Tail_Bird");
        }
    }
}