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
    static class InfantBaboon
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed InfantBaboon",
                "Infant Baboon",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A sweet young baboon, unprepared for combat. Youth, lost... such a shame.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/infantbaboon.png"),
                abilities: new List<Ability>() { Ability.Evolve, Coward.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/infantbaboon_emission.png"),
                defaultEvolutionCard: "BeastNevernamed Baboon"
                );
        }
    }
}
