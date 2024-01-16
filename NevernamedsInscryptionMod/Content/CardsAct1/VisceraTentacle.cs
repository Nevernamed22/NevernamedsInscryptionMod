using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using System.Linq;
using InscryptionAPI.Card;

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
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "What on earth... who slipped this into my cards?",
                bloodCost: 1,
                bonesCost: 1,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                tribes: new List<Tribe>() { },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/visceratentacle_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/visceratentacle_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                specialAbilities: new List<SpecialTriggeredAbility>() { BloodAndBone.ability },
                variableStat: BloodAndBone.specialStatIcon,
                titleGraphic: title
                ).SetExtendedProperty("ValidSquidTentacleAct1", "true").SetExtendedProperty("ValidSquidTentacleAct2", "true");

         /*List<string> squids =   SubmergeSquid.SQUIDS.ToList();
            squids.Add("Nevernamed VisceraTentacle");
            SubmergeSquid.SQUIDS = squids.ToArray();*/
        }
    }
}
