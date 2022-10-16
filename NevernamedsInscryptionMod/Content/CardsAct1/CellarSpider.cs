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
    static class CellarSpider
    {
        public static void Init()
        {
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cellarspider.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed CellarSpider",
                "Cellar Spider",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The Cellar spider. An exemplar of all arachnida.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                variableStat: WorldWideWeb.specialStatIcon,
                specialAbilities: new List<SpecialTriggeredAbility>() { WorldWideWeb.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cellarspider_emission.png")
                );
        }
    }
}
