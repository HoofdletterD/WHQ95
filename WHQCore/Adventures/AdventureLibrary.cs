namespace WHQCore.Adventures;

public static class AdventureLibrary
{
    public static IReadOnlyList<Adventure> All => new List<Adventure>
    {
        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FountainOfLight,

            Roll = 1,

            Title = "Clearwater",

            Background =
                "In the south of the Empire lies Bugman's Brewery, where the Dwarf brewers create the finest beers in the Warhammer World. " +
                "Always striving for perfection in his brews, Bugman has heard of a dried-up fountain that used to be the source of the purest water in the world, " +
                "and purer water makes better beer. The story is that a potion of dizzying power must be poured into the fountain if the waters are ever to flow again. " +
                "The only powerful dizzying potion available in barrels that Bugman can think of is a cask of his precious Bugman's XXXXXX Superbrew. " +
                "The legend tells that the fountain lies in the caves of the Black Mountains, somewhere between Karak Him and Black Fire Pass. " +
                "The Lord of Karak Him has agreed to let four Warriors search for the fountain as long as he receives a supply of the resulting beer. " +
                "Unfortunately, the caves are now populated by all manner of evil beasts.",

            SpecialRules =
                "Nominate one Warrior to carry the cask of beer. The chosen Warrior's Movement is reduced by 1 square per turn while carrying it. " +
                "Warriors may drink from the barrel. If every Warrior drinks more than once there will not be enough beer left to activate the fountain. " +
                "Each Warrior who drinks must roll on the Clearwater drinking table described in the adventure.",

            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters are present in the Fountain Room. " +
                "When all Monsters are defeated, the Warrior carrying the barrel may pour it into the fountain. " +
                "Fresh waters spring forth and the adventure is completed." +
                "Each Warrior receives 1D6 x 20 Gold and a 2 percent royalty on all sales of Bugman's Freshbrew XI.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FountainOfLight,

            Roll = 2,

            Title = "Skaven Curse!",

            Background =
                "The water supply for the city of Miragliano comes from many sources. The main supply is from the rivers that run down from the Vaults, but the most precious comes from an ancient shrine hidden in a deep cave system, from which springs a gushing fountain. This fountain provides the purest water in Miragliano, and has done so for countless years. The Skaven of Skavenblight have found the fountain and polluted it, filling it with the twisting influence of warpstone. Already a sickness spreads in Miragliano, and a large reward has been offered to anyone who can find a cure. A far-seeing academic has guessed at the truth, and wishes to find out if the waters are indeed polluted. He has gathered your band of Warriors together to seek the source of the waters and, if needs be, cleanse it.",

            SpecialRules = string.Empty,

            ObjectiveRoomRules =
                "Do not roll on the Objective Room Monster Table to determine what Monsters the fountain room contains. Instead, it is guarded by 12 Skaven warriors. When all the Skaven defending the fountain are killed, the Warriors  must remove the warpstone from the fountain. This is hazardous in the extreme. There is enough warpstone in the fountain for eachWarrior to take a heavy load. To remove the warpstone, your Warrior must be in a square adjacent to the fountain. Upon removing it, roll 2D6. The Warrior loses that number of Wounds, with no modifiers for Toughness or armour. This may of course kill the Warrior, but at least the warpstone is removed! Each Warrior must remove one load. No Warrior can try more than once, as the warpstone’s power will kill him immediately he tries a second time. Once the fountain is purified, the Warriors may return to Miragliano to claim the reward of 1D6 x 50 gold each.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FountainOfLight,

            Roll = 3,

            Title = "The Water of Fate",

            Background =
                "The Emperor’s Wizards tell him that the mystical signs warn of an imminent invasion, but they can see no further than this, as dark powers cloud their vision. " +
                "They have no idea if the assault will come from the Chaos Wastes of the far North, from the Orcs of the Dark Lands to the East, or from some other unsuspected quarter. " +
                "The most aged Wizard Lord of the Celestial College suggests that the answer lies in a magical pool - the Fountain of Fate which holds the secrets of all things. " +
                "While the Empire prepares all its borders for war, a party of four brave Warriors is gathered to search for the fountain, reputed to be found somewhere below the Middle Mountains.",

            SpecialRules =
                "This is a two-part adventure: the first part is to find the fountain, the second is to return once more to the surface, and to safety.",

            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the fountain room contains. " +
                "Once the Monsters are defeated, the Warriors may look into the fountain. While there are Monsters alive in the fountain room a magical aura prevents the fountain from operating. " +
                "Each Warrior may look into the fountain once and once only, and must be standing in a square adjacent to it to do so. " +
                "When a Warrior looks into the fountain, roll 1D6. On a 1, 2 or 3, nothing is revealed. On a 4, 5 or 6, the fountain shimmers and shows Orc and Goblin armies massing in the Worlds Edge Mountains - this is where the attack will come from! " +
                "Each Warrior may also drink once from the fountain. Roll 1D6 on the following table: " +
                "1: The waters burn the Warrior from the inside, shrivelling his innards to a crisp. With an anguished shriek he falls down dead! " +
                "2-6: The waters heal the Warrior back up to full Wounds and, if he is the Wizard, restore him to his original quota of Power Tokens. " +
                "As soon as the last Warrior who wishes to has looked into the fountain, a door creaks open in the far wall. The Warriors must escape through this door and fight their way to freedom. " +
                "The Escape!" +
                "Take another 1D6+2 Dungeon Cards and create a new Dungeon Deck. These are the rooms the Warriors must get through before they reach the surface. " +
                "Use them just like the normal Dungeon Deck, exploring beyond the new doorway in the fountain room just as you would any other, turning over the top Dungeon Card to see what lies beyond. " +
                "When the Warriors reach the final room or corridor, they notice light shining in from a hole in the roof. With a great deal of effort, they scramble up and escape through the hole, returning to the Emperor in time to warn him of the impending attack. " +
                "If they discover the source of the impending attack, the Warriors are richly rewarded upon their return, gaining 2D6 x 100 gold each. If they don’t, they get nothing.",

            Notes = string.Empty
        },
        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FountainOfLight,

            Roll = 4,

            Title = "The sword of true kingship",

            Background =
                "It is claimed that an ancient sword holds the secret of the kingship of one of the small realms of the Border Princes. " +
                "When immersed in water of unparalleled purity, it is said that it reveals the name of the true king of the realm. " +
                "Unfortunately, no water save that of the legendary Fountain of Light is pure enough to cause the sword to reveal the name. " +
                "The four Warriors must therefore take the sword and journey to the Middle Mountains to find the fountain. " +
                "Once there, they can determine which of the three princes who claim the kingship - Bardin, Rudin and Gredin - is the rightful heir.",

            SpecialRules =
                "Before the Warriors embark on the adventure, each player must secretly choose the prince whom they believe to be the true king and write his name down on their Adventure Record sheet. " +
                "Nominate one Warrior to carry the sword. If the Warrior decides to wield it in combat rather than his own weapon, it causes 1 extra Wound when it hits.",

            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the fountain room contains. " +
                "Once the Monsters are defeated, the Warriors may put the sword in the fountain, at which point the name of the true king is magically engraved in its blade. Roll 1D6: " +
                "1-2: Bardin. 3-4: Rudin. 5-6: Gredin. " +
                "As the sword is plunged into the waters, revealing the name, there is an earth-shattering roar and the ceiling of the chamber begins to collapse inwards. " +
                "Each player must roll 1D6 and add his Warrior's Initiative to the score. If the total is 7 or more, the Warrior manages to avoid the falling rubble. " +
                "If the total is less than 7, the Warrior takes 3D6 Wounds, modified by Toughness and armour. " +
                "As the dust clears, light pours into the chamber revealing a route to the outside world. The Warriors may now return to crown the new king! " +
                "Warriors that chose the correct prince get 500 gold for supporting the new monarch and helping him to his rightful throne. " +
                "Warriors that chose to support the wrong prince get 1D6 x 30 gold for their part in the adventure.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FountainOfLight,

            Roll = 5,

            Title = "Nurgles Rot",

