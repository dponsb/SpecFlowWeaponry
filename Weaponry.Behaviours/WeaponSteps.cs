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
            hammer.Should().Equal(_knight.CurrentWeapon);
        }

        [Given(@"I have an Axe")]
        public void GivenIHaveAnAxe()
        {
            Axe axe = new Axe();
            _knight.SetWeapon(axe);
            axe.Should().Equal(_knight.CurrentWeapon);
        }

        [Given(@"I have a Sword")]
        public void GivenIHaveASword()
        {
            Sword sword = new Sword();
            _knight.SetWeapon(sword);
            sword.Should().Equal(_knight.CurrentWeapon);
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
