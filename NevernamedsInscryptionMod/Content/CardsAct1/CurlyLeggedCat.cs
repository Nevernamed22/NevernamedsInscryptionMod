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
    static class CurlyLeggedCat
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CurlyLeggedCat",
                "Curly-Legged Cat",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Its twisted legs coil and bend in ways inexplicable. It is full of potential.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/curlyleggedcat.png"),
                abilities: new List<Ability>() { Ability.Sacrificial, Potent.ability },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/curlyleggedcat_emission.png")
                );
        }
    }
}