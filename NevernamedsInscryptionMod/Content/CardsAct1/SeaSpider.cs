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
    static class SeaSpider
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SeaSpider",
                "Sea Spider",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The peculiar Sea Spider. Not arachnid, nor crustacean. It's organs are stored in it's legs",
                bloodCost: 1,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/seaspider.png"),
                abilities: new List<Ability>() { Ability.SplitStrike, Ability.Sharp },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/seaspider_emission.png")
                );
        }
    }
}
