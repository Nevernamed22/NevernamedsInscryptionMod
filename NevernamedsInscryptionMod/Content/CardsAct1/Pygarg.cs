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
    static class Pygarg
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pygarg.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Pygarg",
                "Pygarg",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare, },
                CardTemple.Nature,
                description: "The holy pygarg. When sacrificed, it passes it's knowledge unto others.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { InspiringSacrifice.ability, Ability.TripleBlood },
                traits: new List<Trait>() { Trait.Goat },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pygarg_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );
        }
    }
}
