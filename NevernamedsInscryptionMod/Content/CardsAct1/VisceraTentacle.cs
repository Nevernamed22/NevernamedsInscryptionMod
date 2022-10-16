using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using System.Linq;

namespace NevernamedsInscryptionMod
{
    static class VisceraTentacle
    {
        public static void Init()
        {
            Texture2D title = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/tentacle_title.png");
            title.filterMode = FilterMode.Point;

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/visceratentacle.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed VisceraTentacle",
                "Viscera Tentacle",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "What on earth... who slipped this into my cards?",
                bloodCost: 1,
                bonesCost: 1,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/visceratentacle_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                specialAbilities: new List<SpecialTriggeredAbility>() { BloodAndBone.ability },
                variableStat: BloodAndBone.specialStatIcon,
                titleGraphic: title
                );

         /*List<string> squids =   SubmergeSquid.SQUIDS.ToList();
            squids.Add("Nevernamed VisceraTentacle");
            SubmergeSquid.SQUIDS = squids.ToArray();*/
        }
    }
}
