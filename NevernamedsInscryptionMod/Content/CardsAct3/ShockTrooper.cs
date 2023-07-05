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
    static class ShockTrooper
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ShockTrooper",
                "Shock Trooper",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { TuckAndRoll.ability, TrophyHunter.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/shocktrooper.png"),
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/shocktrooper_pixel.png")
                );
        }
    }
}