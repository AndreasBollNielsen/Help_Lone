﻿using System;

namespace Help_Lone
{
    partial class Program
    {
        public class Witch : ICharacter,Ishield,iMagicMove
        {
            public void Die()
            {
                Console.WriteLine("I'm dying");
            }

            public void Fight()
            {
                Console.WriteLine("I'm fighting");
            }

            public void Heal()
            {
                Console.WriteLine("I'm healing");
            }

            public void RaiseShield()
            {
                Console.WriteLine("I'm raising my shield");
            }

            public void ShieldGlare()
            {
                Console.WriteLine("I'm throwing shield glare");
            }

            public void Teleport(int x, int y)
            {
                Console.WriteLine("I'm teleporting to " + x + " " + y);
            }
        
        }

    }
    }

