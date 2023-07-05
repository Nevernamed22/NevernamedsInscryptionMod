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
    static class YetiCrab
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed YetiCrab",
                "Yeti Crab",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The pallid yeti crab. It can consume the bacterial colonies along it's claws to regain it's strength.",
                bloodCost: 1,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/yeticrab.png"),
                abilities: new List<Ability>() { Regenerator.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/yeticrab_emission.png")
                );
        }
    }
}
