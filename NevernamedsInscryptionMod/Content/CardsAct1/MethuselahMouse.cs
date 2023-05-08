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
    static class MethuselahMouse
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MethuselahMouse",
                "Methuselah Mouse",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The ancient Methuselah mouse. It has known countless aeons, but it's time draws short.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/methuselahmouse.png"),
                abilities: new List<Ability>() { Endangered.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/methuselahmouse_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/methuselahmouse_emission.png")
                );
        }
    }
}
