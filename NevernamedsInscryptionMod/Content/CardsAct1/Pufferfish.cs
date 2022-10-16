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
    static class Pufferfish
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pufferfish.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Pufferfish",
                "Pufferfish",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A deadly pufferfish. Should you strike one of it's spines as you wade... you are in grave peril.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { SubaquaticSpines.ability, Ability.Deathtouch },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pufferfish_emission.png")
                );
        }
    }
}