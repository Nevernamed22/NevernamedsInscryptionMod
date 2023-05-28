using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class SorcerersApprentice
    {
        public static void Init()
        {
            //Forms
            CardSetupUtility.NewCard("Nevernamed SorcerersApprenticeO",
                 "Sorcerers Apprentice",
                 1,
                 1,
                 new List<CardMetaCategory> { }, CardTemple.Wizard, description: "",
                 abilities: new List<Ability>() {  },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sorcerersapprentice_r.png")
                 );
            CardSetupUtility.NewCard("Nevernamed SorcerersApprenticeG",
                 "Sorcerers Apprentice",
                 0,
                 3,
                 new List<CardMetaCategory> { }, CardTemple.Wizard, description: "",
                 abilities: new List<Ability>() { Ability.Reach },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sorcerersapprentice_e.png")
                 );
            CardSetupUtility.NewCard("Nevernamed SorcerersApprenticeB",
                 "Sorcerers Apprentice",
                 0,
                 1,
                 new List<CardMetaCategory> { }, CardTemple.Wizard, description: "",
                 abilities: new List<Ability>() { Ability.RandomAbility },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sorcerersapprentice_s.png")
                 );

            //Double Forms
            CardSetupUtility.NewCard("Nevernamed SorcerersApprenticeOG",
                 "Sorcerers Journeyman",
                 2,
                 3,
                 new List<CardMetaCategory> { }, CardTemple.Wizard, description: "",
                 abilities: new List<Ability>() { Ability.GemDependant, Ability.Reach },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sorcerersapprentice_re.png")
                 );
            CardSetupUtility.NewCard("Nevernamed SorcerersApprenticeOB",
                 "Sorcerers Journeyman",
                 2,
                 1,
                 new List<CardMetaCategory> { }, CardTemple.Wizard, description: "",
                 abilities: new List<Ability>() { Ability.RandomAbility, Ability.Flying },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sorcerersapprentice_sr.png")
                 );
            CardSetupUtility.NewCard("Nevernamed SorcerersApprenticeBG",
                 "Sorcerers Journeyman",
                 0,
                 5,
                 new List<CardMetaCategory> { }, CardTemple.Wizard, description: "",
                 abilities: new List<Ability>() { Ability.RandomAbility, Ability.Reach },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sorcerersapprentice_es.png")
                 );

            //Magnus
            CardSetupUtility.NewCard("Nevernamed SorcerersApprenticeOGB",
                 "Sorcerer",
                 2,
                 3,
                 new List<CardMetaCategory> { }, CardTemple.Wizard, description: "",
                 abilities: new List<Ability>() { Ability.RandomAbility, ChaosStrike.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sorcerersapprentice_res.png")
                 );

            //Main Card
            CardInfo sor =  CardSetupUtility.NewCard("Nevernamed SorcerersApprentice",
                 "Sorcerers Apprentice",
                 0,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 bloodCost: 0,
                 gemsCost: new List<GemType>() {  },
                 bonesCost: 0,
                 tribes: new List<Tribe>() { },
                 abilities: new List<Ability>() { WildShape.ability, Ability.GemDependant },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sorcerersapprentice.png")
                 );
            //Single
            sor.SetExtendedProperty("WildShapeFormOrange", "WizardNevernamed SorcerersApprenticeO");
            sor.SetExtendedProperty("WildShapeFormGreen", "WizardNevernamed SorcerersApprenticeG");
            sor.SetExtendedProperty("WildShapeFormBlue", "WizardNevernamed SorcerersApprenticeB");
            //Double
            sor.SetExtendedProperty("WildShapeFormBlueGreen", "WizardNevernamed SorcerersApprenticeBG");
            sor.SetExtendedProperty("WildShapeFormGreenOrange", "WizardNevernamed SorcerersApprenticeOG");
            sor.SetExtendedProperty("WildShapeFormOrangeBlue", "WizardNevernamed SorcerersApprenticeOB");
            //Magnus
            sor.SetExtendedProperty("WildShapeFormAllGems", "WizardNevernamed SorcerersApprenticeOGB");
        }
    }
}