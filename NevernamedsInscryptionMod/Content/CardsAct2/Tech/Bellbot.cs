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
    static class Bellbot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Bellbot",
                "Bellbot",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() {  },
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.BellProximity},
                variableStat: SpecialStatIcon.Bell,
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bellbot_pixel.png")
                );
        }
    }
}