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
    static class Macaque
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Macaque",
                "Macaque",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A mischevious ape. It will not hesitate to steal from your deck.",
                bloodCost: 1,
                bonesCost: 0,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macaque.png"),
                abilities: new List<Ability>() { DeathSnatch.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macaque_emission.png")
                );
        }
    }
}
