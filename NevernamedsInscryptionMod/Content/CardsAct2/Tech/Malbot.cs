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
    static class Malbot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Malbot",
                 "Mal.Bot",
                 1,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Tech,
                 description: "",
                 energyCost: 2,
                 abilities: new List<Ability>() {BatchDelete.ability, Ability.Brittle },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/malbot_pixel.png")
                 );
        }
    }
}