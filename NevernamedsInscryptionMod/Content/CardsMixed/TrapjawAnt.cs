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
    static class TrapjawAnt
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/trapjawant.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed TrapjawAnt",
                "Trapjaw Ant",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode },
                CardTemple.Nature,
                description: "The mighty Trapjaw. If unobstructed, it's mantibles will snap shut on the creature opposing it, with a sickening pincer attack.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Trapjaw.ability },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/trapjawant_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
               specialAbilities: new List<SpecialTriggeredAbility> { SpecialTriggeredAbility.Ant },
               variableStat: SpecialStatIcon.Ants,
                traits: new List<Trait>() { Trait.Ant }
               );
        }
    }
}
