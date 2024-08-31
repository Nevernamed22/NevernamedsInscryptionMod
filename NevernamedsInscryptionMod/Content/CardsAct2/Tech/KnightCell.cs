using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class KnightCell
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed KnightCell",
                "Knight Cell",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.ChoiceNode, Plugin.P03KayceesBastionRegion  },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { SplashDamageWhenPowered.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/knightcell.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/knightcell_pixel.png")
                );
        }
    }
}