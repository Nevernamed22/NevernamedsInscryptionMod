using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class ChiralCrawler
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ChiralCrawler",
                "Chiral Crawler",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 10,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Strafe },
                variableStat: SpecialStatIcon.CardsInHand,
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.CardsInHand },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/chiralcrawler_pixel.png")
                );
        }
    }
}