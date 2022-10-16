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
    static class ColossalSquid
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ColossalSquid",
                "Colossal Squid",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The colossal squid. It drags it's foes down to a watery grave.",
                bloodCost: 0,
                bonesCost: 5,
                abilities: new List<Ability>() { WaterborneLatch.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/colossalsquid.png"),
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/colossalsquid_emission.png")
                );
        }
    }
}