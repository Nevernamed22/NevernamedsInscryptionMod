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
    static class BodySnatcher
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BodySnatcher",
                "Body Snatcher",
               0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 1,
                abilities: new List<Ability>() { Ability.OpponentBones },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bodysnatcher_pixel.png")
                );
        }
    }
}