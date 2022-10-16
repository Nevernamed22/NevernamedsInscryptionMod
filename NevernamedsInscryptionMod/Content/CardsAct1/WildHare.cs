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
    static class WildHare
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed WildHare",
                "Wild Hare",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The dilligent wild hare, faster than the prarie wind...",
                bloodCost: 0,
                bonesCost: 3,
                //energyCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wildhare.png"),
                abilities: new List<Ability>() { Ability.Strafe, Ability.Reach },
                tribes: new List<Tribe>() {  },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/wildhare_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wildhare_emission.png")
                );
        }
    }
}