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
    static class Cubit
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Cubit",
                "Cubit",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                tribes: new List<Tribe>() { },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/cubit.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/cubit_pixel.png"),
                abilities: new List<Ability>() { Ability.WhackAMole }
                );
        }
    }
}