            Background =
                "The city of Praag, which lies close to the border of the Chaos Wastes, has been struck with the dreaded Nurgle's Rot, a disease spread by the foul Power of pestilence and decay. " +
                "The death toll is mounting, but the physicians in the city are powerless unless they can find a cure. There appears to be only one hope. " +
                "In the ancient myths and songs of Kislev, a fountain is described that has waters so pure and so cold that any creature harbouring any evil nature is frozen to death as soon as it touches the waters. " +
                "The doctors of Praag believe that this may provide a cure for the disease. " +
                "The fountain is said to lie in the mountains north of the High Pass. The Warriors must seek it out and return with some of the precious liquid. " +
                "They are given a special container in which to carry the water.",

            SpecialRules = string.Empty,

            ObjectiveRoomRules =
                "First declare which Warrior is carrying the special container. " +
                "Roll on the Objective Room Monster Table to determine what Monsters the fountain room contains. " +
                "Once the Monsters are dead, the Warrior carrying the container may attempt to take the waters. To do so he must stand in a square adjacent to the fountain. Roll 1D6. " +
                "If the result is a 1, the Warrior attempting to take the water isn't deemed pure enough of spirit and is killed. On any other result the water is safely transferred to the special container. " +
                "If the attempt fails, another Warrior may try. " +
                "As the first Warrior tries to take the waters he leans on one of the stone gargoyles' heads surrounding the fountain. " +
                "As he does so, it makes a soft click and an ominous creaking is heard from the far wall. With a groan of stone on stone, an ancient door slides open, leading to the outside world. " +
                "The surviving Warriors may now take the water back to Praag. The Warrior bearing the water gets a 500 gold reward, while all the other Warriors get 100 gold each.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FountainOfLight,

            Roll = 6,

            Title = "Fountain of Lost Souls",

            Background =
                "A mighty Sorcerer, resident in Marienburg, wishes to find the Burning Fountain, a mythical place rumoured to exist somewhere in the caves below the Dragonback Mountains. " +
                "Scrying its exact location has proven to be of no use, but he has managed to obtain a picture of the fountain itself in his sorcerous mirror, confirming that it does indeed lie somewhere under the mountains, and is guarded by ferocious monsters. " +
                "No matter how much gold he offers, no one can be found to venture that far afield, so he has cunningly entrapped the four Warriors under a curse, capturing their souls in glowing gems. " +
                "Using powerful magic, he has reached through his mirror and dropped these gems into the fountain. " +
                "The Warriors have no choice but to find the fountain and retrieve their lost souls. The gems must be returned to the Sorcerer before he can reunite the Warriors' ethereal bodies with their physical bodies. " +
                "He is apologetic about this underhand trick, but does promise rich rewards if the Warriors succeed in capturing some of the waters in a specially prepared container while they are there.",

            SpecialRules = string.Empty,

            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the fountain room contains. " +
                "Once the Monsters are defeated, the Warriors may attempt to take the gems from the fountain. " +
                "Roll 1D6 for each Warrior and add his Toughness. If the result is 6 or over, the Warrior survives the burning waters and retrieves his soul. " +
                "If the number is 5 or less, the Warrior is consumed by the power of the water and dies in agony. " +
                "While getting his gem, a Warrior may collect some of the water for the Sorcerer. " +
                "If the Warriors return to the Sorcerer with some of the water he reunites their souls and bodies and gives each of them 2D6 x 50 gold.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FightingPit,

            Roll = 1,

            Title = "The Beast",

            Background =
                "Captured by the Goblin Warlord Ugrul Headsticka while exploring the ruins of Karak Azgal, the Warriors have been given a chance to escape and, in the process, provide entertainment for the Goblins. " +
                "The Warriors must fight their way to freedom without weapons or armour! And as if that were not enough, their only way out is through the Minotaurs' lair.",

            SpecialRules =
                "The Warriors start this dungeon stripped of any armour and weapons they may have, and must fight with their bare hands. " +
                "No Armour: While they are without armour the Warriors may only deduct their Toughness from any blows that hit them. " +
                "No Weapons: The Warriors start with no weapons at all (even missile weapons), and must therefore fight in hand-to-hand combat using their fists. " +
                "While fighting unarmed, each Warrior does 1D6 Wounds when he hits, with no modifiers for Strength. " +
                "Events: When the first Monster Event Card is triggered, the Warriors notice that their assailants are carrying (but not using) their weapons! If the Warriors kill all these monsters, they may retrieve their weapons. " +
                "When the second Event Card that reveals Monsters is triggered, the Warriors see that their assailants are guarding their armour. If the Warriors kill all these monsters, they may retrieve their armour.",

            ObjectiveRoomRules =
                "When the Warriors reach the objective room do not roll on the Objective Room Monster Table, as the following special rules apply. " +
                "The only way for the Warriors to escape the dungeon is through the trapdoor at the bottom of the fighting pit. However, the fighting pit has had a powerful curse laid upon it, and for every Warrior, up to a total of three, who jumps into the pit, a Minotaur appears next to him and will fight him to the death. " +
                "As soon as a Warrior is placed in one of the fighting pit squares, place a Minotaur model in any adjacent square in the pit. The Minotaurs will attack in the Monsters' Phase as normal. " +
                "If all four of the Warriors jump into the pit use the rule of One-on-One to determine which Warriors the three Minotaurs attack. Any Warriors that stay out of the fighting pit may help defeat the Minotaurs if they can - by firing bows, etc. - without causing another Minotaur to appear. " +
                "When the first Minotaur is killed, it and all the other Minotaurs who magically appeared immediately vanish and the combat is over. " +
                "Once the Warriors defeat the Minotaurs, they each find one item of treasure in the bottom of the pit. Clutching their new-found wealth, the Warriors may now escape the dungeon through the trapdoor at the bottom of the fighting pit.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FightingPit,

            Roll = 2,

            Title = "Sword of Power",

            Background =
                "The last Warrior to brave the perils of the fighting pit took a sword of great power to help him slay the Minotaur that dwelt within it. " +
                "However, despite the sword he was destroyed by the Minotaur and his body eaten. The sword now lies rusting at the bottom of the pit. " +
                "The sword in question was an ancient heirloom stolen from the Barbarian's father many years ago, and the Barbarian has sworn to get it back. " +
                "He must therefore descend into the dungeon and kill the Minotaur himself. The other Warriors may accompany him, but it must be the Barbarian who slays the beast and retrieves the sword.",

            SpecialRules =
                "This is a straightforward dungeon - the Warriors must find the pit, and the Barbarian must slay the Minotaur who lives in it and reclaim his father's sword. " +
                "The only problem is that the Barbarian doesn't want any help with killing the Minotaur - not even magic or missile weapons. " +
                "Of course, this means that the Barbarian is the only Warrior that will get any gold for killing the Minotaur! " +
                "If the Barbarian manages to retrieve the sword, while using it he gets +1 on his roll to go berserk.",

            ObjectiveRoomRules =
                "When the Warriors reach the objective room do not roll on the Objective Room Monster Table, as the following special rules apply. " +
                "When the Warriors enter the objective room place a Minotaur in any square in the pit. The Minotaur will not climb out of the pit unless attacked by a Warrior with missile weapons or magic. " +
                "The Minotaur attacks in the Monsters' Phase as normal. This Minotaur is particularly powerful and gets an extra 5 Wounds. " +
                "Once the Minotaur is defeated, the Warriors may retrieve the sword and escape the dungeon through the portcullis in the far wall.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FightingPit,

            Roll = 3,

            Title = "Hell's Gate",

            Background =
                "In the dungeons below Karak Azgal, a gate has been opened by evil sorcery. The gate leads to the plains of the Dark Lands, and monsters are continually spewing out of its black depths into the bowels of Karak Azgal. " +
                "The more Monsters that gather in the depths of the ruined Dwarf city, the greater the threat to the Old World, so a party of brave Warriors must venture into the city and seal the gate.",

            SpecialRules = string.Empty,

            ObjectiveRoomRules =
                "The gate is located in the fighting pit. When the Warriors enter the objective room, consult the Objective Room Monster Table to determine what Monsters are in it. " +
                "The Monsters are placed at the far end of the pit, next to the gate, but will swarm out to engulf the Warriors during the first Monsters' Phase. The Monsters may climb out of the pit with no Movement penalty. " +
                "Sealing the Gate: Once the Warriors kill the Monsters, they must try to seal the gate permanently. This can only be done with a complex invocation that only the Wizard can perform. " +
                "At the start of the Warriors' Phase, the player controlling the Wizard may roll between 1 and 6 dice. If one or more of the dice comes up as a 6 and none of the dice comes up as a 1, the gate is sealed and the Warriors have succeeded in their quest. " +
                "If any of the dice come up as a 1 the gate remains open this turn, no matter how many 6s are rolled. The Wizard may try and seal the gate once per turn. " +
                "At the start of each Monsters' Phase that the gate is open, and while there are no Monsters on the board, draw an Event Card. Monsters will continue to appear until the gate is closed. " +
                "If the Warriors seal the gate and escape alive they are rewarded with one item of treasure each - give one Treasure Card to each Warrior.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FightingPit,

