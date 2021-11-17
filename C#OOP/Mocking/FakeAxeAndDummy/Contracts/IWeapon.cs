using System;
using System.Collections.Generic;
using System.Text;

namespace FakeAxeAndDummy.Contracts
{
    public interface IWeapon
    {
        public void Attack(ITarget target);
    }
}
