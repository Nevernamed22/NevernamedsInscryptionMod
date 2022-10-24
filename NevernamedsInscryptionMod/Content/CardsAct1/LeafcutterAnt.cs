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
    static class LeafcutterAnt
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed LeafyBarricade",
                "Leafy Barricade",
                0,
                1,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/leafybarricade.png"),
                abilities: new List<Ability>() {  },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.TerrainBackground, CardAppearanceBehaviour.Appearance.TerrainLayout },
                traits: new List<Trait>() { Trait.Terrain },
                tribes: new List<Tribe>() { }
                );

            CardSetupUtility.NewCard("Nevernamed LeafcutterAnt",
                "Leafcutter Ant",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The industrious leafcutter ant. It produces protective structures with it's unique skills.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/leafcutterant.png"),
                abilities: new List<Ability>() { Ability.CreateDams },
                tribes: new List<Tribe>() { Tribe.Insect },
                variableStat: SpecialStatIcon.Ants,
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.Ant },
                traits: new List<Trait>() { Trait.Ant },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/leafcutterant_emission.png"),
                overrideDamID: "BeastNevernamed LeafyBarricade"
                );
        }
    }
}