            Roll = 4,

            Title = "Blood Debt",

            Background =
                "The Warriors must repay a debt that they incurred in an earlier adventure. The Wizard Vestigkalass rescued them from certain death in the dungeons below Crookback Mountain some months ago, in exchange for 10 years of their memories, which he has stored in a cursed mirror. " +
                "The only way the Warriors can regain those memories is to pay him 2,000 gold, or kill the pets of his arch rival, the evil Sorcerer Grachnach. The only problems for the Warriors are that they don't have 2,000 gold with which to pay the ransom, and that Grachnach's 'pets' are two blood-crazed Minotaurs... " +
                "Grachnach lives in a carefully concealed labyrinth close to Mad Dog Pass, and is away on some evil errand at the moment. Now is the time for the Warriors to strike!",

            SpecialRules =
                "The Warriors' main objective is to enter the dungeon and kill Grachnach's Minotaurs, who are kept chained up in the fighting pit. Of course, if they find treasure totalling over 2,000 gold between them en route, they may leave immediately and pay the ransom instead. " +
                "To complicate matters, while the Warriors are in the dungeon there is a chance that Grachnach will catch them. Every time an Unexpected Event that reveals monsters occurs, roll 1D6. If you score a 1 or 2, Grachnach has returned! " +
                "Grachnach has been scouring the mountains for Monsters to join his warband, and has returned with his new followers. He will not fight the Warriors himself, preferring to send his servants to crush them while he waits a safe distance away. " +
                "Roll on the Objective Room Monster Table to determine what Grachnach has recruited. Place them on the board along with the Monsters generated by the Unexpected Event. This event only happens once, as Grachnach can only return once! " +
                "Of course, even if the Warriors beat off this attack they must still complete the adventure, unless they have 2,000 gold to pay Vestigkalass.",

            ObjectiveRoomRules =
                "When the Warriors reach the objective room do not roll on the Objective Room Monster Table, as the following rules apply. " +
                "When the Warriors enter the objective room place the two Minotaurs in any squares in the pit. The Minotaurs will not climb out of the pit unless attacked by a Warrior with missile weapons or magic. " +
                "The Minotaurs will attack in the Monsters' Phase as normal. " +
                "Once the Minotaurs are defeated, the Warriors may escape through the trapdoor at the bottom of the fighting pit. " +
                "On their return Vestigkalass gives them their memories back, as promised. The only problem is, he isn't sure whose memories are whose. Each player should take a Warrior Counter to see which 10-year chunk of memories his Warrior regains. While this hasn't any effect on the game itself, it is rather amusing!",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FightingPit,

            Roll = 5,

            Title = "Man Eater",

            Background =
                "In the Drak Wald Forest of the Empire there are rumours circulating of a man-eating monster that is raiding nearby villages and eating the inhabitants. " +
                "According to the story, the monster is a great Minotaur, but no-one has actually seen the beast and lived to tell the tale. " +
                "The villagers are so worried that they are staying indoors and doing no work. The local sheriffs, therefore, have intervened to solve the problem once and for all. " +
                "They have located the entrance to a cave system, deep in the gloomy forest, and have employed the Warriors to kill the beast that lives within. " +
                "However, it isn't certain that the monster is a Minotaur at all, as the villagers are renowned for scaremongering...",

            SpecialRules = string.Empty,

            ObjectiveRoomRules =
                "When the Warriors reach the fighting pit, roll on the Objective Room Monster Table, subtracting 1 from the dice roll, to determine the nature of the beast and its pack (a roll of 1 still counts as a 1, of course). " +
                "If the beast turns out to be a Minotaur, the Warriors must kill it and return its head to the village. If they are successful, they will be rewarded with all the villagers' wealth. " +
                "Unfortunately, this amounts to no more than 10 gold each, as it is a very poor village. " +
                "If the beast isn't a Minotaur, the Warriors are scorned by the villagers, who don't believe them, and go unrewarded.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FightingPit,

            Roll = 6,

            Title = "Free the Prisoners",

            Background =
                "During a recent raid on Miragliano, the Skaven took around twenty wealthy and influential citizens as captives, and have been making all manner of unreasonable and outrageous threats ever since. " +
                "The Skaven know full well that their unconditional demands to hand over all the wealth, women and children of the city will never be agreed to, but it gives them a good excuse to send back portions of their victims as proof that they mean business. " +
                "The Warriors have been employed to enter the Blighted Marshes and rescue the prisoners from the dungeons of the Chaos ratmen.",

            SpecialRules = string.Empty,

            ObjectiveRoomRules =
                "The prisoners are being kept below the fighting pit, in a network of cells and guardrooms. Roll on the Objective Room Monster Table to determine the guardians of these cells, reading any Goblins as Skaven. " +
                "When the guardians are dead, each player rolls a dice. The number rolled is the number of prisoners his Warrior finds alive. Every prisoner a Warrior finds gives him 1D6 x 20 gold for freeing them. " +
                "At the bottom of the cell complex, there is a secret door that leads to the marshes above and to safety. In their weakened state the prisoners have not been able to open it, but the Warriors have no trouble. " +
                "They soon smash it down and take the captives to freedom.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FireChasm,

            Roll = 1,

            Title = "Destroy the Warpstone Icon",

            Background =
                "Rumours abound of a powerful long-lost Skaven artefact that has been rediscovered in the Worlds Edge Mountains. " +
                "The artefact is a skull-shaped icon made from raw warpstone, and its mutating powers are said to be beyond imagination. " +
                "The icon must be destroyed at all costs to stop the Skaven reclaiming it. Unfortunately, the only way to destroy the icon is to hurl it into the cleansing flames of the firechasm.",

            SpecialRules =
                "CROSSING THE CHASM: The rope bridge is the only way across the chasm, and is equivalent to 2 squares of Movement. " +
                "For each Warrior that attempts to cross the bridge roll 1D6 on the following table: " +
                "1-2: The Warrior slips on the ancient bridge. Roll 1D6 on the Firechasm Hazard Table. " +
                "3-6: The Warrior makes it safely across. " +
                "FIRECHASM HAZARD TABLE: " +
                "1: The Warrior falls into the chasm and is killed. " +
                "2-3: The Warrior slips, dangling into the flames. He is badly burnt, taking 1D6 Wounds with no deductions for Toughness or armour, but manages to haul himself across the opposite side of the chasm. " +
                "4: The Warrior slips, losing his grip on any one item of treasure or equipment. Determine which item is lost in the abyss randomly. " +
                "5-6: The Warrior grips the bridge as it starts to swing violently. No other Warriors may attempt to cross the bridge this turn. At the end of the turn, roll 1D6 for the Warrior to see which side of the chasm he ends up on: 1-3: The far side. 4-6: The near side. " +
                "Monsters have no such problems in crossing the bridge, as they do it all the time. " +
                "The first dungeon room that the Warriors enter contains a sturdy iron casket holding the icon. When the Warriors have completed the room's event, keep the dungeon room card next to the leader's Adventure Record sheet to remind yourself the Warriors have the casket.",

            ObjectiveRoomRules =
                "When the Warriors reach the firechasm, they must overcome the defenders of the chamber and hurl the warpstone icon into the flames. " +
                "To determine the Monsters that are guarding the firechasm, roll once on the Objective Room Monster Table. " +
                "If the icon is thrown into the chasm it is instantly consumed with a roar of lurid green flames. The room begins to collapse, and the Warriors must get out straight away or be crushed. " +
                "To escape, the Warriors must cross the chasm and exit through a secret door that opens in the far wall, behind the stone dragon. " +
                "The Warriors must escape within 2 turns of killing all the Monsters and hurling the icon into the chasm. After this point, the whole room caves in, killing any Warriors still inside. " +
                "Each Warrior who escapes the dungeon is rewarded with 1D6 x 100 gold for his part in the adventure.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FireChasm,

