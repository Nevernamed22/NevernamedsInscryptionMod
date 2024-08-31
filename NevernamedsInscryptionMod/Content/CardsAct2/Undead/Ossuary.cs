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
    static class Ossuary
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Ossuary",
                "Ossuary",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "Vicious thing builds itself from the scraps of others shredded lives...",
                bloodCost: 0,
                bonesCost: 7,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { FilterFeeder.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/ossuary.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/ossuary_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ossuary_pixel.png")
                );
        }
    }
}