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
    static class EnchantedNightcrawler
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed EnchantedNightcrawler",
                "Enchanted Nightcrawler",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "An earthworm, so stuffed with celestial power that it soaks up magic like a sponge...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/enchantednightcrawler.png"),
                abilities: new List<Ability>() {  },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/enchantednightcrawler_emission.png")
                ).SetExtendedProperty("AlwaysValidForSigilTransfer", "true"); ;
        }
    }
}