using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class ItemTentacle
    {
        public static void Init()
        {
            Texture2D title = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/tentacle_title.png");
            title.filterMode = FilterMode.Point;

            CardSetupUtility.NewCard("Nevernamed ItemTentacle",
                "Item Tentacle",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "Ugh... vile",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/itemtentacle.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/itemtentacle_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/itemtentacle_pixel.png"),
                abilities: new List<Ability>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { PackPower.ability },
                variableStat: PackPower.specialStatIcon,
                titleGraphic: title
                ).SetExtendedProperty("ValidSquidTentacleAct1", "true");
        }
    }
}
