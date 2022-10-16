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
    static class CagedBeasts
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CagedBeasts",
                "Caged Beasts",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Poor, caged animals. Won't you set them free?",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { GiftBearerCustom.ability, GiftBearerCustom.ability, GiftBearerCustom.ability, Abstain.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cagedbeasts.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CustomAppearances.RareTerrainBackground, CardAppearanceBehaviour.Appearance.TerrainLayout },
                traits: new List<Trait>() { Trait.Terrain },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cagedbeasts_emission.png")
                );
        }
    }
}