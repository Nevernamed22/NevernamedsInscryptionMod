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
    static class BlindMouse
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blindmouse.png");
            // Add the card
           CardSetupUtility.NewCard("BlindMouse",
                "Blind Mouse",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare, },
                CardTemple.Nature,
                description: "Those blind mice... always travelling in a group. See how they run...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { UnfocusedStrike.ability, Trio.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blindmouse_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );
        }
    }
}
