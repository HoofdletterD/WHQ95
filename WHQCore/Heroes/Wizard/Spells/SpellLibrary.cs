using WHQCore.Models;
using WHQCore.Models.Enums;

namespace WHQCore.Heroes.Wizard.Spells;

public static class SpellLibrary
{
    // -------- CASTING 1 --------
    public static Spell Bloodblade => new(
        "Bloodblade",
        [SpellType.Attack],
        [Lore.Death],
        "The Wizard's sword glows as a thick red liquid coagulates on the blade.",
        "1",
        "Roll 1D6 for each Monster adjacent to the Wizard. On a score of 6 that target takes 1 Wound, with no modifiers for Toughness or armour. This spell may be cast once per turn.",
        "All monsters adjacent to the wizard",
        "Immediate",
        "images/Spell/Bloodblade.png"
    );

    public static Spell Sting => new(
        "Sting",
        [SpellType.Attack],
        [Lore.Beast],
        "With a high-pitched buzzing sound, the Wizard makes a large hornet appear inside his opponent's armour.",
        "1",
        "Pick any Monster on the same board section as the Wizard and roll 1D6. On a score of 4, 5 or 6 the Monster takes 1 Wound, with no modifiers for anything (Toughness, armour, Ignore Pain, etc.).",
        "Any Monster on the same board section as the Wizard",
        "Immediate",
        "images/Spell/Sting.png"
    );

    public static Spell Coughing => new(
        "Coughing",
        [SpellType.Defensive],
        [Lore.Metal],
        "The Wizard's opponent suddenly bursts out in a hacking cough of such violence that he almost drops his weapon",
        "1",
        "Pick any Monster on the same board section as the Wizard and roll 1D6. On a score of 5 or 6 the target collapses in a coughing spasm and is at -1 on his to hit rolls for the rest of the turn.",
        "Any Monster on the same board section as the Wizard",
        "One Turn",
        "images/Spell/Coughing.png"
    );

    public static Spell Drop => new(
        "Drop",
        [SpellType.Defensive],
        [Lore.Heavens],
        "The Wizard mutters an invocation and gestures towards the ground, causing the target's grip on his weapon to fail.",
        "1",
        "Pick any Monster on the same board section as the Wizard and roll 1D6. On a score of 6 the target drops any one object he is holding. He cannot move this turn as he retrieves it.",
        "Any Monster on the same board section as the Wizard",
        "Immediate",
        "images/Spell/Drop.png"
    );

    public static Spell CreateFood => new(
        "Create Food",
        [SpellType.Healing],
        [Lore.Life],
        "From nowhere the Wizard conjures up a hot and filling meal, ideal for restoring the constitution after a hard fight.",
        "1",
        "The Wizard conjures up a simple meal. Roll 1D6 for the Warrior that eats it. On a score of 3, 4, 5 or 6 that Warrior has t Wound restored",
        "Any Warriors on the board",
        "Immediate",
        "images/Spell/CreateFood.png"
    );

    public static Spell CureSmallWounds => new(
        "Cure Small Wounds",
        [SpellType.Healing],
        [Lore.Light],
        "Holding up a symbol of life, the Wizard pricks his finger with a small dagger and lets his blood drip onto the talisman before touching it to the target's wound. thus healing it",
        "1",
        "Pick any Warrior on the board (including the Wizard) and heal 1 of his Wounds. Each individual Warrior may only have this spell cast on him once per turn.",
        "Any Warrior on the board",
        "Immediate",
        "images/Spell/CureSmallWounds.png"
    );

    public static Spell FleetOfFoot => new(
        "Fleet of Foot",
        [SpellType.Special],
        [Lore.Light],
        "Sprinkling a small quantity of glittering powder on his boots, the Wizard starts to move very quickly.",
        "1",
        "Upon casting this spell, the Wizard gets +1 Move this turn. ",
        "The Wizard",
        "One Turn",
        "images/Spell/FleetOfFoot.png"
    );

    public static Spell Open => new(
        "Open",
        [SpellType.Special],
        [Lore.Metal],
        "The Wizard produces a small glowing key made from pure energy that can open any lock.",
        "1",
        "The Wizard may open any non-magical lock on the same board section as himself. Any traps on the lock are set off as normal",
        "Non-magical lock adjacent to the wizard",
        "Immediate",
        "images/Spell/Open.png"
    );

    // -------- CASTING 2 --------
    public static Spell FleshWorm => new(
        "Flesh Worm",
        [SpellType.Attack],
        [Lore.Shadow],
        "The Wizard produces a small glowing worm and hurls it at his opponent. ",
        "2",
        "Pick any Monster on the same board section as the Wizard. He becomes infected with a Flesh Worm and immediately loses 1 Wound with no modifiers for anything (Toughness, armour, Ignore Pain, etc.). At the start of each subsequent turn, roll 1D6. On a score or 1, 2. 3 or A the Flesh Worm dies. On a score of 5 or 6 it continues to feed and the victim takes another 1 Wound, again with no modifiers for anything.",
        "Any Monster on the same board section as the Wizard/only 1 Flesh Worm per Monster",
        "Until Flesh Worm dies",
        "images/Spell/FleshWorm.png"
    );

    public static Spell Strength => new(
        "Strength",
        [SpellType.Attack],
        [Lore.Fire],
        "Calling on the forces of magic, the Wizard uses the power to increase the target's strength.",
        "2",
        "Pick any Warrior on the board (Including the Wizard). This turn he is at +1 strength. Each individual Warrior may only have this spell cast on him once per turn.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/Strength.png"
    );

    public static Spell FeignDeath => new(
        "Feign Death",
        [SpellType.Defensive],
        [Lore.Death],
        "The Wizard suddenly slumps to the ground. seemingly dead.",
        "2",
        "This spell puts the Wizard into a corpse-like state. While in this state. the Wizard may do nothing. No Monster will attack him unless there are no other Warriors standing, in which case the Monster automatically hits.",
        "The Wizard",
        " Indefinite, minimum one whole Turn and whole Turns thereafter",
        "images/Spell/FeignDeath.png"
    );

