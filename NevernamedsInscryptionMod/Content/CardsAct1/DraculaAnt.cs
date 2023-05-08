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
    static class DraculaAnt
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed DraculaAnt",
                "Dracula Ant",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode },
                CardTemple.Nature,
                description: "The dracula ant... though weak as it may seem, it is no stranger to betraying it's own comrades for strength.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/draculaant.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/draculaant_emission.png"),
                abilities: new List<Ability>() { Gorge.ability },
                tribes: new List<Tribe>() { Tribe.Insect },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
               specialAbilities: new List<SpecialTriggeredAbility> { SpecialTriggeredAbility.Ant },
               variableStat: SpecialStatIcon.Ants,
                traits: new List<Trait>() { Trait.Ant }
               );
        }
    }
}
