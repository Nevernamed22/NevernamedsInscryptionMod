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
    static class Unravelled
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Unravelled",
                "Unravelled",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "A poor mummy, not wrapped nearly tight enough. You may make use of the bandages.",
                bloodCost: 0,
                bonesCost: 4,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { BandageWeaver.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/unravelled.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/unravelled_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/unravelled_pixel.png")
                );
        }
    }
}