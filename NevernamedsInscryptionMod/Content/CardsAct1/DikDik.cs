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
    static class DikDik
    {
        public static void Init()
        {
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dikdik.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed DikDik",
                "Dik-Dik",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The miniature Dik-Dik, it is inspired by it's larger hooved kin. Looking directly into it's eyes is profoundly disquieting.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Strafe },
                tribes: new List<Tribe>() { Tribe.Hooved },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                specialAbilities: new List<SpecialTriggeredAbility>() { HerdingBeast.ability },
                variableStat: HerdingBeast.specialStatIcon,
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dikdik_emission.png"),
                flipPortraitWhenStrafing: true,
                defaultEvolutionName: "Big DikDik"
                );
        }
    }
}
