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
    static class Caracal
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Caracal",
                "Caracal",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A quizzacious predator, ready to leap at any unsuspecting prey.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/caracal.png"),
                abilities: new List<Ability>() { Ability.GuardDog, PreemptiveStrike.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/caracal_emission.png")
                );
        }
    }
}
