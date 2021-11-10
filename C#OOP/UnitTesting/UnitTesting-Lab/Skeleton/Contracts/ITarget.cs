using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
    public interface ITarget
    {
        void TakeAttack(int attackPoints);

        bool IsDead();

        int GiveExperience();
    }
}