            Roll = 2,

            Title = "Banish the Daemon",

            Background =
                "The great Wizards of the Empire have scried out a powerful, brooding power that is growing below the ancient Dwarf hold of Karak Azgal. " +
                "As yet, they believe the presence to be relatively weak, and therefore probably bound to some material artefact such as a statue while it gathers strength. " +
                "Although they do not know its purpose, they suspect that it may be a lesser daemon of the Chaos Powers, trapped in the rocks below the earth in ages past, and freed by the incessant digging of the Goblins and Orcs as they search for the lost treasure of the Dwarfs who once inhabited the city. " +
                "The truth is that the daemon has escaped the prison of rock that held it for so long, and is now resident in a statue of a great fire dragon in an ancient temple (the firechasm). " +
                "Soon it will fully awaken, and walk the world once more. The Wizards have employed the Warriors to destroy the daemon and ensure that this never happens.",

            SpecialRules =
                "CROSSING THE CHASM: The rope bridge is the only way across the chasm, and is equivalent to 2 squares of Movement. " +
                "For each Warrior that attempts to cross the bridge roll 1D6 on the following table: " +
                "1-2: The Warrior slips on the ancient bridge. Roll 1D6 on the Firechasm Hazard Table. " +
                "3-6: The Warrior makes it safely across. " +
                "FIRECHASM HAZARD TABLE: " +
                "1: The Warrior falls into the chasm and is killed. " +
                "2-3: The Warrior slips, dangling into the flames. He is badly burnt, taking 1D6 Wounds with no deductions for Toughness or armour, but manages to haul himself across the opposite side of the chasm. " +
                "4: The Warrior slips, losing his grip on any one item of treasure or equipment. Determine which item is lost in the abyss randomly. " +
                "5-6: The Warrior grips the bridge as it starts to swing violently. No other Warriors may attempt to cross the bridge this turn. At the end of the turn, roll 1D6 for the Warrior to see which side of the chasm he ends up on: 1-3: The far side. 4-6: The near side. " +
                "Monsters have no such problems in crossing the bridge, as they do it all the time. " +
                "During this adventure, each warrior has been given a Magic Sword, which can only be used once. These blades are the only weapons that can damage the daemon. Against other monsters, the magic swords will hit automatically and kill whatever their wielder attacks.",


            ObjectiveRoomRules =
                "To determine the Monsters that are guarding the firechasm, roll once on the Objective Room Monster Table. " +
                "The magic swords that the Warriors have been given are the only things that will kill the daemon. To destroy the daemon, the Warriors must simply stand next to the stone dragon at the far end of the firechasm and strike it. " +
                "For each blow made by one of the swords on the dragon roll 1D6. On a score of 5 or 6, the dragon and the daemon are destroyed. After one blow, each sword is destroyed. " +
                "If the Warriors kill the daemon, the adventure is over. The Warriors are rewarded with 1D6 x 100 gold each for their part in the adventure. " +
                "If the daemon is not killed, it becomes enraged by the Warriors' puny attacks and animates the statue. Each Warrior suffers 4D6 Wounds, modified for Toughness and armour, as the dragon breathes fiery, superheated liquid over them. " +
                "Fortunately, the gouts of flame scorch an ancient tapestry hanging on one of the walls, revealing a passageway leading out to daylight. The Warriors may have failed in their quest, but at least any survivors can make good their escape without further harm. " +
                "If the Warriors decide to stay and fight the dragon they will be killed, as only the magic swords had any effect on it, and it is simply a matter of time before they are burnt to a crisp. " +
                "However, the daemon's efforts to animate the dragon have sapped its strength, so the Empire's leaders might just have enough time to mount a second expedition before it rouses to full power.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FireChasm,

            Roll = 3,

            Title = "Extinguish the Flames",

            Background =
                "Below the lost Dwarf stronghold of Karak Vlag, the ancient forge fires still burn. Now occupied by evil creatures, the flames' magical energies are being used to create chaotic and cursed weapons. " +
                "The forges must be extinguished before their new masters learn how to manufacture weapons of even more awesome power. " +
                "The Dwarf Lord of Zhufbar is host to the descendants of the lords of Karak Vlag, and shares their fears. Although the quenching of the ancient flames seems an act of unthinkable wrong, it is the only option available to prevent the creation of a greater evil. " +
                "The exiled lords of Karak Vlag know that only the first item forged in the magical fires - a ring - can extinguish the flames. As the ring is an ancient Dwarf treasure, it must be hurled into the chasm by a Dwarf. If the Dwarf is killed, then the Warriors have, by default, failed. " +
                "The Warriors must first defeat the guardians of the firechasm, as only then can the Dwarf hurl the ring into its depths. The ring in question is located on one of the claws of a dragon statue that decorates the firechasm.",

            SpecialRules =
                "CROSSING THE CHASM: The rope bridge is the only way across the chasm, and is equivalent to 2 squares of Movement. " +
                "For each Warrior that attempts to cross the bridge roll 1D6 on the following table: " +
                "1-2: The Warrior slips on the ancient bridge. Roll 1D6 on the Firechasm Hazard Table. " +
                "3-6: The Warrior makes it safely across. " +
                "FIRECHASM HAZARD TABLE: " +
                "1: The Warrior falls into the chasm and is killed. " +
                "2-3: The Warrior slips, dangling into the flames. He is badly burnt, taking 1D6 Wounds with no deductions for Toughness or armour, but manages to haul himself across the opposite side of the chasm. " +
                "4: The Warrior slips, losing his grip on any one item of treasure or equipment. Determine which item is lost in the abyss randomly. " +
                "5-6: The Warrior grips the bridge as it starts to swing violently. No other Warriors may attempt to cross the bridge this turn. At the end of the turn, roll 1D6 for the Warrior to see which side of the chasm he ends up on: 1-3: The far side. 4-6: The near side. " +
                "Monsters have no such problems in crossing the bridge, as they do it all the time.",

            ObjectiveRoomRules =
                "The Warriors must retrieve the ring from the dragon statue and throw it into the chasm. This cannot be done until all the Monsters defending the firechasm are destroyed. Once the defenders are killed, the Dwarf may retrieve the ring. " +
                "To determine the Monsters that are guarding the firechasm, roll once on the Objective Room Monster Table. " +
                "To retrieve the ring, the Dwarf must be standing next to the statue. He may try to get the ring once per turn, at the start of the Power Phase. For each attempt, roll 1D6 on the following table: " +
                "1-2: The ring is firmly stuck, and the noise the Warriors are making attracts trouble. Take an Event Card. " +
                "3-4: The ring is stuck. Try again next turn. " +
                "5-6: The ring slips easily off the dragon's claw. As it comes loose, a great panel of stone behind the dragon rolls away, revealing a passageway to the outside world. " +
                "To be able to throw the ring into the chasm, there must be no Monsters in the room, and the Dwarf must be standing in a square adjacent to the chasm. " +
                "As the ring is thrown into the chasm, the flames leap upwards and envelop anyone standing nearby. Each Warrior in a square adjacent to the edge of the chasm suffers 2D6 Wounds, modified for Toughness and armour. " +
                "The flames then slowly flicker and die, and the adventure is over. The Warriors may now escape via the tunnel. " +
                "Each surviving Warrior is rewarded with treasure from the hoard of the Lords of Zhufbar. Take a Treasure Card for each Warrior.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FireChasm,

            Roll = 4,

            Title = "Destroy the Bridge",

            Background =
                "The Warriors are being pursued through the Worlds Edge Mountains, via tunnels deep below ground, by the inhabitants of the dark under-realms. " +
                "With them, the Warriors have the long-lost crown of the ancient Dwarf Kings of Mount Silverspear (now known as Mount Grimfang), which has been retrieved from the evil creatures that stole it. " +
                "The Warriors have a final obstacle to overcome before they reach safety. The dangerous route that they follow leads to the firechasm, across which lies a slender bridge. " +
                "If they can cross the bridge and destroy it before their pursuers arrive in great numbers, they will gain precious time and will probably escape from the mountains alive. If not, they will surely perish as the evil hordes overwhelm them.",

