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
    static class Ribcage
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Ribcage",
                "Ribcage",
              1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 7,
                abilities: new List<Ability>() { Snare.ability, Ability.WhackAMole },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ribcage_pixel.png")
                );
        }
    }
}