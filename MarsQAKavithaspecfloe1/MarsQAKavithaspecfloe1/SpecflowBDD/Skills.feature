Feature: Skills

As a I would like to add, edit, delete me skills on my profile so that I can manage my skills successfully
@Add
Scenario: Add my skills on profile
	Given I Loged into Mars portal
	When I add my skills on my profile
	Then the skills should added successfully


@Edit
Scenario Outline: Edit my skills on profile
	Given I Loged into Mars portal
	When I edit my '<skill>' and '<level>'on the existing record
	Then the skills record should edited '<skill>' and '<level>'

	Examples: 
| Skill          | Level        |
| Graphic Design | Beginner     |
| Translation    | Intermediate |
| Teaching       | Expert       |

Scenario: Delete skill on profile
	Given I Loged into Mars portal
	When I delete the skill on my profile
	Then the skills should deleted successfully