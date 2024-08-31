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
    static class StimulantConduit
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed StimulantConduit",
                "Stimulant Conduit",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.ChoiceNode, Plugin.P03KayceesBastionRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { StimConduit.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/stimulantconduit.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/stimulantconduit_pixel.png")
                );
        }
    }
}