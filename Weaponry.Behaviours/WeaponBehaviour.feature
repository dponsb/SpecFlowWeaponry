Feature: UseWeapon
	In order to crush my enemies
	As a Character
	I want to be able to use a weapon

Scenario: Use a Sword
	Given I have a Sword
	When I use it
	Then it should swish

Scenario: Use a Hammer
	Given I have a Hammer
	When I use it
	Then it should bash

Scenario: Use an Axe
	Given I have an Axe
	When I use it
	Then it should chop
