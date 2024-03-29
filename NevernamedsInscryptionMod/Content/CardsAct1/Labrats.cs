﻿using APIPlugin;
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
            CardSetupUtility.NewCard("Nevernamed Ratling",
               "Ratling",
               1,
               1,
               new List<CardMetaCategory> { },
               CardTemple.Nature,
               tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
               description: "",
               defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ratling.png"),
               emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ratling_emission.png")
               );

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
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                specialAbilities: new List<SpecialTriggeredAbility>() { SigilShedder.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/labrats_emission.png"),
                sigilShedderDef: "BeastNevernamed Ratling"
                );
        }
    }
}