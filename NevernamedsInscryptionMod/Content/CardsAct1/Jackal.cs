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
    static class Jackal
    {
        public static void Init()
        {
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/jackal.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Jackal",
                "Jackal",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The fierce jackal. It hunts in packs with it's canine brethren.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                tribes: new List<Tribe>() { Tribe.Canine },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                variableStat: PackHunter.specialStatIcon,
                specialAbilities: new List<SpecialTriggeredAbility>() { PackHunter.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/jackal_emission.png")
                );
        }
    }
}
