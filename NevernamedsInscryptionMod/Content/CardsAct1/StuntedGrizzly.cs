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
    static class StuntedGrizzly
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed StuntedGrizzly",
                "Stunted Grizzly",
               4,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Such a poor, scarred beast- what must have befallen it?.",
                bonesCost: 8, //Six light, two bones in final ver
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/stuntedgrizzly.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/stuntedgrizzly_emission.png"),
                abilities: new List<Ability>() { },
                tribes: new List<Tribe>() { }
                );
        }
    }
}