    public static Spell MarshLights => new(
        "Marsh Lights",
        [SpellType.Defensive],
        [Lore.Light],
        "The Wizard sends a sparkling, dancing light down the corridor, drawing his opponents away.",
        "2",
        "Roll 1D6 for each Monster that appears as a result of an Unexpected Event. On a score of 1, 2, 3. 4 or 5 place that Monster as normal. On a score of 6 that Monster follows the marsh lights away from the Warriors and isn't placed on the board at all. May only be cast once per Event.",
        "All Monsters that are about to be placed on the board",
        "Immediate",
        "images/Spell/MarshLights.png"
    );

    public static Spell Nausea => new(
        "Nausea",
        [SpellType.Defensive],
        [Lore.Light],
        "The Wizard emits a shrill. deathly shriek, causing his opponent to stagger and reel.",
        "2",
        "Pick any Monster on the board. This turn it is at -1 on its to hit rolls. May only be cast once per Monster per turn",
        "Any Monster on the board",
        "One Turn",
        "images/Spell/Nausea.png"
    );

    public static Spell Slip => new(
        "Slip",
        [SpellType.Defensive],
        [Lore.Heavens],
        "With a wave of his hand the Wizard causes the ground his opponent stands on to shift.",
        "2",
        "Pick any Monster on the board and roll 1D6. On a score of 1 to 4 the spell has no effect. On a score of 5 or 6 the Monster slips over and can do nothing else this turn as it regains its balance. May only be cast once per Monster per turn.",
        "Any Monster on the board",
        "One Turn",
        "images/Spell/Slip.png"
    );

    public static Spell HealingHands => new(
        "Healing Hands",
        [SpellType.Healing],
        [Lore.Life],
        "Muttering under his breath, the Wizard feels a soothing calmness descend upon himself and his companions.",
        "2",
        "Every Warrior on the board has 1 Wound healed.",
        "All Warriors on the board",
        "Immediate",
        "images/Spell/HealingHands.png"
    );

    public static Spell Tongues => new(
        "Tongues",
        [SpellType.Special],
        [Lore.Heavens],
        "The Wizard passes his hands over his ears and suddenly understands every word being spoken",
        "2",
        "This spell allows the Wizard to understand anything said to him this turn, regardless of the language the words are spoken in. It does not allow the Wizard to speak that language.",
        "The Wizard",
        "One Turn",
        "images/Spell/Tongues.png"
    );

    public static Spell ZoneOfSilence => new(
        "Zone of Silence",
        [SpellType.Special],
        [Lore.Light],
        "The Wizard puts his finger to his lips and a deathly hush descends. ",
        "2",
        "Pick any board section. For the rest of the turn no sound can be made by any model on this board section.",
        "Any board section",
        " One Turn",
        "images/Spell/ZoneOfSilence.png"
    );

    // -------- CASTING 3 --------
    public static Spell FistOfIron => new(
        "Fist of Iron",
        [SpellType.Attack],
        [Lore.Metal],
        "The Wizard conjures up a huge iron-mailed fist and sends it hurtling towards his opponent.",
        "3",
        "Pick any Monster up to 6 squares away from the Wizard and roll 1D6. If the score is greater than or equal to the range of the target it suffers 1D6+ 1 Wounds.",
        "Any Monster up to 6 squares away",
        "Immediate",
        "images/Spell/FistOfIron.png"
    );

    public static Spell IceBlades => new(
        "Ice Blades",
        [SpellType.Attack],
        [Lore.Heavens],
        "The air around the Wizard is suddenly filled with racing shards of razor\u0002sharp ice.",
        "3",
        "All Monsters adjacent to the Wizard take 1 Wound, with no modifiers for anything (Toughness, armour, Ignore Pain, etc.).",
        "All Monsters adjacent to the Wizard",
        "Immediate",
        "images/Spell/IceBlades.png"
    );

    public static Spell OgreStrength => new(
        "Ogre Strength",
        [SpellType.Attack],
        [Lore.Beast],
        "Calling on the forces of magic. the Wizard uses the power to increase the target's strength fourfold.",
        "3",
        "Pick any Warrior on the board (including the Wizard). This turn the chosen Warrior is at +2 to his Strength for the purpose of resolving damage. Each individual Warrior may only have this spell cast on him once per turn.",
        "Any Warrior on the board",
        " One Turn",
        "images/Spell/OgreStrength.png"
    );

    public static Spell Confuse => new(
        "Confuse",
        [SpellType.Defensive],
        [Lore.Light],
        "The Wizard creates confusing images around his opponents head. ",
        "3",
        "Pick any Monster on the same board section as the Wizard. This turn it loses 1 attack.",
        "Any Monster on the same board section as the Wizard",
        "Immediate",
        "images/Spell/Confuse.png"
    );

    public static Spell GlitteringRobe => new(
        "Glittering Robe",
        [SpellType.Defensive],
        [Lore.Light],
        "The Wizard creates a robe of magical energy that shimmers and glitters about him as he moves",
        "3",
        "This spell creates a cloak of magical energy around the Wizard that can absorb 1D6 Wounds.",
        "The Wizard",
        "One Turn",
        "images/Spell/GlitteringRobe.png"
    );

    public static Spell FingerOfLife => new(
        "Finger of Life",
        [SpellType.Healing],
        [Lore.Life],
        "The Wizard points at one of his companions and a thin stream of blue energy pours from his fingertip, revitalising him.",
        "3",
        "Pick any Warrior on the board (including the Wizard) and roll 1D6. On a score of 1, 2 or 3 the spell has no effect. On a score of 4. 5 or 6 the chosen Warrior has that many Wounds healed.",
        "Any Warrior",
        "Immediate",
        "images/Spell/FingerOfLife.png"
    );

