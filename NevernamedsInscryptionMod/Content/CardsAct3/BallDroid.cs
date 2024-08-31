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
    static class BallDroid
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BallDroidBall",
                "Ball Droid",
                0,
                3,
                new List<CardMetaCategory> {  },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { TransformerCustom.ability, Leaper.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/balldroidball.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/balldroidball_pixel.png"),
                flipPortraitWhenStrafing: true,
               transformerForm: "TechNevernamed BallDroid"
                );

            CardSetupUtility.NewCard("Nevernamed BallDroid",
                "Ball Droid",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { TransformerCustom.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/balldroid.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/balldroid_pixel.png"),
               transformerForm: "TechNevernamed BallDroidBall"
                );
        }
    }
}