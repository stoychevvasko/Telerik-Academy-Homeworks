using System;
using System.Linq;
using Microsoft.Xna.Framework;

namespace DeBugger
{
    

    public class Enemy
    {

        public struct EnemyData
        {
            public Vector2 Position;
            public bool IsAlive;
            public Color Color;
        }

        EnemyData[] enemies;
        int numberOfEnemies = 2;

        public void SetUpEnemies()
        {
            enemies = new EnemyData[numberOfEnemies];

            enemies[0].Position = new Vector2(100, 193);    // Hard-coded
            enemies[1].Position = new Vector2(200, 212);    // Hard-coded

            for (int i = 0; i < numberOfEnemies; i++)
            {
                enemies[i].IsAlive = true;
                enemies[i].Color = Color.Red;
            }

            
        }
    }
}