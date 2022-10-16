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
    static class InfectedAnt
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed InfectedAnt",
                "Infected Ant",
                0,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A poor ant infected with nematode worms. It turns red like a berry to attract predators.",
                bloodCost: 1,
                bonesCost: 0,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/infectedant.png"),
                abilities: new List<Ability>() { Ability.BuffEnemy },
                variableStat: SpecialStatIcon.Ants,
                traits: new List<Trait>() { Trait.Ant},
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.Ant },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/infectedant_emission.png")
                );
        }
    }
}
