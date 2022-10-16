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
    static class Labrats
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Labrats",
                "Labrats",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A hideous abomination... any sigils granted to it will shed off as crazed rodents.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() {  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/labrats.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { SigilShedder.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/labrats_emission.png")
                );
        }
    }
}