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
    static class Loris
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Loris",
                "Loris",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The diminutive, unwashed loris. It clambers, with purpose through the trees...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/loris.png"),
                abilities: new List<Ability>() { Ability.GuardDog, Ability.DebuffEnemy },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/loris_emission.png")
                );
        }
    }
}