    public static Spell Speed => new(
        "Speed",
        [SpellType.Special],
        [Lore.Shadow],
        "Breathing deeply, the Wizard uses his power to speed up the target's metabolism and movement.",
        "3",
        "Pick any Warrior on the board (including the Wizard). His Move is doubled this turn.",
        "Any Warrior",
        " One Turn",
        "images/Spell/Speed.png"
    );

    // -------- CASTING 4 --------
    public static Spell AcidBlast => new(
        "Acid blast",
        [SpellType.Attack],
        [Lore.Beast],
        "Acid spits from the Wizard's fingertips, creating a burning river that gushes towards the enemy.",
        "4",
        "This spell allows the Wizard to create a corridor of corrosive acid 1 square wide, travelling directly away from him in one of the compass directions and continuing until it hits a Monster, Warrior or other obstacle. Note that the Casting number for the Acid Blast spell is 4+(the Wizard's BattleLevel). The first model in the path of the acid suffers 2D6+(the Wizard's Battle-level) Wounds. If this is sufficient to kill the model, the acid continues until it hits another model. which it wounds in the same way. This process continues until a target survives or the acid hits a solid obstacle. such as a wall",
        "A 1 square wide corridor",
        "Immediate",
        "images/Spell/AcidBlast.png"
    );

    public static Spell IceTomb => new(
        "Ice tomb",
        [SpellType.Attack],
        [Lore.Heavens],
        "The Wizard's chill breath fills the room, coalescing around a single Monster and encasing it in a solid tomb of ice",
        "4",
        "Pick any Monster that lies within the Wizard's line of sight and roll 1D6. If the score is less than or equal to the targets Toughness the spell has no effect. If the score exceeds the target's Toughness it is encased in a sarcophagus of ice and may not move or fight. While entombed, the target cannot be attacked. Note that for every 2 extra points of power the Wizard adds to cast this spell you may add +1 to the dice roll to see if the target is trapped. The target remains entombed as long as the Wizard continues to spend power points equal to the target's Toughness each turn.",
        "Any Monster within the Wizard's line of sight",
        "While maintained",
        "images/Spell/IceTomb.png"
    );

    public static Spell LightningBolt => new(
        "Lightning Bolt",
        [SpellType.Attack],
        [Lore.Heavens],
        "Raw power arcs across the Wizard's fingertips and a bolt of white power streaks from his eyes towards his opponent.",
        "4",
        "Pick any Monster that lies within the Wizard's line of sight. The target suffers 2D6 Wounds.",
        "Any Monster within the Wizard's line of sight",
        "Immediate",
        "images/Spell/LightningBolt.png"
    );

    public static Spell Levitate => new(
        "Levitate",
        [SpellType.Defensive],
        [Lore.Heavens],
        "A crackling sound fills the room as the Wizard raises the target to the roof, carrying him aloft on a column of coruscating power.",
        "4",
        "Pick any Warrior on the board (including the Wizard) and levitate him. A levitating Warrior can only be attacked with missile weapons or spells. He cannot move, however, and may not fight in hand-to-hand combat. He may fire missile weapons as normal. His square remains impassable, just as if he were standing in it normally. He may levitate out of a pit.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/Levitate.png"
    );

    public static Spell Rebound => new(
        "Rebound",
        [SpellType.Defensive],
        [Lore.Heavens],
        "As the Wizard chants the words of this spell a shimmering mirror of power surrounds the target, protecting him from harm.",
        "4",
        "Pick any Warrior on the board (including the Wizard). Each time he is physically attacked this turn roll 1D6. On a score of 6 all the Wounds that the attack inflicted are rebounded onto whoever caused them. Note that this spell does not rebound spells.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/Rebound.png"
    );

    public static Spell HealWounds => new(
        "Heal Wounds",
        [SpellType.Healing],
        [Lore.Life],
        "Muttering soothing words, the Wizard makes a complicated pattern in the air with a glowing sphere and suffuses the target in a golden glow.",
        "4",
        "Pick any Warrior on the board (including the Wizard) and heal 1D6 of his Wounds.",
        "Any Warrior on the board",
        "Immediate",
        "images/Spell/HealWounds.png"
    );

    public static Spell DispelMagic => new(
        "Dispel Magic",
        [SpellType.Special],
        [Lore.Light],
        "The Wizard raises his hand and shouts the words of warding, diffusing his opponent's magic.",
        "4",
        "May be cast once against each incoming spell. Roll 1D6 for each. If you score 4, 5 or 6 the target spell is prevented from working. Only one attempt may be made to dispel each incoming spell.",
        "Any or all incoming spells",
        "Immediate",
        "images/Spell/DispelMagic.png"
    );

    public static Spell SecondSight => new(
        "Second Sight",
        [SpellType.Special],
        [Lore.Death],
        "The Wizard stands still for a moment, allowing his spirit to leave his body and investigate what lies beyond the next door.",
        "4",
        "This spell allows the Wizard to determine what is in a room before the Warriors enter it. Once cast, look at the next Event card in the Event deck just before the Warriors enter a room and reveal it, rolling on tables if necessary. If you then decide that the Warriors don't want to face that Event place it on the discard pile. Second Sight may only be cast once per room.",
        "-",
        "Immediate",
        "images/Spell/SecondSight.png"
    );

    // -------- CASTING 5 --------
    public static Spell Fireball => new(
        "Fireball",
        [SpellType.Attack],
        [Lore.Fire],
        "Furrowing his brow in concentration, the Wizard stretches out his arms and shoots a ball of fire across the room, engulfing his foes in flames.",
        "5",
        "Pick a 2x2 square area of a board section within the Wizard's line of sight. Each Monster in that area suffers 1D6 + (the Wizard's Battle-level) Wounds.",
        "All Monsters on a 2x2 square area within the Wizard's line of sight",
        "Immediate",
        "images/Spell/Fireball.png"
    );

