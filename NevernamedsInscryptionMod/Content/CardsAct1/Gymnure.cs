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
    static class Gymnure
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Gymnure",
                "Gymnure",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Despite its welcoming exterior, the Gymnure longs only for a solitary existence.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gymnure.png"),
                abilities: new List<Ability>() { Lonesome.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gymnure_emission.png")
                );
        }
    }
}
