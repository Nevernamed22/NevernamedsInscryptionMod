﻿using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class Dove
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Dove",
                "Dove",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Their reputation as heralds of peace may be ill deserved.",
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dove.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dove_emission.png"),
                abilities: new List<Ability>() { Ability.Flying },
                tribes: new List<Tribe>() { Tribe.Bird }
                );
        }
    }
}