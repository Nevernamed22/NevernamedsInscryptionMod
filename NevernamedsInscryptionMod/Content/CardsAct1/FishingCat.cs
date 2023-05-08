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
    static class FishingCat
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed FishingCat",
                "Fishing Cat",
                3,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The stoic Fishing Cat. It lurks near the water, waiting for prey.",
                bloodCost: 2,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fishingcat.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fishingcat_emission.png"),
                abilities: new List<Ability>() { TransformerCustom.ability, Ability.GuardDog },
                tribes: new List<Tribe>() {},
                transformerForm: "BeastNevernamed FishingCatSubmerged"
                );

            CardSetupUtility.NewCard("Nevernamed FishingCatSubmerged",
                "Fishing Cat",
                4,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fishingcat.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fishingcat_emission.png"),
                abilities: new List<Ability>() { TransformerCustom.ability, CoastGuard.ability },
                tribes: new List<Tribe>() {  },
                transformerForm: "BeastNevernamed FishingCat"
                );         
        }
    }
}