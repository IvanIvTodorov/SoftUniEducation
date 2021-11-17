using System;
using System.Collections.Generic;
using System.Text;

namespace FakeAxeAndDummy.Contracts
{
    public interface ITarget
    {
        public void TakeAttack(int points);

        public int GiveExperience();

        public bool IsDead();

    }
}
