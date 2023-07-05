using System;
using System.Collections.Generic;
using APIPlugin;
using DiskCardGame;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class Rover
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Rover",
                "Rover",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { Ability.Strafe, Ability.Sentry },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/rover.png"),
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/rover_pixel.png")
                );
        }
    }
}