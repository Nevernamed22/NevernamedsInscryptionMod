using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using System.Reflection;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class BoardTentacle
    {
        public static void Init()
        {
            Texture2D title = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/tentacle_title.png");
            title.filterMode = FilterMode.Point;

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/boardtentacle.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed BoardTentacle",
                "Board Tentacle",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Another one emerges...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                tribes: new List<Tribe>() { },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                specialAbilities: new List<SpecialTriggeredAbility>() { DirectorOfTheBoard.ability },
                variableStat: DirectorOfTheBoard.specialStatIcon,
                titleGraphic: title
                ).SetExtendedProperty("ValidSquidTentacleAct1", "true");
        }
        
    }
}
