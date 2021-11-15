﻿using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using MathLibrary;

namespace MathForGamesAssessment
{
    class Dash : Ability
    {

        public Dash(Player player, Vector4 abilityColor, float abilityScale, float abilityCollisionRadius, float abilitySpeed, float abilityDuration)
            : base(player, abilityColor, abilityDuration)
        {
            AbilityScale = abilityScale;
            AbilityCollisionRadius = abilityCollisionRadius;
            AbilitySpeed = abilitySpeed;
        }

        public override void Start()
        {
            base.Start();

            Player.SetScale(AbilityScale, AbilityScale, AbilityScale);
            Player.Speed = AbilitySpeed;
            CircleCollider playerCollider = new CircleCollider(AbilityCollisionRadius, Player);
        }

        public override void Update(float deltaTime)
        {
           

            if (AbilityTimer < AbilityDuration)
            {
                Player.TimeBetweenShots = 0;
                AbilityTimer += deltaTime;
                return;
            }

            base.End();
        }


    }
}
