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
    static class BatBomb
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BurningBat",
                "Burning Bat",
                1,
                2,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/burningbat.png"),
                abilities: new List<Ability>() { Burning.ability, Ability.Flying },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/burningbat_emission.png")
                );

            CardSetupUtility.NewCard("Nevernamed BatBomb",
                "Bat Bomb",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The first... and last time one of my... associates attempted to use living organisms to it's own advantage.",
                bloodCost: 1,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/batbomb.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/batbomb_emission.png"),
                abilities: new List<Ability>() {  Doomed.ability, ExplodingCorpseCustom.ability, GraveyardShift.ability },
                tribes: new List<Tribe>() { },
                traits: new List<Trait>() { Trait.Terrain },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CustomAppearances.TechPaperCardBackground },
                customExplodingCorpseGuts: "BeastNevernamed BurningBat",
                defaultFrozenCard: "BeastNevernamed BurningBat"
                );
        }
    }
}