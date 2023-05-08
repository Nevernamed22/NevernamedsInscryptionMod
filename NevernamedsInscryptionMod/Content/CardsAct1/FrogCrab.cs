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
    static class FrogCrab
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed FrogCrab",
                "Frog Crab",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "An unusual topheavy crustacean... it is hard to tell if it is more akin to a lobster or a crab.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/frogcrab.png"),
                abilities: new List<Ability>() { Diver.ability, Trapjaw.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/frogcrab_emission.png")
                );
        }
    }
}
