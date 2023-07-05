using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using InscryptionAPI.Card;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class SelkieSkin
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/selkieskin.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed SelkieSkin",
                "Selkie Skin",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The horrid Selkie Skin. Though it still shambles, most beasts still consider it little more than a pelt.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/selkieskin_emission.png"),
                traits: new List<Trait>() { Trait.Pelt },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.SpawnLice }
                ).SetExtendedProperty("CardAlwaysSacrificeable", "true");

            CardSetupUtility.NewCard("Nevernamed SelkieSkinAct2",
                "Selkie Skin",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "",
                bloodCost: 1,
                traits: new List<Trait>() { Trait.Pelt },
                specialAbilities: new List<SpecialTriggeredAbility>() { Act2SpawnLice.ability },
                  pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/selkieskin_pixel.png")
                ).SetExtendedProperty("CardAlwaysSacrificeable", "true");
        }
    }
}
