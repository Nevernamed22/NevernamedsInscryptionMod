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
    static class YellowSacSpider
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed YellowSacSpider",
                "Yellow-Sac Spider",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The yellow-sac spider's fearsome bite is highly dangerous...",
                bloodCost: 0,
                bonesCost: 3,
                //energyCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/yellowsacspider.png"),
                abilities: new List<Ability>() { Ability.Brittle, Ability.LatchBrittle },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/yellowsacspider_emission.png")
                );
        }
    }
}