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
    static class DungBeetle
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed DungBall",
                "Dung Ball",
                0,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                tribes: new List<Tribe>() {  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/Terrain/dungball.png"),
                abilities: new List<Ability>() { Ability.StrafeSwap, Ability.DebuffEnemy, Remove.ability},
                traits: new List<Trait>() { Trait.Terrain },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.TerrainBackground, CardAppearanceBehaviour.Appearance.TerrainLayout }
                );

            CardSetupUtility.NewCard("Nevernamed DungBeetle",
                "Dung Beetle",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "This everworking beetle proves the ancient fable- that dung always rolls downhill.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dungbeetle.png"),
                abilities: new List<Ability>() { Flighty.ability },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dungbeetle_emission.png"),
                flightyLeaveBehind: "BeastNevernamed DungBall"
                );
        }
    }
}