    public static Spell Firehammer => new(
        "Firehammer",
        [SpellType.Attack],
        [Lore.Fire],
        "A blazing hammer appears in the Wizard's fist and smashes a burning path through his foes.",
        "5",
        "Pick any Monster adjacent to the Wizard. It immediately suffers 3D6 Wounds.",
        "Any Monster adjacent to the Wizard",
        "Immediate",
        "images/Spell/Firehammer.png"
    );

    public static Spell Freeze => new(
        "Freeze!",
        [SpellType.Attack],
        [Lore.Shadow],
        "A freezing wind swirls through the room, chilling the Monsters to the bone yet leaving the Warriors unharmed.",
        "5",
        "Roll 1D6. The number you roll shows two things: (1) The number of Monsters affected this turn; (2) The number of Wounds each affected Monster suffers, with no modifiers for Toughness, armour, etc. The targets must be on the same board section as the Wizard. The Wizard chooses which Monsters are affected.",
        "Any Monsters on the same board section as the Wizard",
        "Immediate",
        "images/Spell/Freeze.png"
    );

    public static Spell PitOfDespair => new(
        "Pit of Despair",
        [SpellType.Attack],
        [Lore.Shadow],
        "A stream of blinding white light pours from the Wizard's mouth. Where it hits the stone a bottomless pit opens with a loud crack.",
        "5",
        "Pick any 2x2 area and place the Pit of Despair marker on it. Roll 1D6 for each model standing in the four squares. On a 1 or 2 it falls into the pit and is killed. On 3–6 it scrambles out of the way—place it in any empty square on this or an adjacent board section. If no empty squares are available the model falls into the pit. Once placed, no model may enter those squares.",
        "Any 2x2 area on the board",
        "Permanent",
        "images/Spell/PitOfDespair.png"
    );

    public static Spell Blur => new(
        "Blur",
        [SpellType.Defensive],
        [Lore.Heavens],
        "The Wizard's outline shimmers and becomes an indistinct, hazy blur that is continually changing.",
        "5",
        "Pick any Warrior on the board (including the Wizard). For this turn, all attacks made against the chosen Warrior are at -1 to their to-hit roll.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/Blur.png"
    );

    public static Spell Dazzle => new(
        "Dazzle",
        [SpellType.Defensive],
        [Lore.Light],
        "A blurring screen of energy shoots towards the target, engulfing it in a myriad maze of glittering colours.",
        "5",
        "Pick any Monster on the board. For this turn, all hand-to-hand attacks made against that Monster only miss on a natural to-hit roll of 1.",
        "Any Monster on the board",
        "One Turn",
        "images/Spell/Dazzle.png"
    );

    public static Spell IronSkin => new(
        "Iron Skin",
        [SpellType.Defensive],
        [Lore.Metal],
        "The Wizard scatters a handful of meteoric iron dust over the target, coating him in a fine layer of powder that quickly sets into a magical second skin.",
        "5",
        "Pick any Warrior on the board (including the Wizard). This turn the chosen Warrior is at +2 to his Toughness.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/IronSkin.png"
    );

    public static Spell LifeForce => new(
        "Life Force",
        [SpellType.Healing],
        [Lore.Life],
        "A stream of pure energy flows from the Wizard's fingertips, redirecting a Monster's life-force into one of the Warriors and healing him.",
        "5",
        "Pick any Warrior on the board (including the Wizard) who has yet to start his attacks. For each Wound that Warrior inflicts this turn, after Toughness and armour, you may heal 1 Wound on a single Warrior of your choosing. If the chosen Warrior inflicts no Wounds this turn the spell is wasted.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/LifeForce.png"
    );

    public static Spell Lifebringer => new(
        "Lifebringer",
        [SpellType.Healing],
        [Lore.Life],
        "Blazing fire leaps from the Wizard's eyes, striking the Warriors and bathing them in a corona of energy that heals their wounds.",
        "5",
        "Pick any number of Warriors on the board (including the Wizard). Roll 1D6 for each Warrior chosen. Each Warrior regains that many Wounds. If any two or more of the dice rolled come up the same number the spell fails and none of the Warriors are healed.",
        "Any or all Warriors on the board",
        "Immediate",
        "images/Spell/Lifebringer.png"
    );

    public static Spell Invisibility => new(
        "Invisibility",
        [SpellType.Special],
        [Lore.Shadow],
        "With a shimmer of light, the Warrior's outline slowly fades until he is completely invisible.",
        "5",
        "Pick any Warrior on the board (including the Wizard) and make him invisible. While invisible a Warrior may carry out any action except attacking an opponent: moving, healing etc. are valid; firing a bow, pushing a Monster into a pit, casting offensive spells, etc. are not.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/Invisibility.png"
    );

    public static Spell Sleep => new(
        "Sleep",
        [SpellType.Special],
        [Lore.Shadow],
        "Murmuring quietly, the Wizard sends his opponents into an enchanted sleep.",
        "5",
        "The Wizard may roll D6 equal to his Battle-level. If the total score is more than the target's Starting Wounds it falls asleep for 1 turn. Dice may be split between multiple targets (declare splits before rolling). If split, the combined dice total for each target must be greater than its Starting Wounds to work. While asleep, a Monster may be hit automatically.",
        "Any Monsters on the same board section as the Wizard",
        "One Turn",
        "images/Spell/Sleep.png"
    );


    // -------- CASTING 6 --------
    public static Spell Cataclysm => new(
        "Cataclysm",
        [SpellType.Attack],
        [Lore.Shadow],
        "Moaning in anguish, the Wizard spreads his arms as an area of blackness takes shape around his foes.",
        "6",
        "Pick any 2x2 area on the same board section as the Wizard. Every Monster in the chosen area suffers 1D6 Wounds with no modifiers (Toughness, armour, Ignore Pain etc.).",
        "Any 2x2 area on the same board section as the Wizard",
        "Immediate",
        "images/Spell/Cataclysm.png"
    );

