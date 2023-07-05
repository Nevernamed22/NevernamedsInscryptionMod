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
    static class Springbok
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/springbok.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Springbok",
                "Springbok",
                2,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The fast and fearsome Springbok. While it's movement requires careful planning, it's offensive capabilities are beyond predictable.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Strafe, HomeRun.ability },
                tribes: new List<Tribe>() { Tribe.Hooved },
                  pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/springbok_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/springbok_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
