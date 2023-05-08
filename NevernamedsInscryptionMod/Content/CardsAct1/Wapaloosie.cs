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
    static class Wapaloosie
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed WapaloosiePelt",
                "Wapaloosie Pelt",
                0,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.WhackAMole },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wapaloosiepelt.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CustomAppearances.RareTerrainBackground,  CardAppearanceBehaviour.Appearance.TerrainLayout },
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                traits: new List<Trait>() { Trait.Pelt, Trait.Terrain },
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.SpawnLice }
                );

            CardSetupUtility.NewCard("Nevernamed Wapaloosie",
                "Wapaloosie",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The arboreal wapaloosie. Even after death, it's loose skin yearns to climb.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.DrawCopyOnDeath, GraveyardShift.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wapaloosie.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wapaloosie_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                defaultFrozenCard: "BeastNevernamed WapaloosiePelt"
                );
        }
    }
}