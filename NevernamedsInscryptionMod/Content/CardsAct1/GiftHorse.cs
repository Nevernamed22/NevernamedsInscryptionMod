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
    static class GiftHorse
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GiftHorse",
                "Gift Horse",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "An unnerving, mottled steed. Best not to look it in the mouth.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gifthorse.png"),
                abilities: new List<Ability>() { Ability.Strafe, GiftBearerCustom.ability},
                tribes: new List<Tribe>() { Tribe.Hooved },
                flipPortraitWhenStrafing: true,
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gifthorse_emission.png")
                );
        }
    }
}
