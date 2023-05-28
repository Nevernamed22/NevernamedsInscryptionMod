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
    static class Jumpscare
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Jumpscare",
                "Jumpscare",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 3,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Reach },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/jumpscare_pixel.png")
                );
        }
    }
}