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
    static class Sporren
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Sporren",
                "Sporren",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "",
               bloodCost: 1,
                abilities: new List<Ability>() { Ability.DrawRabbits, Ability.DrawRabbits },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/SporeCards/sporren_pixel.png")
                );
        }
    }
}