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
    static class Tallock
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Tallock",
                "Tallock",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Green },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Reach },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/tallock_pixel.png")
                );
        }
    }
}