    public static Spell SwordsOfDoom => new(
        "Swords of Doom",
        [SpellType.Attack],
        [Lore.Metal],
        "Instead of him wielding one sword, a great many blades suddenly start to whirl and slash the air before the Wizard.",
        "6",
        "Pick any Warrior on the board (including the Wizard). This turn he gets extra Attacks: +1 for Novice Wizard, +2 for Champion, +3 for Hero, +4 for Lord.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/SwordsOfDoom.png"
    );

    public static Spell Weaponmaster => new(
        "Weaponmaster",
        [SpellType.Attack],
        [Lore.Metal],
        "The Wizard calls on the powers of magic to guide his hand as he moves to strike down his enemies.",
        "6",
        "Pick any Warrior on the board (including the Wizard). This turn he gains Weapon Skill: +1 Novice, +2 Champion, +3 Hero, +4 Lord.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/Weaponmaster.png"
    );

    public static Spell Invulnerability => new(
        "Invulnerability",
        [SpellType.Defensive],
        [Lore.Light],
        "The Wizard holds aloft a glittering jewel and a hazy sheen of magical protective power descends before him.",
        "6",
        "Pick any Warrior on the board (including the Wizard). The next blow that hits this Warrior, whatever its source, has no effect.",
        "Any Warrior on the board",
        "Until Warrior is attacked",
        "images/Spell/Invulnerability.png"
    );

    public static Spell Shield => new(
        "Shield",
        [SpellType.Defensive],
        [Lore.Light],
        "Shouting words of power, the Wizard points a finger at one of his companions, surrounding him with a glowing screen of magical energy.",
        "6",
        "Pick any Warrior on the board (including the Wizard). For this turn the chosen Warrior is immune to all attacks except those made with a natural 6 to hit or those that are magical in nature. The Warrior can move and fight as usual.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/Shield.png"
    );

    public static Spell Resurrection => new(
        "Resurrection",
        [SpellType.Healing],
        [Lore.Life],
        "The Wizard shouts a long-forgotten invocation of great power that can raise the dead.",
        "6",
        "Pick any dead Warrior in the game and bring him back to life. Place him on the same board section as the Wizard. He is restored to full Wounds, but loses any treasure and gold he earned in this dungeon. This spell may be cast even if the Warrior died several turns ago.",
        "Any dead Warrior",
        "Immediate",
        "images/Spell/Resurrection.png"
    );

    public static Spell CauseAnimosity => new(
        "Cause Animosity",
        [SpellType.Special],
        [Lore.Shadow],
        "Chanting strange words in a guttural tongue, the Wizard brandishes his sword in an elaborate, aggressive gesture.",
        "6",
        "Roll 1D6 for each group of Monsters (a group = all Monsters of the same type on that board section). On a 1–3 the spell has no effect on that group. On 4–6 that group attacks another random group of Monsters this turn.",
        "All Monsters on the board",
        "Immediate",
        "images/Spell/CauseAnimosity.png"
    );

    public static Spell CreateBridge => new(
        "Create Bridge",
        [SpellType.Special],
        [Lore.Metal],
        "Solid rock leaps from the Wizard's outstretched fingertips, building a bridge across the room.",
        "6",
        "Create a magical bridge 1 square wide across any pit, hole or chasm. The bridge remains in place as long as the Wizard spends 2 Power per turn keeping it active.",
        "Any 1-square wide area across a chasm, hole or pit",
        "While maintained",
        "images/Spell/CreateBridge.png"
    );

    public static Spell WingsOfPower => new(
        "Wings of Power",
        [SpellType.Special],
        [Lore.Heavens],
        "Leathery wings sprout from the target's back, lifting him into the air.",
        "6",
        "Pick any Warrior on the board (including the Wizard) and make him fly. While airborne a Warrior may not make any attacks and is immune to all attacks except missile weapons or magic. An airborne Warrior may move normally and ignore ground obstacles such as chasms or pits.",
        "Any Warrior on the board",
        "One Turn",
        "images/Spell/WingsOfPower.png"
    );


    // -------- CASTING 7 --------
    public static Spell BurningStorm => new(
        "Burning Storm",
        [SpellType.Attack],
        [Lore.Fire],
        "Scorching flames leap from the Wizard's outstretched hand and a column of all-consuming flame engulfs his target.",
        "7",
        "Pick any Monster on the board and roll (the Wizard's Battle-level) D6. For each D6 that scores 4, 5 or 6 the target suffers that many Wounds, with no modifiers.",
        "Any Monster on the board",
        "Immediate",
        "images/Spell/BurningStorm.png"
    );

    public static Spell ChainLightning => new(
        "Chain Lightning",
        [SpellType.Attack],
        [Lore.Light],
        "A lightning bolt shoots from the Wizard's fingers, hitting the nearest Monster with sparking, elemental power.",
        "7",
        "The nearest Monster suffers 1D6 + (the Wizard's Battle-level) Wounds. After rolling for damage, roll another D6: on 1–3 the lightning ends, on 4–6 it leaps to the next nearest Monster and attacks. The process continues until it grounds. A Monster may not be hit a second time unless all others have been hit that many times.",
        "The nearest Monster to the Wizard",
        "Immediate",
        "images/Spell/ChainLightning.png"
    );

    public static Spell DomeOfPower => new(
        "Dome of Power",
        [SpellType.Defensive],
        [Lore.Light],
        "White power streams from the Wizard's eyes, forming a protective dome around the Warriors.",
        "7",
        "Protect up to one square of the board per Battle-level with an impenetrable shield. Squares must be linked together. Models inside the dome may not move, fight or cast offensive magic, but are immune to all forms of attack this turn.",
        "Area of the board equal to one square per Wizard Battle-level",
        "One Turn",
        "images/Spell/DomeOfPower.png"
    );

