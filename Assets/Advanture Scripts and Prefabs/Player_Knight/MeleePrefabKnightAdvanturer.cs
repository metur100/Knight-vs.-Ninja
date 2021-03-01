﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleePrefabKnightAdvanturer : MonoBehaviour
{
    public Rigidbody2D rb;
    public int damageDoneMeleeAttack = -20; //it deals 40 damage close range, 20 damage long range
    private readonly float speedOfMeleeAttack = 100f;

    void Start()
    {
        StartCoroutine(DestroyGameobject());
        rb.velocity = transform.right * speedOfMeleeAttack;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Slime_AI":
                SlimeHealthPatrol eHealth = other.gameObject.GetComponent<SlimeHealthPatrol>();
                eHealth.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Slime_AI_2":
                SlimeHealthPatrol2 eHealth1 = other.gameObject.GetComponent<SlimeHealthPatrol2>();
                eHealth1.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Slime_AI_3":
                SlimeHealthPatrol3 eHealth2 = other.gameObject.GetComponent<SlimeHealthPatrol3>();
                eHealth2.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Slime_AI_4":
                SlimeHealthPatrol4 eHealth3 = other.gameObject.GetComponent<SlimeHealthPatrol4>();
                eHealth3.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI":
                TrunkHealth eHealth4 = other.gameObject.GetComponent<TrunkHealth>();
                eHealth4.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_2":
                TrunkHealth2 eHealth5 = other.gameObject.GetComponent<TrunkHealth2>();
                eHealth5.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_3":
                TrunkHealth3 eHealth6 = other.gameObject.GetComponent<TrunkHealth3>();
                eHealth6.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_4":
                TrunkHealth4 eHealth7 = other.gameObject.GetComponent<TrunkHealth4>();
                eHealth7.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_5":
                TrunkHealth5 eHealth8 = other.gameObject.GetComponent<TrunkHealth5>();
                eHealth8.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_6":
                TrunkHealth6 eHealth9 = other.gameObject.GetComponent<TrunkHealth6>();
                eHealth9.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_7":
                TrunkHealth7 eHealth10 = other.gameObject.GetComponent<TrunkHealth7>();
                eHealth10.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bee_AI":
                BeeHealth eHealth11 = other.gameObject.GetComponent<BeeHealth>();
                eHealth11.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bee_AI_2":
                BeeHealth2 eHealth12 = other.gameObject.GetComponent<BeeHealth2>();
                eHealth12.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Snail_AI":
                SnailHealth eHealth13 = other.gameObject.GetComponent<SnailHealth>();
                eHealth13.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Snail_AI_2":
                SnailHealth2 eHealth14 = other.gameObject.GetComponent<SnailHealth2>();
                eHealth14.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Snail_AI_3":
                SnailHealth3 eHealth15 = other.gameObject.GetComponent<SnailHealth3>();
                eHealth15.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Snail_AI_4":
                SnailHealth4 eHealth16 = other.gameObject.GetComponent<SnailHealth4>();
                eHealth16.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Turtle_AI":
                TurtleHealth eHealth17 = other.gameObject.GetComponent<TurtleHealth>();
                eHealth17.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Turtle_AI_2":
                TurtleHealth2 eHealth18 = other.gameObject.GetComponent<TurtleHealth2>();
                eHealth18.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Turtle_AI_3":
                TurtleHealth3 eHealth19 = other.gameObject.GetComponent<TurtleHealth3>();
                eHealth19.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "BlueBird_AI":
                BlueBirdHealth eHealth20 = other.gameObject.GetComponent<BlueBirdHealth>();
                eHealth20.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "BlueBird_AI_2":
                BlueBirdHealth2 eHealth21 = other.gameObject.GetComponent<BlueBirdHealth2>();
                eHealth21.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "BlueBird_AI_3":
                BlueBirdHealth3 eHealth22 = other.gameObject.GetComponent<BlueBirdHealth3>();
                eHealth22.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Ghost_AI":
                GhostHealth eHealth23 = other.gameObject.GetComponent<GhostHealth>();
                eHealth23.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Suprise_Box":
                SupriseBoxHealth eHealth24 = other.gameObject.GetComponent<SupriseBoxHealth>();
                eHealth24.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Suprise_Box_2":
                SupriseBoxHealth2 eHealth25 = other.gameObject.GetComponent<SupriseBoxHealth2>();
                eHealth25.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Suprise_Box_3":
                SupriseBoxHealth3 eHealth26 = other.gameObject.GetComponent<SupriseBoxHealth3>();
                eHealth26.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bat_AI":
                BatHealth eHealth27 = other.gameObject.GetComponent<BatHealth>();
                eHealth27.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "GreenPig_AI":
                GreenPigHealth eHealth28 = other.gameObject.GetComponent<GreenPigHealth>();
                eHealth28.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Plant_AI":
                PlantHealth eHealth29 = other.gameObject.GetComponent<PlantHealth>();
                eHealth29.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Plant_AI_2":
                PlantHealth2 eHealth30 = other.gameObject.GetComponent<PlantHealth2>();
                eHealth30.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Radish_AI":
                RadishHealth eHealth31 = other.gameObject.GetComponent<RadishHealth>();
                eHealth31.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bunny_AI":
                BunnyHealth eHealth32 = other.gameObject.GetComponent<BunnyHealth>();
                eHealth32.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Mushroom_AI":
                MushroomHealth eHealth33 = other.gameObject.GetComponent<MushroomHealth>();
                eHealth33.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Mushroom_AI_2":
                MushroomHealth2 eHealth34 = other.gameObject.GetComponent<MushroomHealth2>();
                eHealth34.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bunny_AI_2":
                BunnyHealth2 eHealth35 = other.gameObject.GetComponent<BunnyHealth2>();
                eHealth35.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Mushroom_AI_3":
                MushroomHealth3 eHealth36 = other.gameObject.GetComponent<MushroomHealth3>();
                eHealth36.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Radish_AI_3":
                RadishHealth3 eHealth37 = other.gameObject.GetComponent<RadishHealth3>();
                eHealth37.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Radish_AI_4":
                RadishHealth4 eHealth38 = other.gameObject.GetComponent<RadishHealth4>();
                eHealth38.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Mushroom_AI_4":
                MushroomHealth4 eHealth39 = other.gameObject.GetComponent<MushroomHealth4>();
                eHealth39.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Mushroom_AI_5":
                MushroomHealth5 eHealth40 = other.gameObject.GetComponent<MushroomHealth5>();
                eHealth40.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Chest_Box":
                ChestHealth eHealth41 = other.gameObject.GetComponent<ChestHealth>();
                eHealth41.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Chest_Box_2":
                ChestHealth2 eHealth42 = other.gameObject.GetComponent<ChestHealth2>();
                eHealth42.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Chest_Box_3":
                ChestHealth3 eHealth43 = other.gameObject.GetComponent<ChestHealth3>();
                eHealth43.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bunny_AI_3":
                BunnyHealth3 eHealth44 = other.gameObject.GetComponent<BunnyHealth3>();
                eHealth44.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bat_AI_2":
                BatHealth2 eHealth45 = other.gameObject.GetComponent<BatHealth2>();
                eHealth45.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bat_AI_3":
                BatHealth3 eHealth46 = other.gameObject.GetComponent<BatHealth3>();
                eHealth46.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bat_AI_4":
                BatHealth4 eHealth47 = other.gameObject.GetComponent<BatHealth4>();
                eHealth47.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bat_AI_5":
                BatHealth5 eHealth48 = other.gameObject.GetComponent<BatHealth5>();
                eHealth48.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bat_AI_6":
                BatHealth6 eHealth49 = other.gameObject.GetComponent<BatHealth6>();
                eHealth49.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Rino_AI":
                RinoHealth eHealth50 = other.gameObject.GetComponent<RinoHealth>();
                eHealth50.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Rino_AI_2":
                RinoHealth2 eHealth51 = other.gameObject.GetComponent<RinoHealth2>();
                eHealth51.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Rino_AI_3":
                RinoHealth3 eHealth52 = other.gameObject.GetComponent<RinoHealth3>();
                eHealth52.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Rino_AI_4":
                RinoHealth3 eHealth53 = other.gameObject.GetComponent<RinoHealth3>();
                eHealth53.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_8":
                TrunkHealth8 eHealth54 = other.gameObject.GetComponent<TrunkHealth8>();
                eHealth54.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_9":
                TrunkHealth9 eHealth55 = other.gameObject.GetComponent<TrunkHealth9>();
                eHealth55.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_10":
                TrunkHealth10 eHealth56 = other.gameObject.GetComponent<TrunkHealth10>();
                eHealth56.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Trunk_AI_11":
                TrunkHealth11 eHealth57 = other.gameObject.GetComponent<TrunkHealth11>();
                eHealth57.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bat_AI_7":
                BatHealth7 eHealth58 = other.gameObject.GetComponent<BatHealth7>();
                eHealth58.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bat_AI_8":
                BatHealth8 eHealth59 = other.gameObject.GetComponent<BatHealth8>();
                eHealth59.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Bat_AI_9":
                BatHealth9 eHealth60 = other.gameObject.GetComponent<BatHealth9>();
                eHealth60.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Chest_Box_4":
                ChestHealth4 eHealth61 = other.gameObject.GetComponent<ChestHealth4>();
                eHealth61.ModifyHealth(damageDoneMeleeAttack);
                break;
            case "Radish_AI_2":
                RadishHealth2 eHealth62 = other.gameObject.GetComponent<RadishHealth2>();
                eHealth62.ModifyHealth(damageDoneMeleeAttack);
                break;

        }
    }
    IEnumerator DestroyGameobject()
    {
        yield return new WaitForSeconds(0.09f);
        Destroy(gameObject);
    }
}