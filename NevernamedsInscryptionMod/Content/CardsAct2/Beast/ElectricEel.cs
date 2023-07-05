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
    static class ElectricEel
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ElectricEel",
                "Electric Eel",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                bonesCost: 0,
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/electriceel_pixel.png"),
                abilities: new List<Ability>() { Ability.ConduitNull },
                tribes: new List<Tribe>() {  }
                );
        }
    }
}