    public static Spell FoolsGold => new(
        "Fools' Gold",
        [SpellType.Defensive],
        [Lore.Shadow],
        "The Wizard spins a coin into the air, where it hangs above the Monsters and begins to shower gold down upon them.",
        "7",
        "Roll 1D6 for each Monster on the same board section. On 1–3 no effect. On 4–6 that Monster is overcome with visions of treasure and may do nothing this turn except stand in a drooling stupor. Affected Monsters do not cause pinning, will not attack, but defend as normal.",
        "All Monsters on the same board section as the Wizard",
        "One Turn",
        "images/Spell/FoolsGold.png"
    );

    public static Spell Bloodpulse => new(
        "Bloodpulse",
        [SpellType.Healing],
        [Lore.Life, Lore.Death],
        "A dull throbbing fills the room as it becomes suffused with a red glow.",
        "7",
        "Pick any Warrior on the board (including the Wizard). He immediately regains (the Wizard's Battle-level) Wounds.",
        "Any Warrior on the board",
        "Immediate",
        "images/Spell/Bloodpulse.png"
    );

    public static Spell Glory => new(
        "Glory!",
        [SpellType.Special],
        [Lore.Heavens],
        "The Wizard sends out tendrils of force that pierce the hearts of the Warriors, filling them with great valour.",
        "7",
        "All Warriors gain +1 Attack this turn.",
        "All Warriors on the board",
        "One Turn",
        "images/Spell/Glory.png"
    );

    public static Spell TimeFreeze => new(
        "Time Freeze",
        [SpellType.Special],
        [Lore.Heavens],
        "The Wizard's hand vanishes as he reaches into the warp, holding back the fabric of time.",
        "7",
        "After Warriors complete their actions in the Warriors' Phase, they may attempt to take an extra Warriors' Phase immediately. Roll 1D6: on 1–2 the spell fails; on 3–6 it works and Warriors may act again. May only be cast once per turn.",
        "All Warriors on the board",
        "Immediate",
        "images/Spell/TimeFreeze.png"
    );

    public static Spell WarpJump => new(
        "Warp Jump",
        [SpellType.Special],
        [Lore.Shadow],
        "The Warriors vanish with a thunderflash, leaving a crackling coil of energy and the tang of ozone in the air.",
        "7",
        "The Wizard and all Warriors adjacent to him are transported to another explored part of the dungeon (Wizard player's choice) and reappear in the same formation. If Warriors left behind had the only light source they become Lost in the Dark and must roll on Escaping Table. If multiple Warriors Warp Jump without a light source they become Lost in the Dark at destination.",
        "The Wizard and any Warriors adjacent to him",
        "Immediate",
        "images/Spell/WarpJump.png"
    );

    // -------- CASTING 8 --------
    public static Spell Hellbeast => new(
        "Hellbeast",
        [SpellType.Attack],
        [Lore.Beast, Lore.Death],
        "The Wizard assumes the aspect of a ravaging daemonic creature.",
        "8",
        "This turn the Wizard gets +1 Attack, +1 to hit, causes +2 Wounds on damage rolls, cannot use a weapon and is immune to psychological effects.",
        "The Wizard",
        "One Turn",
        "images/Spell/Hellbeast.png"
    );

    public static Spell SpearOfLight => new(
        "Spear of Light",
        [SpellType.Attack],
        [Lore.Light],
        "The Wizard hurls a spear of pure energy at his chosen victim.",
        "8",
        "Any single Monster in the Wizard's line of sight suffers 1D6 Wounds for each of the Wizard's Battle-levels.",
        "Any Monster in the Wizard's line of sight",
        "Immediate",
        "images/Spell/SpearOfLight.png"
    );

    public static Spell CageOfStone => new(
        "Cage of Stone",
        [SpellType.Defensive],
        [Lore.Metal],
        "The Wizard screams an invocation as pillars of stone shoot down and up, trapping the target.",
        "8",
        "Confine any Monster that is attacking the Wizard in a prison of magical stone. While confined the victim may neither move nor fight (though it may cast magic), and all attacks against it are made at +1 to hit. At the start of each Monsters' Phase roll 2D6; if score < trapped Monster's Strength it breaks free and the spell fails.",
        "Any Monster attacking the Wizard",
        "Until broken",
        "images/Spell/CageOfStone.png"
    );

    public static Spell HaloOfVengeance => new(
        "Halo of Vengeance",
        [SpellType.Defensive],
        [Lore.Light],
        "The Wizard casts a glowing halo around the target which absorbs attacks.",
        "8",
        "At the start of each turn roll 1D6; that many attacks can be absorbed by the halo and ignored. The halo remains until the target moves or you roll a natural 1.",
        "Any Warrior on the board",
        "Until the target moves or the dice roll is a natural 1",
        "images/Spell/HaloOfVengeance.png"
    );

    public static Spell Voidmaster => new(
        "Voidmaster",
        [SpellType.Healing],
        [Lore.Shadow],
        "The Wizard temporarily leaves the physical universe for the cold depths of the void, where he can recover his strength.",
        "8",
        "The Wizard disappears from the board; one whole turn later he reappears anywhere on the same board section with all of his Wounds restored.",
        "The Wizard",
        "One Turn",
        "images/Spell/Voidmaster.png"
    );

    public static Spell ChorusOfValour => new(
        "Chorus of Valour",
        [SpellType.Special],
        [Lore.Heavens],
        "The Wizard's whispered words mystically fill the Warriors with courage.",
        "8",
        "For the rest of this turn, all Warriors are immune to the effects of Fear and Terror.",
        "All Warriors on the board",
        "One Turn",
        "images/Spell/ChorusOfValour.png"
    );


    // -------- CASTING 9 --------
    public static Spell Lifestealer => new(
        "Lifestealer",
        [SpellType.Healing],
        [Lore.Death, Lore.Life],
        "With a sharp hiss of breath the Wizard lightly touches his opponent, stealing his energy.",
        "9",
        "Each Monster adjacent to the Wizard suffers 1D6 Wounds (no modifiers). The total Wounds caused may then be distributed among the Wizard and other Warriors to heal them as the player decides.",
        "All Monsters adjacent to the Wizard",
        "Immediate",
        "images/Spell/Lifestealer.png"
    );

