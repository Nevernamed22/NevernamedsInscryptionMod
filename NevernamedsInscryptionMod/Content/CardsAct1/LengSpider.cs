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
    static class LengSpider
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/lengspider.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed LengSpider",
                "Leng Spider",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The vicious otherworldly spider of leng. It salivates with venom for it's next feast...",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Deathtouch, Ability.GainAttackOnKill },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/lengspider_emission.png")
                );
        }
    }
}