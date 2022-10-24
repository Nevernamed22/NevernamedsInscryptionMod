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
    static class Crayfish
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crayfish.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed CrayfishBi",
                "Crayfish",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The unrelenting crayfish. It changes the orientation of it's claws each turn.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { TransformerCustom.ability, Ability.SplitStrike },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crayfish_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/crayfish_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                transformerForm: "BeastNevernamed CrayfishDuo"
                );

            // Add the card
            CardSetupUtility.NewCard("Nevernamed CrayfishDuo",
                "Crayfish",
                1,
                3,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { TransformerCustom.ability, Ability.DoubleStrike },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crayfish_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/crayfish_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                transformerForm: "BeastNevernamed CrayfishBi"
                );
        }
    }
}
