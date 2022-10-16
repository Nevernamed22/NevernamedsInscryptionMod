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
    static class Moa
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Moa",
                "Moa",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The tall, imposing moa. It does not let anything impede it's march.",
                bloodCost: 0,
                bonesCost: 4,
                //energyCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/moa.png"),
                abilities: new List<Ability>() { Ability.StrafePush },
                tribes: new List<Tribe>() { Tribe.Bird  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/moa_emission.png")
                );
        }
    }
}