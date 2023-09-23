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
    static class TurtleFrog
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed TurtleFrog",
                "Turtle Frog",
               1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The stoic Turtle Frog betrays few signs of weakness with it's powerful posture.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/turtlefrog.png"),
                abilities: new List<Ability>() { Sturdy.ability },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/turtlefrog_emission.png")
                );
        }
    }
}