            SpecialRules =
                "CROSSING THE CHASM: The rope bridge is the only way across the chasm, and is equivalent to 2 squares of Movement. " +
                "For each Warrior that attempts to cross the bridge roll 1D6 on the following table: " +
                "1-2: The Warrior slips on the ancient bridge. Roll 1D6 on the Firechasm Hazard Table. " +
                "3-6: The Warrior makes it safely across. " +
                "FIRECHASM HAZARD TABLE: " +
                "1: The Warrior falls into the chasm and is killed. " +
                "2-3: The Warrior slips, dangling into the flames. He is badly burnt, taking 1D6 Wounds with no deductions for Toughness or armour, but manages to haul himself across the opposite side of the chasm. " +
                "4: The Warrior slips, losing his grip on any one item of treasure or equipment. Determine which item is lost in the abyss randomly. " +
                "5-6: The Warrior grips the bridge as it starts to swing violently. No other Warriors may attempt to cross the bridge this turn. At the end of the turn, roll 1D6 for the Warrior to see which side of the chasm he ends up on: 1-3: The far side. 4-6: The near side. " +
                "Monsters have no such problems in crossing the bridge, as they do it all the time.",

            ObjectiveRoomRules =
                "When the Warriors reach the firechasm, they must fight whatever Monsters are there before crossing the bridge. To determine what is in the room, roll once on the Objective Room Monster Table. " +
                "Once the Warriors have crossed the bridge, they must break it to prevent pursuit. Any Warrior who is in the square at the end of the bridge, directly between the ropes that hold it up, may attempt to destroy the bridge during the Warriors' Phase instead of making an attack. " +
                "Roll 1D6 and add the Warrior's Strength to the score. If the total is 8 or over, the bridge is destroyed. " +
                "At the start of each turn in which the bridge is not destroyed, take an Event Card (in addition to any Unexpected Events that occur). Any Monsters that are generated by these Event Cards must be placed on the side of the chasm next to the door, as they represent the Monsters who are pursuing the Warriors through the dungeon. " +
                "If a Minotaur appears, it may leap the chasm without using the bridge, taking two squares of its Movement to do so. " +
                "Once the bridge is destroyed, the Warriors may escape through a small tunnel to the rear of the cave, behind the dragon statue. " +
                "At the end of the adventure, each surviving Warrior is rewarded with 1D6 x 50 gold.",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FireChasm,

            Roll = 5,

            Title = "Return the Dragon's Eye",

            Background =
                "Centuries ago, the great Dwarf hold of Karak Azgal fell to rampaging Orc hordes. In the last days before the city fell, the Dwarf smiths and forgemasters of the realm gathered together under their Lords' directions. " +
                "Their aim was to bind a dragon to the city to smite down its foes, and thus they built a great statue in a cavern far underground to act as a magical focus. " +
                "The Dwarfs put a great deal of their power into their labours, and the majority of it went into the two great gems that served as the dragon's eyes. " +
                "A great dispute raged for years to decide who owned these precious gems, as two rival Dwarf Lords each claimed to be the rightful owner. The grudge went back and forth for many years, and so did the gems as they were wrested from one clan to the other. " +
                "Placing them in the position of honour in the statue was seen as one way of settling the dispute forever. It was not to be, however, as one of the embittered Dwarfs crept into the chamber before the ceremony and stole one of the dragon's eyes. " +
                "Shortly after, Karak Azgal fell to the Orcs and the unbound dragon arrived. The Dwarfs made good their escape, leaving the once glorious city to the dark, brooding presence of the great beast and the Orc intruders. " +
                "The dragon has since been slain by a great Dwarf hero, but the city itself has never been cleared of the Orcs and Goblins who now rule its gloomy caverns. The Dwarfs blame this misfortune on the theft of the gem, and legend tells that Karak Azgal is cursed unless the gem is replaced. " +
                "Now the gem has been found, and the guardian and self-appointed ruler-in-exile of the city has given the Warriors permission to try and return the stone, as long as they agree to give him half of whatever treasure they find on the way.",

            SpecialRules =
                "CROSSING THE CHASM: The rope bridge is the only way across the chasm, and is equivalent to 2 squares of Movement. " +
                "For each Warrior that attempts to cross the bridge roll 1D6 on the following table: " +
                "1-2: The Warrior slips on the ancient bridge. Roll 1D6 on the Firechasm Hazard Table. " +
                "3-6: The Warrior makes it safely across. " +
                "FIRECHASM HAZARD TABLE: " +
                "1: The Warrior falls into the chasm and is killed. " +
                "2-3: The Warrior slips, dangling into the flames. He is badly burnt, taking 1D6 Wounds with no deductions for Toughness or armour, but manages to haul himself across the opposite side of the chasm. " +
                "4: The Warrior slips, losing his grip on any one item of treasure or equipment. Determine which item is lost in the abyss randomly. " +
                "5-6: The Warrior grips the bridge as it starts to swing violently. No other Warriors may attempt to cross the bridge this turn. At the end of the turn, roll 1D6 for the Warrior to see which side of the chasm he ends up on: 1-3: The far side. 4-6: The near side. " +
                "Monsters have no such problems in crossing the bridge, as they do it all the time.",

            ObjectiveRoomRules =
                "The Dwarf must carry the gem and put it back into the dragon's eye socket. To put the gem back, he has to stand in a square adjacent to the dragon's head. If the Dwarf is killed, the Warriors fail by default. " +
                "When the Warriors enter the firechasm, roll on the Objective Room Monster Table to determine what is in the room. These Monsters must be killed before the gem can be placed back in the dragon's eye socket. " +
                "If the gem is successfully replaced, a trapdoor opens in the plinth that the statue sits on. Inside are the remains of the dragon's hoard: 3D6 x 100 gold for each Warrior, of which half must be given up, as agreed!",

