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
    static class Submachine
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Submachine",
                "Submachine",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, Plugin.P03KayceesNatureRegion, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                energyCost: 5,
                tribes: new List<Tribe>() { },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/submachine.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/submachine_pixel.png"),
                abilities: new List<Ability>() { Ability.Submerge }
                );
        }
    }
}