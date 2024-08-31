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
    static class Hornet
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed StrangeHornet",
                "Strange Hornet",
                2,
                3,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/strangehornet.png"),
                abilities: new List<Ability>() { Ability.Sharp, Piercing.ability },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/strangehornet_emission.png")
                );

            CardSetupUtility.NewCard("Nevernamed Hornet",
                "Hornet",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The bitter hornet, able to inflict far above its weight in pain.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hornet.png"),
                abilities: new List<Ability>() { Ability.Flying, Ability.Sharp },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hornet_emission.png"),
                defaultEvolutionCard: "BeastNevernamed StrangeHornet"
                );
        }
    }
}