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
    static class StrangeTurtle
    {
        public static void Init()
        {
          CardInfo inf =  CardSetupUtility.NewCard("Nevernamed StrangeTurtle",
                "Strange Turtle",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "What an odd reptile...",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.DeathShield },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/strangeturtle.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/strangeturtle_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                specialAbilities: new List<SpecialTriggeredAbility>() { InherentCardOnHit.ability }
                );
            inf.SetExtendedProperty("InherentCardOnHitDef", "BeastNevernamed LittleTurtle");

            CardSetupUtility.NewCard("Nevernamed LittleTurtle",
                "Little Turtle",
                1,
                1,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/littleturtle.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/littleturtle_emission.png"),
                abilities: new List<Ability>() { Ability.DeathShield },
                tribes: new List<Tribe>() { Tribe.Reptile }
                );
        }
    }
}