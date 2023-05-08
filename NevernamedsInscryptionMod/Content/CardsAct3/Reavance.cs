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
    static class Reavance
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Reavance",
                "Reavance",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, Plugin.P03KayceesUndeadRegion, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Eager.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/reavance.png")
                );
        }
    }
}