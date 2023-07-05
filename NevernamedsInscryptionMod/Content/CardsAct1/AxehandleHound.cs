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
    static class AxehandleHound
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed AxehandleHound",
                "Axehandle Hound",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The peculiar axehandle hound. It uses it's sharp, bladed nose to cut clean through it's foes with the cold precision of a lumberjack...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/axehandlehound.png"),
                abilities: new List<Ability>() { Cleaving.ability },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/axehandlehound_emission.png")
                );
        }
    }
}
