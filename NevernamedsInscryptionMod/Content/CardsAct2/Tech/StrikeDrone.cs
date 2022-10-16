using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class StrikeDrone
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed StrikeDrone",
                "Strike Drone",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Sniper, Ability.Deathtouch },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/strikedrone_pixel.png")
                );
        }
    }
}