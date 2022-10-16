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
    static class MayflySwarm
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MayflySwarm",
                "Mayfly Swarm",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A thick swarm of insects, desperate in their mating flight.",
                bloodCost: 1,
                bonesCost: 0,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mayflyswarm.png"),
                abilities: new List<Ability>() { Ability.Flying, BuzzOff.ability },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mayflyswarm_emission.png")
                );
        }
    }
}
