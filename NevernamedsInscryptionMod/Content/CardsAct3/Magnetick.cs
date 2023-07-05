using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using NevernamedsSigils;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Magnetick
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Magnetick",
                "Magnetick",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 5,
                abilities: new List<Ability>() { Ability.Strafe, Allure.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/magnetick.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/magnetick_pixel.png")
                );
        }
    }
}