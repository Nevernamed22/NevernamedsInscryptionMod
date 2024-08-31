using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class TerribilePescecane
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed TerribilePescecane",
                "Terribile Pescecane",
                4,
                12,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The great and terrible dogfish, the conquering Attila of fish and fishermen. No sailor nor beast can avoid it.",
                bloodCost: 4,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/monstro.png"),
                abilities: new List<Ability>() { Giant.ability },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/monstro_emission.png")
                );
        }
    }
}