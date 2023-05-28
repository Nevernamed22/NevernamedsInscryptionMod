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
    static class Tapeworm
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Tapeworm",
                "Tapeworm",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A long, insidious parasite. It causes profound irritation in it's host.",
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/tapeworm.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/tapeworm_emission.png"),
                abilities: new List<Ability>() { AnnoyingLatch.ability },
                tribes: new List<Tribe>() { }
                );
        }
    }
}