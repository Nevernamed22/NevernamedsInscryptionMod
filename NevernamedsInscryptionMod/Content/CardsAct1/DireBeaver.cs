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
    static class DireBeaver
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed DireDam",
                "Dire Dam",
                0,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/diredam.png"),
    emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/diredam_emission.png"),
                abilities: new List<Ability>() { Ability.Sharp },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.TerrainBackground, CardAppearanceBehaviour.Appearance.TerrainLayout },
                traits: new List<Trait>() { Trait.Terrain },
                tribes: new List<Tribe>() { }
                );

            CardSetupUtility.NewCard("Nevernamed DireBeaver",
                "Dire Beaver",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The unkempt dire beaver. It chooses much more... agressive timber for it's dams.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/direbeaver.png"),
                abilities: new List<Ability>() { Ability.CreateDams },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/direbeaver_emission.png"),
                overrideDamID: "BeastNevernamed DireDam"
                );
        }
    }
}