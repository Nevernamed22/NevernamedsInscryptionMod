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
    static class SpiderMonkey
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SpiderMonkey",
                     "Spider Monkey",
                     2,
                     1,
                     new List<CardMetaCategory> { CardMetaCategory.Rare },
                     CardTemple.Nature,
                     description: "Never trust a monkey.",
                     bloodCost: 2,
                     bonesCost: 0,
                     abilities: new List<Ability>() { Venator.ability },
                     defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey1.png"),
                     emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey1_emission.png"),
                     appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                     tribes: new List<Tribe>() { },
                     venatorForm: "BeastNevernamed SpiderMonkey2"
                     );

            CardSetupUtility.NewCard("Nevernamed SpiderMonkey2",
                     "Spider Monkey",
                     2,
                     1,
                     new List<CardMetaCategory> {  },
                     CardTemple.Nature,
                     description: "Never trust a monkey.",
                     bloodCost: 2,
                     bonesCost: 0,
                     abilities: new List<Ability>() { Venator.ability, Ability.SplitStrike },
                     defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey2.png"),
                     emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey2_emission.png"),
                     appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                     tribes: new List<Tribe>() { },
                     venatorForm: "BeastNevernamed SpiderMonkey3"
                     );

            CardSetupUtility.NewCard("Nevernamed SpiderMonkey3",
                     "Spider Monkey",
                     2,
                     1,
                     new List<CardMetaCategory> { },
                     CardTemple.Nature,
                     description: "Never trust a monkey.",
                     bloodCost: 2,
                     bonesCost: 0,
                     abilities: new List<Ability>() { Venator.ability, Ability.TriStrike },
                     defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey3.png"),
                     emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey3_emission.png"),
                     appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                     tribes: new List<Tribe>() { },
                     venatorForm: "BeastNevernamed SpiderMonkey4"
                     );

            CardSetupUtility.NewCard("Nevernamed SpiderMonkey4",
                     "Spider Monkey",
                     2,
                     1,
                     new List<CardMetaCategory> { },
                     CardTemple.Nature,
                     description: "Never trust a monkey.",
                     bloodCost: 2,
                     bonesCost: 0,
                     abilities: new List<Ability>() { Venator.ability, PinnacleStrike.ability },
                     defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey4.png"),
                     emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey4_emission.png"),
                     appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                     tribes: new List<Tribe>() { },
                     venatorForm: "BeastNevernamed SpiderMonkey5"
                     );

            CardSetupUtility.NewCard("Nevernamed SpiderMonkey5",
                     "Spider Monkey",
                     2,
                     1,
                     new List<CardMetaCategory> {  },
                     CardTemple.Nature,
                     description: "Never trust a monkey.",
                     bloodCost: 2,
                     bonesCost: 0,
                     abilities: new List<Ability>() { PinnacleStrike.ability, Ability.DoubleStrike },
                     defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey5.png"),
                     emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spidermonkey5_emission.png"),
                     appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                     tribes: new List<Tribe>() { }
                     );
        }
    }
}