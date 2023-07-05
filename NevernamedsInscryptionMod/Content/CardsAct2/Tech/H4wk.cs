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
    static class H4wk
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed H4wk",
                "H4wk",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Flying },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/h4wk_pixel.png")
                );
        }
    }
}