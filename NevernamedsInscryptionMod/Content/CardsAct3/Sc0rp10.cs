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
    static class Sc0rp10
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Sc0rp10ClawLeft",
                "Cl4w",
                1,
                1,
                new List<CardMetaCategory> {  },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() {Claw.ability,  Ability.Sentry },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/scorpioclawleft.png")
                );

            CardSetupUtility.NewCard("Nevernamed Sc0rp10ClawRight",
               "Cl4w",
               1,
               1,
               new List<CardMetaCategory> { },
               CardTemple.Tech,
               description: "",
               bloodCost: 0,
               bonesCost: 0,
               energyCost: 0,
               tribes: new List<Tribe>() { },
               abilities: new List<Ability>() { Claw.ability,  Ability.Sentry },
               defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/scorpioclawright.png")
               );

            CardSetupUtility.NewCard("Nevernamed Sc0rp10",
                "Sc0rp10",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Clawed.ability, Fearsome.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/scorpio.png"),
                overrideLeftClaw: "TechNevernamed Sc0rp10ClawLeft",
                overrideRightClaw: "TechNevernamed Sc0rp10ClawRight"
                );
        }
    }
}