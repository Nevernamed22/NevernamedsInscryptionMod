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
    static class CodeThief
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CodeThief",
                "Code Thief",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 6,
                abilities: new List<Ability>() { SigilMimic.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/codethief.png")
                );
        }
    }
}