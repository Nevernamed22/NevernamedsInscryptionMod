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
    static class TurtleMine
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed TurtleMine",
                "Turtle Mine",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, Plugin.P03KayceesNatureRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 4, 
                abilities: new List<Ability>() { Ability.ExplodeOnDeath, Ability.DeathShield },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/turtlemine.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/turtlemine_pixel.png")
                );
        }
    }
}