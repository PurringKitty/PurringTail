﻿using PurringTail.Common.Players;
using PurringTail.Content.DamageClasses;
using PurringTail.Content.Items.OresAndBars;
using PurringTail.Content.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PurringTail.Content.Items.BossDrops;

public class TopHatDemonEye : ModItem
{
    // By declaring these here, changing the values will alter the effect, and the tooltip
    public static readonly int AdditiveMagicDamageBonus = 5;
    public static int MaxManaIncrease = 100;
    public static readonly int MagicCritBonus = 2;
    public static readonly int MagicAttackSpeedBonus = 100;
    public static readonly int MagicArmorPenetration = 25;

    // Insert the modifier values into the tooltip localization. More info on this approach can be found on the wiki: https://github.com/tModLoader/tModLoader/wiki/Localization#binding-values-to-localizations
    public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AdditiveMagicDamageBonus, MaxManaIncrease, MagicCritBonus, MagicCritBonus, MagicAttackSpeedBonus, MagicArmorPenetration);

    public override void SetDefaults()
    {
        Item.width = 40;
        Item.height = 40;
        Item.accessory = true;
        Item.sellPrice(gold: 50);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        // GetDamage returns a reference to the specified damage class' damage StatModifier.
        // Since it doesn't return a value, but a reference to it, you can freely modify it with mathematics operators (+, -, *, /, etc.).
        // StatModifier is a structure that separately holds float additive and multiplicative modifiers, as well as base damage and flat damage.
        // When StatModifier is applied to a value, its additive modifiers are applied before multiplicative ones.
        // Base damage is added directly to the weapon's base damage and is affected by damage bonuses, while flat damage is applied after all other calculations.
        // In this case, we're doing a number of things:
        // - Adding 25% damage, additively. This is the typical "X% damage increase" that accessories use, use this one.
        // - Adding 12% damage, multiplicatively. This effect is almost never useds in Terraria, typically you want to use the additive multiplier above. It is extremely hard to correctly balance the game with multiplicative bonuses.
        // - Adding 4 base damage.
        // - Adding 5 flat damage.
        // Since we're using DamageClass.Generic, these bonuses apply to ALL damage the player deals.
        player.GetDamage(DamageClass.Magic) += MagicCritBonus;

        // GetCrit, similarly to GetDamage, returns a reference to the specified damage class' crit chance.
        // In this case, we're adding 10% crit chance, but only for the melee DamageClass (as such, only melee weapons will receive this bonus).
        // NOTE: Once all crit calculations are complete, a weapon or class' total crit chance is typically cast to an int. Plan accordingly.
        player.GetCritChance(DamageClass.Magic) += MagicCritBonus;

        // GetAttackSpeed is functionally identical to GetDamage and GetKnockback; it's for attack speed.
        // In this case, we'll make ranged weapons 15% faster to use overall.
        // NOTE: Zero or a negative value as the result of these calculations will throw an exception. Plan accordingly.
        player.GetAttackSpeed(DamageClass.Magic) += MagicCritBonus;

        // GetArmorPenetration is functionally identical to GetCritChance, but for the armor penetration stat instead.
        // In this case, we'll add 5 armor penetration to magic weapons.
        // NOTE: Once all armor pen calculations are complete, the final armor pen amount is cast to an int. Plan accordingly.
        player.GetArmorPenetration(DamageClass.Magic) += MagicArmorPenetration;




    }
}