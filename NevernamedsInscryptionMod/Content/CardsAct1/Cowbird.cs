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
    static class Cowbird
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Cowbird",
                "Cowbird",
                0,
               0,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Too cowardly to remain for long, the cowbird is always eager to cause trouble.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cowbird.png"),
                abilities: new List<Ability>() { Ability.CreateEgg, InstantEffect.ability },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.TerrainLayout, CustomAppearances.InstantEffectBackground},
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cowbird_emission.png")
                );
        }
    }
}
