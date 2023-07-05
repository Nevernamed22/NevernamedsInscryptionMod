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
            CardSetupUtility.NewCard("Nevernamed Crusher",
                "Crusher",
                1,
                2,
                new List<CardMetaCategory> {  CardMetaCategory.Part3Random, Plugin.P03KayceesUndeadRegion, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                energyCost: 6,
                abilities: new List<Ability>() { Ability.CorpseEater },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/crusher.png")
                );
        }
    }
}