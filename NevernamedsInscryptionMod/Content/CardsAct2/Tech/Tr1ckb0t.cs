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
    static class Tr1ckb0t
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Tr1ckb0t",
                "Tr1ckb0t",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 3, 
                abilities: new List<Ability>() { MorphMover.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/tr1ckb0t_pixel.png")
                );
        }
    }
}