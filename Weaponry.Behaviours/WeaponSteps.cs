using Should.Fluent;
using TechTalk.SpecFlow;
using Weaponry.Model;

namespace Weaponry.Behaviours
{
    [Binding]
    public class WeaponSteps
    {
        Knight _knight = new Knight();

        [Given(@"I have a Hammer")]
        public void GivenIHaveAHammer()
        {
            Hammer hammer = new Hammer();
            _knight.SetWeapon(hammer);
            _knight.CurrentWeapon.Should().Equal(hammer);
        }

        [Given(@"I have an Axe")]
        public void GivenIHaveAnAxe()
        {
            Axe axe = new Axe();
            _knight.SetWeapon(axe);
            _knight.CurrentWeapon.Should().Equal(axe);
        }

        [Given(@"I have a Sword")]
        public void GivenIHaveASword()
        {
            Sword sword = new Sword();
            _knight.SetWeapon(sword);
            _knight.CurrentWeapon.Should().Equal(sword);
        }

        [When(@"I use it")]
        public void WhenIUseIt()
        {
            _knight.fight();
        }

        [Then(@"it should bash")]
        public void ThenItShouldBash()
        {
            Weapon w = (Weapon)_knight.CurrentWeapon;
            w.Effect.Should().Equal("Bash!");
        }

        [Then(@"it should chop")]
        public void ThenItShouldChop()
        {
            Weapon w = (Weapon)_knight.CurrentWeapon;
            w.Effect.Should().Equal("Chop!");
        }

        [Then(@"it should swish")]
        public void ThenItShouldSwish()
        {
            Weapon w = (Weapon)_knight.CurrentWeapon;
            w.Effect.Should().Equal("Swish!");
        }
    }
}