    public static Spell HoundsOfGrimnair => new(
        "Hounds of Grimnair",
        [SpellType.Special],
        [Lore.Beast],
        "The air is filled with eerie howling as dim incorporeal shadows hurl themselves at the Wizard's foes.",
        "9",
        "Summon 1 Hound of Grimnair for each of the Wizard's Battle-levels. Wizard chooses which Monster each Hound attacks. Each Hound hits its target on a 1D6 roll of 5 or 6 and causes 1D6 Wounds (no modifiers). If a Hound rolls 1 or 2 on its attack it vanishes. When no Monsters remain, remaining Hounds vanish. While Hounds are active this spell cannot be cast again.",
        "Any Monster on the board",
        "Variable",
        "images/Spell/HoundsOfGrimnair.png"
    );


    // -------- CASTING 10 --------
    public static Spell Windblast => new(
        "Windblast",
        [SpellType.Attack],
        [Lore.Heavens],
        "A howling gale sweeps through the dungeon, buffeting the Warriors and slamming into the Monsters.",
        "10",
        "Choose any Monster on the board. It is immediately picked up and hurled to the floor by a magical gust, taking 1D6 Wounds for each of the Wizard's Battle-levels (no modifiers). The target may do nothing else for the rest of the turn.",
        "Any Monster on the board",
        "Immediate",
        "images/Spell/Windblast.png"
    );

    public static Spell RadianceOfPtolos => new(
        "Radiance of Ptolos",
        [SpellType.Defensive],
        [Lore.Death],
        "The Wizard's eyes close and a red light pours out, bathing the Warriors in a bloody hue.",
        "10",
        "For this turn, each time a Warrior is attacked roll 1D6. On 1–3 the spell has no effect. On 4–6 the attack is rebounded onto the attacker.",
        "All Warriors on the board",
        "One Turn",
        "images/Spell/RadianceOfPtolos.png"
    );

    public static Spell Heartbeat => new(
        "Heartbeat",
        [SpellType.Healing],
        [Lore.Fire],
        "While the Wizard chants an incantation power surges through the target's body and his heart beats with renewed vigour.",
        "10",
        "Restore 1D6 Wounds per the Wizard's Battle-level to a single Warrior, up to his Starting Wounds.",
        "One Warrior",
        "Immediate",
        "images/Spell/Heartbeat.png"
    );

    public static Spell WindsOfFate => new(
        "Winds of Fate",
        [SpellType.Special],
        [Lore.Heavens],
        "Time blurs and shifts as the Wizard changes the course of reality.",
        "10",
        "This spell allows the players to disregard one of each Warrior's dice rolls this turn and re-roll it.",
        "All Warriors on the board",
        "One Turn",
        "images/Spell/WindsOfFate.png"
    );


    // -------- CASTING 11 --------
    public static Spell CarnivalOfDeath => new(
        "Carnival of Death",
        [SpellType.Attack],
        [Lore.Death],
        "Overcome by an unreasoning madness, the Monsters leap towards each other in a berserk killing frenzy, completely ignoring the Warriors.",
        "11",
        "Roll 1D6 for every Monster on the same board section as the Wizard. On a 1 the spell has no effect on that Monster. On a 2+ that Monster moves towards its nearest companion and this turn attacks it instead of the Warriors. Affected Monsters are not subject to pinning rules while under this effect.",
        "All Monsters on the same board section as the Wizard",
        "One Turn",
        "images/Spell/CarnivalOfDeath.png"
    );

    public static Spell WindowOfTheVoid => new(
        "Window of the Void",
        [SpellType.Attack],
        [Lore.Shadow],
        "The Wizard creates a dark, glittering portal that hypnotically attracts nearby Monsters.",
        "11",
        "Create a hole in any empty square within the Wizard's line of sight. Roll 1D6 for each Monster adjacent to the hole. On 1–4 the Monster stands its ground; on 5–6 the Monster is attracted to the hole and vanishes. At the end of the turn the hole disappears. Warriors are not affected but cannot enter that square.",
        "Any empty square within the Wizard's line of sight",
        "One Turn",
        "images/Spell/WindowOfTheVoid.png"
    );

    public static Spell TissueOfLife => new(
        "Tissue of Life",
        [SpellType.Healing],
        [Lore.Fire],
        "The Wizard channels a vast surge of energy through his body, redirecting it as glowing bolts that slam into his companions and heal their wounds.",
        "11",
        "Roll 1D6 for each Warrior on the board (including the Wizard). On 1–3 the spell has no effect on that Warrior. On 4–6 that Warrior is restored to his Starting Wounds.",
        "All Warriors on the board",
        "Immediate",
        "images/Spell/TissueOfLife.png"
    );

    public static Spell TowerOfIsolation => new(
        "Tower of Isolation",
        [SpellType.Special],
        [Lore.Shadow],
        "The Wizard suddenly vanishes, transported back to his study many leagues away from the dungeon.",
        "11",
        "This spell allows the Wizard to transport himself out of the dungeon to the nearest Settlement (and back) at any time.",
        "The Wizard",
        "Immediate",
        "images/Spell/TowerOfIsolation.png"
    );

    // -------- CASTING 12 --------
    public static Spell Firestorm => new(
        "Firestorm",
        [SpellType.Attack],
        [Lore.Fire],
        "A blazing wall of fire springs up, filling the area with searing flames.",
        "12",
        "Pick a 2x2 area within the Wizard's line of sight. All Monsters on the targeted area suffer 6D6 Wounds (roll once for all Monsters), with no modifiers.",
        "All Monsters on a 2x2 area within the Wizard's line of sight",
        "Immediate",
        "images/Spell/Firestorm.png"
    );

