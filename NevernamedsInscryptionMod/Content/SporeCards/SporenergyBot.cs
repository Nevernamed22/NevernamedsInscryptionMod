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
    static class SporenergyBot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SporenergyBot",
                "Sporenergy Bot",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 2,
                abilities: new List<Ability>() { Ability.GainBattery, Ability.GainBattery },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/SporeCards/sporenergybot_pixel.png")
                );
        }
    }
}