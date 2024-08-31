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
    static class Camel
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Camel",
                "Camel",
                3,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The stocky camel, it is resilient against most any threat",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/camel.png"),
                abilities: new List<Ability>() { Resilient.ability },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/camel_emission.png")
                );
        }
    }
}