    public static Spell Transmute => new(
        "Transmute",
        [SpellType.Attack],
        [Lore.Metal],
        "The Wizard grins as he touches his foe, invoking the power of the earth to possess him.",
        "12",
        "Turn a single Monster in an adjacent square to stone on a successful to-hit roll, killing it. If the target has Magic Resistance or Magic Dispel, the roll required to ignore the spell is at -1.",
        "One Monster adjacent to the Wizard",
        "Immediate",
        "images/Spell/Transmute.png"
    );

    public static Spell VortexOfDestruction => new(
        "Vortex of Destruction",
        [SpellType.Attack],
        [Lore.Fire],
        "The Wizard creates a howling vortex of destruction in the room.",
        "12",
        "Roll 2D6 for every Monster on the same board section as the Wizard. If the score is equal to or less than the Wizard's Battle-level that Monster is sucked into the void and is removed from the board. If the score is greater, the target is unaffected.",
        "All Monsters on the same board section as the Wizard",
        "Immediate",
        "images/Spell/VortexOfDestruction.png"
    );

    public static Spell TransportOfTheDamned => new(
        "Transport of the Damned",
        [SpellType.Special],
        [Lore.Shadow],
        "The Wizard summons a ghostly carriage to take himself and his companions away from the dungeon.",
        "12",
        "This spell allows the Wizard to transport all the Warriors out of the dungeon to the nearest Settlement (and back). The Wizard always gets through safely; for each other Warrior roll 1D6—on a 1 that Warrior is sucked into the warp and his soul is destroyed.",
        "All Warriors on the board",
        "Immediate",
        "images/Spell/TransportOfTheDamned.png"
    );

    // ------------------------
    // Helpers
    // ------------------------

    public static IEnumerable<Spell> AllSpells()
    {
        var list = new List<Spell>
        {
            // casting 1
            Bloodblade,
            Sting,
            Coughing,
            Drop,
            CreateFood,
            CureSmallWounds,
            FleetOfFoot,
            Open,
            // casting 2
            FleshWorm,
            Strength,
            FeignDeath,
            MarshLights,
            Nausea,
            Slip,
            HealingHands,
            Tongues,
            ZoneOfSilence,
            // casting 3
            FistOfIron,
            IceBlades,
            OgreStrength,
            Confuse,
            GlitteringRobe,
            FingerOfLife,
            Speed,
            // casting 4
            AcidBlast,
            IceTomb,
            LightningBolt,
            Levitate,
            Rebound,
            HealWounds,
            DispelMagic,
            SecondSight,
            // casting 5
            Fireball,
            Firehammer,
            Freeze,
            PitOfDespair,
            Blur,
            Dazzle,
            IronSkin,
            LifeForce,
            Lifebringer,
            Invisibility,
            Sleep,
            // casting 6
            Cataclysm,
            SwordsOfDoom,
            Weaponmaster,
            Invulnerability,
            Shield,
            Resurrection,
            CauseAnimosity,
            CreateBridge,
            WingsOfPower,
            // casting 7
            BurningStorm,
            ChainLightning,
            DomeOfPower,
            FoolsGold,
            Bloodpulse,
            Glory,
            TimeFreeze,
            WarpJump,
            // casting 8
            Hellbeast,
            SpearOfLight,
            CageOfStone,
            HaloOfVengeance,
            Voidmaster,
            ChorusOfValour,
            // casting 9
            Lifestealer,
            HoundsOfGrimnair,
            // casting 10
            Windblast,
            RadianceOfPtolos,
            Heartbeat,
            WindsOfFate,
            // casting 11
            CarnivalOfDeath,
            WindowOfTheVoid,
            TissueOfLife,
            TowerOfIsolation,
            // casting 12
            Firestorm,
            Transmute,
            VortexOfDestruction,
            TransportOfTheDamned
        };
        return list;
    }

    public static IEnumerable<Spell> GetSpellsByCastingNumber(string castingNumber)
    {
        return AllSpells().Where(s => s.CastingNumber == castingNumber);
    }

    public static Spell? GetSpellByValue(string value)
    {
        return AllSpells().FirstOrDefault(s => s.CastingNumber == value);
    }

    public static readonly List<Spell> StartingSpells =
    [
        Fireball,
        Freeze,
        LightningBolt,
        OgreStrength,

        Levitate,
        Rebound,
        Shield,
        IronSkin,
        Confuse,

        HealWounds,
        HealingHands,
        LifeForce,
        Lifebringer,
        Resurrection
    ];

    public static readonly List<Spell> StartingAttackSpells =
        StartingSpells.Where(s => s.SpellTypes.Contains(SpellType.Attack)).ToList();

    public static readonly List<Spell> StartingDefensiveSpells =
        StartingSpells.Where(s => s.SpellTypes.Contains(SpellType.Defensive)).ToList();

    public static readonly List<Spell> StartingHealingSpells =
        StartingSpells.Where(s => s.SpellTypes.Contains(SpellType.Healing)).ToList();
    public static class SpellSelectionHelper
    {
        public static List<List<int>> GenerateCastingNumberCombinations(List<int> diceRolls)
        {
            var results = new List<List<int>>();
            GenerateCombinationsRecursive(diceRolls, new List<int>(), results);
            return results;
        }

        private static void GenerateCombinationsRecursive(List<int> remainingDice, List<int> current, List<List<int>> results)
        {
            if (remainingDice.Count == 0)
            {
                results.Add(new List<int>(current));
                return;
            }

            // Try all group sizes from 1 up to remainingDice.Count
            for (var i = 1; i <= remainingDice.Count; i++)
            {
                var group = remainingDice.Take(i).ToList();
                var sum = group.Sum();

                var nextRemaining = remainingDice.Skip(i).ToList();
                var nextCurrent = new List<int>(current) { sum };

                GenerateCombinationsRecursive(nextRemaining, nextCurrent, results);
            }
        }
    }
}
