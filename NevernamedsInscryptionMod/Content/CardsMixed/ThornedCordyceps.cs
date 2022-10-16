using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class ThornedCordyceps
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed ThornedCordyceps",
                "Thorned Cordyceps",
                0,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "This particular species of cordyceps bears a much more pronounced- and dangerous- fruiting body... Insects can't seem to resist...",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thornedcordyceps.png"),
                abilities: new List<Ability>() { Ability.Sharp, Ability.CorpseEater },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thornedcordyceps_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                specialAbilities: new List<SpecialTriggeredAbility>() { CreateCopyOnInsects.ability }
                );
        }
    }
}