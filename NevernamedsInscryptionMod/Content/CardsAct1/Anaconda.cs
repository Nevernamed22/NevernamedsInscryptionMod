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
    static class Anaconda
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Anaconda",
                "Anaconda",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Don't... don't say it. I have heard it all before, and it is not funny.",
                bloodCost: 0,
                bonesCost: 6,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/anaconda.png"),
                abilities: new List<Ability>() { UnbalancedLeadership.ability },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/anaconda_emission.png")
                );
        }
    }
}