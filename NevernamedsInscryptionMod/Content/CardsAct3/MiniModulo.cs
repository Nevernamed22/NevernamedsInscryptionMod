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
    static class MiniModulo
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MiniModuloTail",
                 "Discarded Module",
                 0,
                 2,
                 new List<CardMetaCategory> {  },
                 CardTemple.Tech,
                 description: "",
                 bloodCost: 0,
                 bonesCost: 0,
                 energyCost: 0,
                 tribes: new List<Tribe>() { },
                 abilities: new List<Ability>() {  },
                 defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/minimodulotail.png")
                 );

            CardSetupUtility.NewCard("Nevernamed MiniModulo",
                "Mini Modulo",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.TailOnHit },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/minimodulo.png"),
                tailLostTexture: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/minimodulo_notail.png"),
                defaultTailCard: "TechNevernamed MiniModuloTail"
                );
        }
    }
}