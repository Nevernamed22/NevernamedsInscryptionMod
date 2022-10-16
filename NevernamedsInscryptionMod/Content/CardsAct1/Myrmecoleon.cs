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
    static class Myrmecoleon
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/myrmecoleon.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Myrmecoleon",
                "Myrmecoleon",
                2,
                4,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The vicious myrmecoleon, an aberration of nature. The true Ant Lion.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { AntGuardian.ability, Ability.DrawAnt },
                defaultTex: tex,
                traits: new List<Trait>() { Trait.Ant },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/myrmecoleon_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex }
                );
        }
    }
}