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
    static class Locust
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/locust.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Locust",
                "Locust",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A swarm of hungry locusts... it's fecundity can never be quelled...    ...do not test me [c:bR]Kaycee[c:].",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/locust_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                specialAbilities: new List<SpecialTriggeredAbility>() { InherentFecundity.ability  }
                );
        }
    }
}