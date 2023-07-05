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
    static class Necravager
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Necravager",
                "Necravager",
               1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 2,
                abilities: new List<Ability>() { Trapjaw.ability, Ability.Brittle },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/necravager_pixel.png")
                );
        }
    }
}