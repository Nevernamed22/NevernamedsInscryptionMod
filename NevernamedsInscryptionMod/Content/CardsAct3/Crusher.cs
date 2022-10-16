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
    static class Crusher
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Crusher",
                "Crusher",
                1,
                2,
                new List<CardMetaCategory> {  CardMetaCategory.Part3Random, Plugin.P03KayceesUndeadRegion },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.CorpseEater },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/crusher.png")
                );
        }
    }
}