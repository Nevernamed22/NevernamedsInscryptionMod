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
    static class ToyRobot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ToyRobot",
                "Toy Robot",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() {  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/toyrobot.png")
                );
        }
    }
}