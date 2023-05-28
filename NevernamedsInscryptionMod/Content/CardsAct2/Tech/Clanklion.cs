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
    static class Clanklion
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Clanklion",
                "Clanklion",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { Allure.ability, Ability.SteelTrap },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/clanklion_pixel.png")
                );
        }
    }
}