            Notes = string.Empty
        },

        new()
        {
            ObjectiveRoom = ObjectiveRoomType.FireChasm,

            Roll = 6,

            Title = "Preserve the Fires",

            Background =
                "The magical flames of the Dwarf temple, the Firechasm, are in danger of being extinguished by the foul Skaven who now occupy the ancient Dwarf city of Karak Azgal. " +
                "They plan to fill the entire chasm with debris, hoping to stem the magma flow and cause a pressure build up deep underground. Even now, their engineers are channelling tunnels to send the diverted magma spurting into the areas of the city occupied by Orcs and other creatures, as well as hopefully burying the Dwarf fortress occupied by Kargun Skalfson that sits at the entrance to Karak Azgal. " +
                "If the Skaven succeed, there is a good chance that the ancient Dwarf citadel will be sealed off forever, leaving them free to search for the lost Dwarf treasure hoards rumoured to lie in its deepest halls. " +
                "Spies have reported this fiendish plan to the Emperor and his Dwarf allies, who are now mounting a frontal assault on Karak Azgal. In reality though, this is simply a cover. They know that the only hope of thwarting the Skaven's plan lies with small bands of brave Warriors who must steal unseen into the heart of the Skaven area of the city, and kill the engineers who are setting the plot in motion. " +
                "Other bands of Warriors will attempt to block the tunnels created by the Skaven to channel the magma. Your band of Warriors has been chosen to stop the damming of the firechasm itself.",

            SpecialRules =
                "CROSSING THE CHASM: The rope bridge is the only way across the chasm, and is equivalent to 2 squares of Movement. " +
                "For each Warrior that attempts to cross the bridge roll 1D6 on the following table: " +
                "1-2: The Warrior slips on the ancient bridge. Roll 1D6 on the Firechasm Hazard Table. " +
                "3-6: The Warrior makes it safely across. " +
                "FIRECHASM HAZARD TABLE: " +
                "1: The Warrior falls into the chasm and is killed. " +
                "2-3: The Warrior slips, dangling into the flames. He is badly burnt, taking 1D6 Wounds with no deductions for Toughness or armour, but manages to haul himself across the opposite side of the chasm. " +
                "4: The Warrior slips, losing his grip on any one item of treasure or equipment. Determine which item is lost in the abyss randomly. " +
                "5-6: The Warrior grips the bridge as it starts to swing violently. No other Warriors may attempt to cross the bridge this turn. At the end of the turn, roll 1D6 for the Warrior to see which side of the chasm he ends up on: 1-3: The far side. 4-6: The near side. " +
                "Monsters have no such problems in crossing the bridge, as they do it all the time.",

            ObjectiveRoomRules =
                "When the Warriors enter the firechasm, do not roll on the Objective Room Monster Table. Instead, the firechasm room is guarded by 1D6+6 Skaven warriors. Place all but one according to the normal rules for setting up Monsters. The other Skaven should be placed on the far side of the chasm, next to the dragon statue. He is the head Skaven engineer, and mastermind of the foul plot. " +
                "As soon as the Warriors enter the firechasm roll 2D6. The Warriors have this number of turns in which to kill the guards, get across the chasm and kill the engineer. " +
                "If the Warriors succeed, they may escape through a secret tunnel at the back of the chamber, and are rewarded with 1D6 x 50 gold each. " +
                "If they fail to kill the engineer in time, roll 1D6 on the following table: " +
                "1-2: The engineer operates a steel lever, and tons of debris plunge into the magma pool. Such is the force of the resulting explosion that all the Warriors and Skaven are killed. " +
                "3-4: The Warriors have failed! The future of Karak Azgal now lies in the hands of the other teams of Warriors. Let's hope they fare better! Tons of debris crash into the firechasm, blocking it completely. The engineer squeaks out his triumph, and the Warriors realise that they have failed utterly. Making good their escape, the Warriors rapidly manage to escape through a small passageway to the outside world, from where they can put as much distance between themselves and the imminent eruption. " +
                "5-6: The engineer operates the lever to drop tons of debris into the chasm, and it snaps off in his paws! The Warriors have another 1D6 turns in which to kill him as he fixes the lever. If he is not dead by then, roll on this table again.",

            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.TombChamber,
            Roll = 1,
            Title = "Exorcism",
            Background =
                "Deep below Middenheim there is a maze of tunnels inhabited by all manner of evil creatures. No-one ventures into this dark realm, and the entrances in the city have been sealed for centuries. Now, however, an evil presence has been detected by the priests of Ulric, the holy leaders of the city. " +
                "The source of this malign power is growing, and resides somewhere in the ancient catacombs below the city. The priests suspect it may be the spirit of a long dead Necromancer, returned to wreak havoc once again on the inhabitants of Middenheim. Like moths to a candle, other malign and twisted creatures are being drawn to the tunnels below Middenheim by this evil presence. " +
                "Carrying holy artefacts from the temples of the city, the Warriors must descend into the catacombs to exorcise the evil before its power grows too strong to contain.",
            SpecialRules =
                "Each Warrior has been given a holy symbol of Ulric to take into the dungeon below Middenheim. These artefacts must be placed on top of the Necromancer's tomb to lay him to rest.",
            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the tomb chamber contains. " +
                "Once the Monsters are defeated, each Warrior may move to a square adjacent to the tomb and lay his artefact on the tomb lid, in an attempt to exorcise the evil that dwells within it. " +
                "At the start of the next turn, during the Power Phase, each player must roll 1D6. If any of the dice score a 1, take another Event Card as the evil spirit summons vile creatures to his aid. Once these are killed, the Warriors may try again. This continues until the Warriors do not roll any 1s, at which point the spirit is destroyed and the evil lifted. The Warriors may now make their way to the surface to be hailed as heroes. " +
                "While in the tomb, the Warriors find 1D6 x 50 gold each, plus they get a further 1D6 x 50 gold each as reward for their part in the adventure.",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.TombChamber,
            Roll = 2,
            Title = "The Sword of the Deathking",
            Background =
                "The Fortress of Vorag lies beyond the Badlands, on the Plain of Bone. It was from this proud, cruel citadel that Ashkral Deathking, a follower of the all-powerful Necromancer Nagash, ruled many centuries ago. Endless legions of the dead strode to battle at his command, and the living fell before their unearthly might. " +
                "When Ashkral was overthrown by the Orc Warlord Morak Bloodcrusher, the dying Necromancer swore that he would one day return. His shattered body was taken by his acolytes to a secret place deep beneath Cripple Peak, on the shores of the Sour Sea. However, the Deathking was not truly dead, he was merely in a state of limbo between this life and the next. The only weapon said to be truly able to kill the Deathking was the sword he himself had wielded. This was to be buried with him so that it could not fulfil its destiny, and so that he could wield the powerful blade when he arose from beyond the grave. " +
                "Unfortunately, on the way to his tomb, the acolytes carrying the sword were ambushed and killed. With his last burst of energy, before he passed over to meet his master, the head acolyte hurled the sword into the Sour Sea, screaming that it would never be seen again until the Deathking stirred once more. " +
                "Since then, there have been great upheavals in the land, both politically and physically. The nearby volcano, Karag Haraz, has erupted many times in the years since the Deathking's defeat, spewing lava and magma across the region and causing the earth to tremble and shift. Over the years the citadel has been reduced to rubble and the Deathking's story has passed into legend. " +
                "However, after the most recent eruption an ancient sword was thrown up onto the surface, and the entrance to a long sealed dungeon revealed. The myth of the Deathking, so long regarded as nothing more than a story, looked to be possible! " +
                "The Warriors have been summoned to take the sword and enter the newly-opened dungeon, there to find and slay the Deathking once and for all before he rises from his grave.",
            SpecialRules =
                "Nominate one of the Warriors to carry the sword. If used in combat, the blade causes +1D6 Wounds on a successful attack, but automatically strikes an adjacent Warrior if the to hit roll is an unmodified 1.",
            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the tomb chamber contains. " +
                "Once the Monsters are defeated, the Warriors may lift the tomb and slay the Deathking. Although he is still weak, he will try to stop them. His willpower crackles in the air, rooting the Warriors to the spot. His voice echoes in the darkness, challenging the puny mortals who have come to slay him to a battle of wills to determine the victor. " +
                "Before they can kill him, the Warriors must overcome this powerful magic. Roll 1D6 for each Warrior taking part in the battle. If the combined score is 13 or more, the curse is broken and the Deathking can be slain. If the total is less than 13, the Warriors' minds are broken by the power of the Necromancer, and they become mindless thralls of the Deathking, the first to swell the ranks of his army. " +
                "In the tomb is 1D6 x 100 gold, to be shared equally amongst the Warriors. Once the dungeon is finished, the Warriors may safely make their way to freedom, having slain all the monsters in the dungeon.",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.TombChamber,
            Roll = 3,
            Title = "Return the Crown",
            Background =
                "Between the Dwarf hold of Karak Izor and the Dwarf Sea Fortress of Barak Varr lies a small realm, a border principality known as Heldegrad. Normally allied to the cause of the Dwarfs, the rulers of this small state have been thrown into turmoil by the discovery of the ancient and long-lost tomb of their ancestor-Kings, renowned to contain the true crown of the realm. " +
                "This labyrinthine burial ground lies near Karak Izor, and the king demands that the crown of his forefathers is returned to him by the Dwarfs or he will shut down all the trade routes from Barak Varr to Karak Izor. Not wishing to plunge the longstanding allies into bloodshed, and acknowledging the king's right to the ancient crown, the Dwarf Lord of Karak Izor has allowed the Warriors to descend into the long-forgotten tunnels in search of the ancient relic.",
            SpecialRules =
                "In the first dungeon room that the Warriors enter there is an ancient chest, locked and chained to the ground. Once they have resolved the Event Card for this room, the Warriors may examine it. The chest bears the heraldic crest of Heldegrad on its lid, and obviously contains the crown. Unfortunately, it cannot be opened or shifted, even using magic. To open it the Warriors must find the key that lies elsewhere in the dungeon and return here with it. Put the Dungeon Card for this room to one side to remind yourself where the chest is.",
            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the tomb chamber contains. " +
                "Once the Monsters are defeated, the Warriors may search the chamber, whereupon they find a key in a small alcove in the side of the tomb. This key will open the chest in the first dungeon room. " +
                "The Warriors must return to the chest, turn by turn, testing for Unexpected Events in the Power Phase as usual. Any dungeon rooms that they pass through for a second time do not trigger new Event Cards. The chest contains the crown, which may now be returned to Heldegrad. Once the crown is returned, each Warrior gets one Treasure Card as reward for his part in the adventure.",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.TombChamber,
            Roll = 4,
            Title = "The Hero Awakens",
            Background =
                "To the north of the Empire, bordering on the Northern Wastes and Troll Country, lies the frozen land of Kislev. Beset by the rampaging hordes of Chaos, Kislev is teetering on the brink of destruction, and its people are losing heart as they suffer defeat after defeat. To the south, their Empire allies are under attack from massed armies of Orcs and Goblins, and can send little aid. Kislev needs a hero to lead them out of this time of darkness, to bring fire back to cold hearts and determination to lift battered spirits. " +
                "The Ice Queen of Kislev knows a legend of just such a hero, but he passed from the land centuries ago. Reputed to be a descendant of Sigmar himself, Heinrich Sigmasson led a glorious campaign against the Chaos hordes in years past, driving them back beyond the mountains of the Northern Wastes. " +
                "At the final battle, however, he suffered a mortal wound, and was buried in a tomb somewhere in the far off mountains. But even on his death bed he promised to return if Kislev was once again threatened by the Chaos hordes. The Ice Queen has asked the Warriors to journey into the mountains and reawaken Heinrich so that he can keep his promise.",
            SpecialRules =
                "Before the Warriors depart, the Ice Queen gives the Wizard a shard of glass that she believes will help awaken Heinrich. The shard contains 1D6+2 Power Tokens (roll at the start of the adventure to see how much power the shard contains). The shard may be used at any time to augment the Wizard's spell casting.",
            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the tomb chamber contains. " +
                "Once the Monsters are defeated, the Warriors may try to awaken Heinrich. Looking inside the tomb, his body is perfectly preserved, and it appears as if he is asleep rather than dead. " +
                "Heinrich can only be awakened by the Wizard as he has been put to sleep by powerful magic. The Wizard has one chance to wake him, during the first Warriors' Phase after all the Monsters in the room are dead. " +
                "To awaken Heinrich, the Wizard must expend great magical energy and break the enchantments binding Heinrich. Roll 1D6 and add all the Power Points left in the shard of glass, plus any Power Points and Power Tokens that the Wizard has left to the result. If the total is 12 or more, the spell is broken and Heinrich awakens. If the total is less than 12, Heinrich's body crumbles to dust - the Warriors have failed in their quest. " +
                "If the Warriors succeed, Heinrich will lead them back to Kislev via a concealed door at the rear of the tomb chamber. The Warriors are rewarded with 1D6 x 50 gold each. " +
                "If the Warriors fail, they are lucky to escape with their lives, and Kislev will have to win the war against Chaos unaided!",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.TombChamber,
            Roll = 5,
            Title = "Destroy the Tomb",
            Background =
                "The Dwarf Lords of Karak Azul have recently deciphered an ancient Dwarf scroll written in runes so old that even the Dwarfs have taken many years to identify their true meaning. Early on, the Dwarfs realised that it described a shrine of great magical power located somewhere in the Worlds Edge Mountains, beneath the tomb of a mighty Warrior. The Dwarfs knew that to find the shrine would put them in control of the most powerful forces they could possibly unleash upon their foes. The exact location was a mystery until recently when, after many years of painstaking work, it was finally pinpointed. To the Dwarfs' horror, they realised that the shrine was directly below the Orc Fortress of Iron Rock. " +
                "The Dwarfs decided that the shrine had to be destroyed to prevent it falling into Orc hands. If the Orcs should find it, who knows what they would do? An attack by a large force would raise the Orcs' suspicions about the Dwarfs' motives, so the Dwarfs have asked the Warriors to sneak into the Orc stronghold to destroy the shrine.",
            SpecialRules = string.Empty,
            ObjectiveRoomRules =
                "The shrine is in the tomb chamber, directly beneath the tomb itself. Roll on the Objective Room Monster Table to determine what Monsters the tomb chamber contains. " +
                "Once the Monsters are defeated, the Dwarf may attempt to destroy the tomb. Only the Dwarf may damage the tomb, as he is the only one bearing a Dwarf axe. None of the other Warriors can damage the tomb. As long as the Dwarf is standing in a square adjacent to the tomb he automatically hits it. The tomb has a Toughness of 3 and has 12 Wounds. " +
                "At the start of each turn in which the tomb remains intact and while there are no Monsters on the board, take an Event Card. Before the tomb can be hit again, the Event Card must be resolved. " +
                "Once the Warriors have destroyed the tomb, and the shrine with it, a gaping hole is revealed in the rubble, leading down into blackness. This tunnel eventually leads out of the dungeon and back to Karak Azul. " +
                "Once they reach the Dwarf Citadel, each Warrior is rewarded with one Treasure Card from the Treasure Deck.",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.TombChamber,
            Roll = 6,
            Title = "Identify",
            Background =
                "The Warriors have been employed to carry out an apparently simple task, for which they will be well paid. All they have to do is solve an inheritance dispute between two Imperial Lords, by correctly identifying a body buried in a far away tomb in the Worlds Edge Mountains.",
            SpecialRules = string.Empty,
            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the tomb chamber contains. " +
                "Once the Monsters are defeated, the Warriors may lift back the lid of the tomb and determine who the body belongs to. Roll 1D6 on the following table: " +
                "1-3: The skeleton has no teeth. " +
                "4-6: The skeleton is missing its left hand. " +
                "Having identified the body, the Warriors may make their way to the surface. As they have killed all the Monsters in the dungeon, the way out is clear and they may exit without even rolling for Unexpected Events. " +
                "If the skeleton has no teeth, it belongs to the household of Luckstein, an honourable family who reward the Warriors with 1D6 x 100 gold each for sorting out the inheritance question once and for all. " +
                "If the skeleton is missing its left hand, it belongs to the household of Bravia, whose current Lord is a scheming, arrogant individual. When the Warriors get back, he proclaims he has discovered the truth himself, denies any deal with the Warriors, and refuses to pay them a penny!",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.IdolChamber,
            Roll = 1,
            Title = "Sacrifice?",
            Background =
                "One of the Warriors' kinsmen has been captured by Orcs, and even now he is being tortured in their lair. He is to be sacrificed to their foul gods unless the Warriors can rescue him.",
            SpecialRules =
                "Randomly determine the Warrior whose kinsman has been captured using the Warrior Counters. " +
                "At the start of each Power Phase, before doing anything else, roll 3D6. If all the dice come up the same number the Warriors are too late - the prisoner has been sacrificed! You hear his agonised screams echoing down the dark tunnels. " +
                "With the exception of the Warrior whose kinsman has just been sacrificed, the Warriors may choose whether to carry on and avenge the prisoner's death, or to give up and return to the surface. The Warrior whose kinsman has been sacrificed has no choice, and he must go on and avenge the death of his blood relative.",
            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the idol chamber contains. " +
                "The Monsters are guarding the prisoner, who is bound in chains in front of a foul idol of Chaos. The Warrior who is his kinsman is so enraged by the sight of his relative like this that he goes insane with battle fury. For the rest of the game, that Warrior is at -1 Weapon Skill and +1 Attacks. " +
                "Once the prisoner is freed, he shows the Warriors a secret way out of the dungeon that leads past a treasure chamber. From this room, each Warrior may take 2D6 x 50 gold to the surface with him.",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.IdolChamber,
            Roll = 2,
            Title = "Desecration",
            Background =
                "Deep in the ruined cities of the Dwarfs, now occupied by Orcs, Goblins and even worse creatures, many of the once noble temples and shrines have been defiled. In their place are crude altars set up by these evil creatures, dedicated to all manner of foul Gods. Apart from the obvious pleasure of killing the invaders of their ancestral homes, and hopefully recovering some of the long-lost treasures, the Dwarf Kings also pay a rich reward for every evil temple destroyed. " +
                "The Warriors have been charged with the task of locating one of these temples that is reputed to lie deep below the ground in the ruins of Karak Azgal. Kargun Skalfson, deposed Lord of Karak Azgal, has allowed the Warriors into the ruins to search for the temple, and has waived his right to a share of any treasure they discover on the way - as long as they bring back evidence of the destruction of the temple. " +
                "Secretly, Skalfson does not believe there is a temple, and therefore hopes to persuade the Warriors to venture into the most dangerous regions of Karak Azgal in search of it. If they survive these hazardous, long-unexplored regions, they will surely find a great deal of treasure - and as there is no temple, he will gain his share of the treasure as usual. " +
                "In actual fact, Skalfson is wrong and there is a temple in the ruins, dedicated to Khorne, the blood god.",
            SpecialRules = string.Empty,
            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the idol chamber contains. " +
                "Once the Monsters are defeated, the Warriors may destroy the temple by overturning the idol and thus desecrating it. They may then cut off its head as proof that they have successfully completed their mission. " +
                "To overturn the idol, all the Warriors must be standing in squares adjacent to it. Roll 1D6 for each Warrior and add their Strengths. If the total is equal to 24 or over, the idol topples to the ground with a crash, and the head rolls free. If the total is less than 24, the idol remains standing. The Warriors may attempt to destroy the idol once per turn, during the Warriors' Phase, as long as they do nothing else. " +
                "For each turn that the idol remains standing, the Wizard deducts 2 from his Power roll in the Power Phase. If the modified result is 1 or less, an Unexpected Event occurs. The Unexpected Event must be resolved before the Warriors can try to smash the idol again. " +
                "When the idol is smashed, a hideous scream echoes through the dungeon, causing all the monsters for miles around to flee in terror. This means that the Warriors can find their way back to the surface quite safely. At the end of the adventure, because there was an idol, Skalfson is obliged to let them keep all the treasure they found!",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.IdolChamber,
            Roll = 3,
            Title = "Kill the Shaman",
            Background =
                "A powerful Goblin Shaman is foretelling of a great Waaagh to come soon, when the Goblins and Orcs will sweep out of the Dark Lands and overthrow the Empire. Although not very powerful at the moment, his cult is growing stronger and unrest is beginning to stir. " +
                "So as not to raise suspicions and warn him of his intentions, the Emperor has decreed that the best way to solve the crisis is to assassinate the Shaman. The Warriors have been chosen to venture into the Shaman's lair below Mount Gunbad, on the far side of the Worlds Edge Mountains, and kill him.",
            SpecialRules = string.Empty,
            ObjectiveRoomRules =
                "When the Warriors reach the idol chamber they will find that it contains 11 Goblins plus the Shaman. The Goblins are placed on the board according to the normal rules, while the Shaman starts in a square adjacent to the idol at the far end of the room. " +
                "The Shaman will avoid combat if possible. He is not subject to the normal rules for pinning, and may move around freely, always trying to stay as far away from the Warriors as he can. Apart from that, his profile is exactly the same as the other Goblins. " +
                "The Shaman's attack is to try and cast a 'Hand of Mork' spell at the Warriors at the start of each Monsters' Phase. Roll 1D6. On a score of 4, 5 or 6 the spell succeeds. Use the Warrior Counters to determine who is hit. That Warrior takes 1D6 x 2 Wounds, modified for Toughness and armour. " +
                "Once all the Monsters in the room, including the Shaman, are dead, the Warriors find a concealed entrance behind the idol leading out into the light of day. They may carry the Goblin Shaman's body back through this passage as evidence that they have killed him when they go back before the Emperor. If the mission is a success, each Warrior is rewarded with 1D6 x 50 gold.",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.IdolChamber,
            Roll = 4,
            Title = "Daemon Summoning",
            Background =
                "The Middle Mountains lie deep within the forests of the Empire, and are a wild and dangerous place. Although the Orcs, Goblins and other evil creatures that live in the mountain caves are a great hazard to travellers, in the past they have not been considered to be numerous or organised enough to threaten the security of the Empire itself. " +
                "Now, however, a threat from one of their number has arisen, and must be eradicated quickly, or all manner of disasters will befall the Empire. A Skaven Warlord has discovered an ancient temple deep below the mountains, and within it a lifelike effigy of a mighty daemon that could summon the beast itself. " +
                "The Skaven Warlord and his minions are doing their utmost to summon the daemon, believing they can bind it to do their will using braziers of burning warpstone. " +
                "The Empire's Battle Wizards have scried something of this threat, and the Warriors have been dispatched with great haste to prevent the daemon being summoned.",
            SpecialRules =
                "To stop the Skaven's evil work, the Wizard has been given a Scroll of Banishment by the head Wizards of the Empire. This ancient parchment must be guarded well, for it is the only thing that can stop the daemon being summoned.",
            ObjectiveRoomRules =
                "The idol chamber is guarded by 12 Skaven. All but one of the Skaven are placed according to the normal rules. The final Skaven should be placed on the plinth, next to the brazier. This Skaven will stay on this spot unless attacked by a Warrior, as he is to act as the channel for the daemon's soul and must be near the idol to complete the summoning. " +
                "The Warriors have 1D6 turns to kill all the Skaven, starting from the turn they enter the room. Once all the Skaven are dead, the Wizard may read aloud the Scroll of Banishment. As he does so, an anguished roar fills the air. The summoning is thwarted and the statue is destroyed in a great fire column that leaps up to the ceiling of the temple. " +
                "If they do not thwart the summoning in time, in the Monsters' Phase of the final turn the daemon wakes and possesses the Skaven nearest to the statue. In the space of a few seconds the Skaven grows and changes, taking on the form of a mighty bull-headed man - a Minotaur. " +
                "The Daemon Minotaur is similar to the Minotaur in the Rule Book, except it has 20 Wounds and 3 Attacks. It will attack the Warriors just as if it were a normal Monster. If the Warriors kill the Daemon Minotaur, it bursts into flames and creates a fire column that shoots up to the roof of the cavern. " +
                "The mighty column of fire that hits the roof, whether created by the statue or the Minotaur exploding, creates a near vertical tunnel to the outside world. Although this takes some climbing, the Warriors eventually emerge into the daylight. Upon their return to the Empire, they are rewarded with 1D6 x 150 gold each for their part in this great adventure.",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.IdolChamber,
            Roll = 5,
            Title = "Return the Staff",
            Background =
                "As a final test of their courage and bravery before being accepted into the official Warriors' Guild of Bretonnia, the Warriors must fulfil a challenging task. They must descend into the labyrinthine tunnels of the Cursed Pit, which lies below Cripple Peak near the Dark Lands, and place a staff in the hand of an idol hidden deep underground. The staff has magical properties, and if left anywhere other than in the hand of the idol, it will eventually return to the throne room of Bretonnia.",
            SpecialRules = string.Empty,
            ObjectiveRoomRules =
                "Roll on the Objective Room Monster Table to determine what Monsters the idol chamber contains. In addition, take the next Monster Event Card from the Event Deck and add those Monsters to those rolled. This is a particularly hazardous chamber! " +
                "Once the Monsters are defeated, the Warriors may place the staff in the hand of the idol, completing their adventure. As they have killed all the Monsters in the vicinity already, they may now escape from the dungeon without danger. Upon their return to Bretonnia, the king rewards them with one item of treasure each. Take one Treasure Card for each Warrior.",
            Notes = string.Empty
        },

        new Adventure
        {
            ObjectiveRoom = ObjectiveRoomType.IdolChamber,
            Roll = 6,
            Title = "Sword of the Electors",
            Background =
                "One of the long-lost swords of the Elector Counts of the Empire, missing for centuries, has been found by a band of warriors in the Worlds Edge Mountains, near the Dwarf Hold of Mount Grimfang. Unfortunately, before they could return the blade to safety, all but one of the warriors were killed. The one warrior who survived, although tortured and badly mutilated, managed to escape and get back to the Emperor to tell his story. " +
                "The Warriors have been requested to seek out this extremely important sword and return it.",
            SpecialRules = string.Empty,
            ObjectiveRoomRules =
                "The sword is being kept in the idol chamber, clasped in the hand of the stone idol. " +
                "Roll on the Objective Room Monster Table to determine what Monsters the idol chamber contains. " +
                "Once the Monsters have been defeated, the Warriors may try and retrieve the sword. Each Warrior may make one attempt to get the sword each turn. To do so, a Warrior must stand in one of the squares adjacent to the idol. Roll 1D6 and add the Warrior's Strength. If the total is 7 or more, he has succeeded and wrenches the sword free. If the total is less than 7, the idol suddenly animates and strikes the Warrior. The attack automatically hits and does 3D6 Wounds, modified for Toughness and armour. The idol then becomes immobile once more. The same Warrior cannot try again until all the Warriors have attempted the task. " +
                "If the Warriors retrieve the sword, they are rewarded with 1D6 x 50 gold each.",
            Notes = string.Empty
        }
    };

    public static Adventure GetAdventure(
        ObjectiveRoomType objectiveRoom,
        int roll)
    {
        return All.Single(a =>
            a.ObjectiveRoom == objectiveRoom &&
            a.Roll == roll);
    }

    public static List<Adventure> GetAdventuresForObjectiveRoom(
        ObjectiveRoomType objectiveRoom)
    {
        return All
            .Where(a => a.ObjectiveRoom == objectiveRoom)
            .OrderBy(a => a.Roll)
            .ToList();
    }
}