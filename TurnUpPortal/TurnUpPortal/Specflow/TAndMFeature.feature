Feature: TAndMFeature

As a TurnUp portal admin user
I would like to create, edit and delete time and material records
So that I can manage employees time and materials successfully

Background: 
	Given I logged into TurnUp portal successfully
	When I navigate to Time and Material page

@regression
Scenario: create time record with valid data
	
	When I create a time record 
	Then The record should be created successfully

Scenario Outline: edit existing time record with valid data
	
	When I update the '<Code>' and '<Description>' on an existing Time record
	Then the record should have the updated '<Code>' and '<Description>'

	Examples: 
	| Code              | Description |
	| IC Programme      | Laptop      |
	| Test Analyst      | Monitor     |
	| UpdatedRecord     | Tablet      |

Scenario: delete existing time record
	
	When I delete an existing record
	Then the record should not be present on the table


