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
    static class ScaleTentacle
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ScaleTentacle",
                "Scale Tentacle",
                0,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "Hmm...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/scaletentacle.png"),
                abilities: new List<Ability>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { DamageScaling.ability },
                variableStat: DamageScaling.specialStatIcon,
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/scaletentacle_emission.png"),
                titleGraphic: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/tentacle_title.png")
                ).SetExtendedProperty("ValidSquidTentacleAct1", "true");
        }
    }
}