using System;
using System.Collections.Generic;
using System.Text;

namespace Help_Lone
{
    public interface ICharacter
    {
        //this interface implements basic character abilities
        void Heal();
        void Die();
        void Fight();
    }
}
